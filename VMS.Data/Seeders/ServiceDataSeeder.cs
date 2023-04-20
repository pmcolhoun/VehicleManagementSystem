using System;
using System.Collections.Generic;
using VMS.Data.Models;
using VMS.Data.Repositories;
using VMS.Data.Services;


namespace VMS.Data.Seeders
{
    public static class ServiceDataSeeder
    {
   
        public static void Seed(IVehicleService svc)
        {    
            // use the service to seed the database with sample data 
            // when running the web project        
            svc.Initialise();

            // Create some vehicles 
             var v1 = svc.AddVehicle( new Vehicle
            {
                Make = "Honda",
                Model = "Civic",
                Registration = "VUI 6465",
                EngineSize = 1800,
                DateOfReg = new DateTime (2016, 8, 17),
                Transmission = "Manual",
                C02 = 300,
                Fuel = "Petrol",
                Body = "Hatchback",
                Doors = 5,
                Photo = "https://cdn.motor1.com/images/mgl/2K7kx/s1/2017-honda-civic-si-prototype.jpg"

            });

             var v2 = svc.AddVehicle( new Vehicle
            {
                Make = "Audi",
                Model = "A4",
                Registration = "PKZ 9889",
                EngineSize = 1900,
                DateOfReg = new DateTime (2015, 1, 1),
                Transmission = "Automatic",
                C02 = 350,
                Fuel = "Diesel",
                Body = "Saloon",
                Doors = 5,
                Photo ="https://cdn.motor1.com/images/mgl/2yp2k/s2/2017-audi-a4.jpg"
            });

             var v3 = svc.AddVehicle( new Vehicle
            {
                Make = "Ford",
                Model = "Focus",
                Registration = "WIW 9909",
                EngineSize = 1400,
                DateOfReg = new DateTime (2019, 1, 1),
                Transmission = "Manual",
                C02 = 300,
                Fuel = "Petrol",
                Body = "Hatchback",
                Doors = 5,
                Photo = "https://cdn.motor1.com/images/mgl/r18AY/s2/ford-focus.jpg"
            });

             var v4 = svc.AddVehicle( new Vehicle
            {
                Make = "Renault",
                Model = "Megane",
                Registration = "VKZ 2090",
                EngineSize = 1600,
                DateOfReg = new DateTime (2013, 1, 1),
                Transmission = "Manual",
                C02 = 200,
                Fuel = "Petrol",
                Body = "Hatchback",
                Doors = 5,
                Photo = "https://cdn.motor1.com/images/mgl/ZPyke/s2/2017-renault-megane.jpg"
            });

            // Add services  
            var s1 = svc.AddService( new Service
            {
                EmployeeName = "Peter",
                DateOfService = new DateTime(2020, 1, 2),
                InvoiceDescription = "Full Service",
                VehicleMilage = 100000,
                InvoiceCost = 100.00,
                VehicleId = v1.VehicleId
            });

            var s2 = svc.AddService( new Service
            {
                EmployeeName = "Ryan",
                DateOfService = new DateTime(2020, 5, 2),
                InvoiceDescription = "Brake Pads",
                VehicleMilage = 130000,
                InvoiceCost = 55.00,
                VehicleId = v1.VehicleId
            });

            var s3 = svc.AddService( new Service
            {
                EmployeeName = "Cillian",
                DateOfService = new DateTime(2020, 6, 7),
                InvoiceDescription = "Wheel Bearing",
                VehicleMilage = 175000,
                InvoiceCost = 120.00,
                VehicleId = v1.VehicleId
            });

            var s4 = svc.AddService( new Service
            {
                EmployeeName = "Ryan",
                DateOfService = new DateTime(2020, 7, 7),
                InvoiceDescription = "Full Service",
                VehicleMilage = 175000,
                InvoiceCost = 100.00,
                VehicleId = v2.VehicleId
            });

            var s5 = svc.AddService( new Service
            {
                EmployeeName = "Peter",
                DateOfService = new DateTime(2020, 8, 7),
                InvoiceDescription = "Brake Pads",
                VehicleMilage = 175000,
                InvoiceCost = 55.00,
                VehicleId = v2.VehicleId
            });

             var s6 = svc.AddService( new Service
            {
                EmployeeName = "Cillian",
                DateOfService = new DateTime(2020, 8, 7),
                InvoiceDescription = "Brake Pads",
                VehicleMilage = 175000,
                InvoiceCost = 55.00,
                VehicleId = v3.VehicleId
            });

             var s7 = svc.AddService( new Service
            {
                EmployeeName = "Ryan",
                DateOfService = new DateTime(2020, 8, 7),
                InvoiceDescription = "Brake Pads",
                VehicleMilage = 175000,
                InvoiceCost = 55.00,
                VehicleId = v4.VehicleId
            });

        }
    }
}  