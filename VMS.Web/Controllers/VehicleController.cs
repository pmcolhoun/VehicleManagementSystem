using System;
using VMS.Data.Models;
using VMS.Data.Services;
using Microsoft.AspNetCore.Mvc;
using VMS.Web.ViewModels;

namespace VMS.Web.Controllers
{

    public class VehicleController : BaseController
    {

        private readonly VehicleDbService svc;

        public VehicleController()
        {
            svc = new VehicleDbService();
        }


        //          --- Vehicle Controllers ---          \\          

        //Get /vehicle/index
        public IActionResult Index()
        {
            var vehicles = svc.GetAllVehicles();
            return View(vehicles);
        }

        //Get /vehicle/details/(id)
        public IActionResult Details(int id)
        {
            var vehicle = svc.GetVehicleById(id);

            if(vehicle == null)
            {
                Alert("Vehicle not found", AlertType.warning);
                return RedirectToAction(nameof(Index));
            }

            return View(vehicle);
        }

        //Get /vehicle/create
        public IActionResult Create()
        {
            //render blank form
            return View();
        }

        [HttpPost]
        public IActionResult Create(Vehicle v)
        {
            //verify that the model is valid - passes validation rules defined by Vehicle
            if(ModelState.IsValid)
            {
                //add vehicle to database
                svc.AddVehicle(v);
                Alert("Vehicle successfully created", AlertType.info);
                //redirect to the Index Action
                return RedirectToAction(nameof(Index));
            }
            //redisplay the form for editting as there are validation errors
            return View(v);
        }

        //Get vehicle/edit/id
        public IActionResult Edit(int id)
        {
            //load vehicle using the service
            var v = svc.GetVehicleById(id);

            //check if vehicle returned is not null if so return not found
            if(v == null)
            {
                Alert("Vehicle not found", AlertType.warning);
                return RedirectToAction(nameof(Index));
            }

            //pass vehicle to view for editing
            return View(v);
        }

        //Get vehicle/edit/id
        [HttpPost]
        public IActionResult Edit(Vehicle v, int id)
        {
            //check if model state is valid
            if(ModelState.IsValid)
            {
                //call service to update the vehicle and redirect to index
                svc.UpdateVehicle(id, v);
                Alert("Vehicle Updated", AlertType.info);
                return RedirectToAction(nameof(Index));
            }
            //redisplay the form for editing
            return View(v);
        }

        
        public IActionResult Delete (int id)
        {
            //load vehicle via service
            var vehicle = svc.GetVehicleById(id);
            if(vehicle == null)
            {
                return NotFound();
            }

            //pass vehicle to view for delete confirmation
            return View(vehicle);
        }

        [HttpPost]
        public IActionResult DeleteConfirm(int id)
        {
            //delete vehicle via service 
            svc.DeleteVehicle(id);
            Alert("Vehicle Deleted", AlertType.danger);
            //redirect to the index view 
            return RedirectToAction(nameof(Index));
        }


        //         --- Service Controllers ---          \\

        //Get vehicle/createservice/id
        public IActionResult CreateService(int id)
        {
            var v = svc.GetVehicleById(id);
            
            if(v == null)
            {
                return NotFound();
            }

            //create new Service
            var s = new Service {VehicleId = id};

            //render blank form
            return View(s);
        }


        //Get vehicle/create
        [HttpPost]
        public IActionResult CreateService(Service s)
        {
            if(ModelState.IsValid)
            {
                s.DateOfService = DateTime.Now;
                svc.AddService(s);
                Alert("Service Added", AlertType.info);
                return RedirectToAction(nameof(Index));
            }

            return View(s);
        }
        public IActionResult GetServiceById(int id)
        {
            var service = svc.GetServiceById(id);

            return View(service);
        }

        public IActionResult DeleteService (int id)
        {
            //load service via service
            var service = svc.GetServiceById(id);
            if(service == null)
            {
                return NotFound();
            }

            //pass service to view for delete confirmation
            return View(service);
        }

        [HttpPost]
        public IActionResult DeleteServiceConfirm(int id)
        {
            //delete service via service 
            svc.DeleteService(id);
            Alert("Service Deleted", AlertType.danger);
            //redirect to the index view 
            return RedirectToAction(nameof(Index));
        }

    }
}