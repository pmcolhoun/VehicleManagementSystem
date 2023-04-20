using System;
using System.ComponentModel.DataAnnotations;

namespace VMS.Data.Models
{
    //Class representing table in database
    public class Service
    {     

        //Class properties of Service
        public int ServiceId {get; set;} //Primary key
        
        [Required]
        public String EmployeeName {get; set;}

        public DateTime DateOfService {get; set;}

        [Required]        
        public String InvoiceDescription {get; set;}

        [Required]
        public int VehicleMilage {get; set;}

        [Required]
        public double InvoiceCost {get; set;}

        public int VehicleId {get; set;} //Foreign key


        //Navigation property to navigate to the vehicle
        public Vehicle Vehicle {get; set;}



    }
}