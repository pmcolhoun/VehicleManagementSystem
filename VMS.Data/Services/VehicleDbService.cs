using System.Linq;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using VMS.Data.Models;
using VMS.Data.Repositories;
using System;

namespace VMS.Data.Services
{
    public class VehicleDbService : IVehicleService
    {

        private readonly VehicleDbContext db;

        public VehicleDbService()
        {
            db = new VehicleDbContext();
        }

        

        //Initialises databases
        public void Initialise()
        {
            db.Initialise();
        }



        //             ----- Vehicle Related Operations -----             \\

        //Return a list of all vehicles 
        public IList<Vehicle> GetAllVehicles(string orderBy = null)
        {
            return db.Vehicles
                   .Include(v => v.Services).ToList();
        }

          //Return Vehicle identified by id
        public Vehicle GetVehicleById(int id)
        {
            return db.Vehicles
                   .Include(v => v.Services)
                   .FirstOrDefault(v => v.VehicleId == id);
        }

         //Delete vehicle from the Vehicles database identified by the VehicleId - return true if found, false if not found
        public bool DeleteVehicle(int id)
        {
            var v = GetVehicleById(id);
            if(v == null)
            {
                return false;
            }
            
            db.Vehicles.Remove(v);
            db.SaveChanges();
            return true;
        }

        //Updates any changes to existing vehicles - if vehicle does not exist return null
        public Vehicle UpdateVehicle(int id, Vehicle v)
        {
            //verify if vehicle exists
            var vehicle = GetVehicleById(id);
            if(vehicle == null)
            {
                return null;
            }

            //Update details of the vehicle and save the changes
            vehicle.Make = v.Make;
            vehicle.Model = v.Model;
            vehicle.Registration = v.Registration;
            vehicle.EngineSize = v.EngineSize;
            vehicle.DateOfReg = v.DateOfReg;
            vehicle.Transmission = v.Transmission;
            vehicle.C02 = v.C02;
            vehicle.Fuel = v.Fuel;
            vehicle.Body = v.Body;
            vehicle.Doors = v.Doors;
            vehicle.Photo = v.Photo;

            db.SaveChanges(); 
            return vehicle; //return updated vehicle
        }

        //Add new vehicle to the database - if exists return null
        public Vehicle AddVehicle(Vehicle v)
        {
            //verify that the vehicle with the same id does not exist
            var exists = db.Vehicles.FirstOrDefault(e => e.VehicleId == v.VehicleId);
            if(exists != null)
            {
                return null;
            }

            var vehicle = new Vehicle
            {
                Make = v.Make,
                Model = v.Model,
                Registration = v.Registration,
                EngineSize = v.EngineSize,
                DateOfReg = v.DateOfReg,
                Transmission = v.Transmission,
                C02 = v.C02,
                Fuel = v.Fuel,
                Body = v.Body,
                Doors = v.Doors,
                Photo = v.Photo
            };

            db.Vehicles.Add(vehicle);
            db.SaveChanges();
            return(vehicle); //returns newly added vehicle
        }

        //Return Service identified by id
        public Service GetServiceById(int id)
        {
            var service = db.Services
                   .Include(s => s.Vehicle)
                   .FirstOrDefault(s => s.ServiceId == id);

            if(service == null)
            {
                return null;
            }       
            return service;
        }

        //Add new service to database - if exists return null
        public Service AddService(Service s)
        {   
            db.Services.Add(s);
            db.SaveChanges();
            return s; //returns newly added service;
        }

        

        //Delete the Service from the database identified by the ServiceId - return true if found, false if not found
        public bool DeleteService(int id)
        {
            var s = GetServiceById(id);
            if(s == null)
            {
                return false;
            }

            db.Services.Remove(s);
            db.SaveChanges();
            return true;
        }

    

        
    }
}