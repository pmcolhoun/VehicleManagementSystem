using System;
using Xunit;

// importing dependencies from the Data Project
using VMS.Data.Models;
using VMS.Data.Services;

namespace VMS.Test
{
    public class TestVehicleService
    {
       
        private readonly IVehicleService svc;

        public TestVehicleService()
        {
            //General arrangement 
            svc = new VehicleDbService();

            //Ensure database is empty before each test
            svc.Initialise();
        }

        [Fact]
        public void AddVehicle_WhenNone_SetAllProperties()
        {
            var v1 = new Vehicle
            {
                Make = "Honda",
                Model = "Civic",
                Registration = "VUI 6465",
                EngineSize = 1800,
                DateOfReg = new DateTime (1998, 8, 17),
                Transmission = "Manual",
                C02 = 300,
                Fuel = "Petrol",
                Body = "Hatchback",
                Doors = 5
            };

            //act
            v1 = svc.AddVehicle(v1);

            //retrieve vehicle
            var v2 = svc.GetVehicleById(v1.VehicleId);

            //assert - that vehicle is not null
            Assert.NotNull(v2);

            //assert that properties were set properly
            Assert.Equal(v2.VehicleId, v2.VehicleId);
            Assert.Equal("Honda", v2.Make);
            Assert.Equal("Civic", v2.Model);
            Assert.Equal(new DateTime (1998, 8, 17), v2.DateOfReg);
            Assert.Equal("Manual", v2.Transmission);
            Assert.Equal(300, v2.C02);
            Assert.Equal("Petrol", v2.Fuel);
            Assert.Equal("Hatchback", v2.Body);
            Assert.Equal(5, v2.Doors);
        }

        [Fact] 
        public void UpdateVehicle_ThatExists_SetAllProperties()
        {
            
            //arrange
            var v1 = svc.AddVehicle(new Vehicle
            {
                Make = "Honda",
                Model = "Civic",
                Registration = "VUI 6465",
                EngineSize = 1800,
                DateOfReg = new DateTime (1998, 8, 17),
                Transmission = "Manual",
                C02 = 300,
                Fuel = "Petrol",
                Body = "Hatchback",
                Doors = 5
            });

            //act
            v1.Model = "Accord";
            v1 = svc.UpdateVehicle(v1.VehicleId, v1);

            //assert - that vehicle is not null
            Assert.NotNull(v1);
            Assert.Equal("Accord", v1.Model);
        }

        [Fact]
        public void GetAllVehicles_WhenNone_ShouldReturnZero()
        {
            //act
            var vehicles = svc.GetAllVehicles();
            var count = vehicles.Count;

            //assert
            Assert.Equal(0, count);
        }

        [Fact]
        public void GetVehicles_When2Added_ShouldReturn2()
        {
            //create vehicles to test
            var v1 = svc.AddVehicle(new Vehicle
            {
                Make = "Honda",
                Model = "Civic",
                Registration = "VUI 6465",
                EngineSize = 1800,
                Transmission = "Manual",
                C02 = 300,
                Fuel = "Petrol",
                Body = "Hatchback",
                Doors = 5
            });

           var v2 = svc.AddVehicle (new Vehicle
            {
                Make = "Audi",
                Model = "A4",
                Registration = "PKZ 9889",
                EngineSize = 1900,
                Transmission = "Automatic",
                C02 = 350,
                Fuel = "Diesel",
                Body = "Saloon",
                Doors = 5
            });

            var vehicles = svc.GetAllVehicles();
            var count = vehicles.Count;

            //assert
            Assert.Equal(2, count);
        }

        [Fact]
        public void GetVehicle_WhenNone_ShouldReturnNull()
        {
            //act
            var vehicle = svc.GetVehicleById(1);

            //assert
            Assert.Null(vehicle);
        }

        [Fact] 
        public void GetVehicle_WhenAdded_ShouldReturnVehicle()
        {
            //create vehicle to test
           var v1 = svc.AddVehicle(new Vehicle
            {
                Make = "Honda",
                Model = "Civic",
                Registration = "VUI 6465",
                EngineSize = 1800,
                Transmission = "Manual",
                C02 = 300,
                Fuel = "Petrol",
                Body = "Hatchback",
                Doors = 5
            });

            var v2 = svc.GetVehicleById(v1.VehicleId);

            //assert
            Assert.NotNull(v2);
            Assert.Equal(v1.VehicleId, v2.VehicleId);
        }

        [Fact] 
        public void DeleteVehicle_ThatExists_ShouldReturnTrue()
        {
            //create vehicle to be deleted from database
           var v1 = svc.AddVehicle(new Vehicle
            {
                Make = "Honda",
                Model = "Civic",
                Registration = "VUI 6465",
                EngineSize = 1800,
                Transmission = "Manual",
                C02 = 300,
                Fuel = "Petrol",
                Body = "Hatchback",
                Doors = 5
            });

            //act
            var deleted = svc.DeleteVehicle(v1.VehicleId);

            //assert
            Assert.True(deleted);
        }

        [Fact] 
        public void DeleteVehicle_ThatDoesntExist_ShouldNotWork()
        {
            //act
            var deleted = svc.DeleteVehicle(0);

            //assert
            Assert.False(deleted);
        }


        //              ---- Service Tests ----              \\          
        [Fact]                 
        public void AddService_WhenNoneExist_SetAllProperties()
        {
            //act
            var v1 = svc.AddVehicle(new Vehicle
            {
                Make = "Honda",
                Model = "Civic",
                Registration = "VUI 6465",
                EngineSize = 1800,
                DateOfReg = new DateTime (1998, 08, 17),
                Transmission = "Manual",
                C02 = 300,
                Fuel = "Petrol",
                Body = "Hatchback",
                Doors = 5
            });

            var s1 = svc.AddService( new Service
            {
                EmployeeName = "Peter",
                DateOfService = new DateTime (2020, 05, 05),
                InvoiceDescription = "Full Service",
                VehicleMilage = 100000,
                InvoiceCost = 100.00,
                VehicleId = v1.VehicleId
            });

            var s2 = svc.GetServiceById(s1.ServiceId);

            //assert
            Assert.NotNull(s2);
            Assert.Equal(s2.VehicleId, v1.VehicleId);
        }

        [Fact]
        public void GetService_WhenNone_ShouldReturnNull()
        {
            //act 
            var s1 = svc.GetServiceById(0);

            //assert
            Assert.Null(s1);
        }

        
        [Fact] 
        public void DeleteService_WhenNoneExistent_ShouldRetunFalse()
        {
            //act
            var service = svc.DeleteService(0);

            //assert
            Assert.False(service);
        }

        [Fact] 
        public void DeleteService_WhenCreated_ShouldReturnTrue()
        {
            //act
            var v1 = svc.AddVehicle(new Vehicle
            {
                Make = "Honda",
                Model = "Civic",
                Registration = "VUI 6465",
                EngineSize = 1800,
                DateOfReg = new DateTime (1998, 08, 17),
                Transmission = "Manual",
                C02 = 300,
                Fuel = "Petrol",
                Body = "Hatchback",
                Doors = 5
            });

            var s1 = svc.AddService(new Service
            {
                EmployeeName = "Peter",
                DateOfService = DateTime.Now,
                InvoiceDescription = "Full Service",
                VehicleMilage = 100000,
                InvoiceCost = 100.00,
                VehicleId = v1.VehicleId
            });

            var deleted = svc.DeleteService(s1.ServiceId);

            //assert
            Assert.True(deleted);
        }

 
    }
}