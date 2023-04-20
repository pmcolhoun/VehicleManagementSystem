using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System;

namespace VMS.Data.Models
{      
    //Class representing table in database
    public class Vehicle
    {

        public Vehicle()
        {
            //Initialise the Service relationship
            Services = new List<Service>();
        }

        
        //Class properties of Vehicle
        public int VehicleId {get; set;} //Primary key

        [Required]
        public string Make {get; set;}

        [Required]
        public string Model {get; set;}

        [Required]
        public string Registration {get; set;}

        [Required]
        public int EngineSize {get; set;}        

        [Required]
        public DateTime DateOfReg {get; set;}

        [Required]
        public int Age => (DateTime.Now - DateOfReg).Days / 365;

        [Required]
        public string Transmission {get; set;}

        [Required]
        public int C02 {get; set;}

        [Required]
        public string Fuel {get; set;}

        [Required]
        public string Body {get; set;}

        [Required]
        public int Doors {get; set;}

        [Required]
        public string Photo {get; set;}
        
        //Navigation Properties
    public ICollection<Service> Services {get; set;}

    }
}