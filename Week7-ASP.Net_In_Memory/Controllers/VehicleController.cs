
using Microsoft.AspNetCore.Mvc;
using VehicleAPI.Models;

namespace VehicleAPI.Controllers;

[ApiController]
[Route("[controller]")] // http://localhost:port/Vehicle

public class VehicleController : ControllerBase
{
    /*
    This controller will receive HTTP requests to the path/Vehicle
    Based on the HTTP Mehod it receives, it will direct the request to different "Actions"
    */

    //making some data - created our database
    public static List<Vehicle> Vehicles = new List<Vehicle>
    {
        new Vehicle(1, "Toyota", "Camry", 2010, false),
        new Vehicle(2, "Chevy", "Silverado", 2020, false),
        new Vehicle(3, "Ford", "F150", 2016, true),
        new Vehicle(4, "Dodge", "Ram", 2019, false),
        new Vehicle(5, "Subaru", "Outback", 2023, false),
        new Vehicle(6, "Honda", "CRV", 2018, false),
    };

    //This is the beginning part of a get action sto the path/vehicle 
    //You need to let the controller know that this method should called when a Get Request 
    
    //Get all Vehicles
    [HttpGet]
    public IActionResult GetVehicles()
    {
        return Ok(Vehicles);
    }

    // Get a vehicle by ID 
    //This is expecting the client to send Get request to /Vehicle and also provide a /Id
    //this id needs to be an interger
    
    // Examples: 
    // http://localhost:port/Vehicle/1
    // http://localhost:port/Vehicle/3922   
    // http://localhost:port/Vehicle/1324

    [HttpGet("{Id}")] //here id is a placeholder you have to place that number when doing thunderclient
    public IActionResult GetVehicleByID(int Id)
    {   
        //This is an example of functional programming 
        //we have an array and we want to filter thorugh that array and grad the first thing that matches that correct id 
        // we have created a LINQ onto the vehicles array that will filter through each of the vehicles and chek to see if the VehicleId matches the ID that was passed in 
        //if it matches , then it will return the vehicle
        Vehicle vehicle = Vehicles.Find(v => v.VehicleId == Id);
        /*foreach(Vehicle vehicle in Vehicles)
        {
            if(vehicle.VehicleId == Id)
            {
                return Ok(vehicle);
            }
        }
                return NotFound();       
        */
        //System.Console.WriteLine(Id);
        return Ok(vehicle);
    }
    
    // Post a new Vehicle
    /*
        We send this data in teh Http request body as a JSON object 
        this Json has to match the 



    */
    [HttpPost]
    public IActionResult PostVehicle(Vehicle vehicle) //we send this through ThunderCLient in the body 
    {
        vehicle.VehicleId = Vehicles.Count +1;
        Vehicles.Add(vehicle);
        System.Console.WriteLine(vehicle.VehicleMake);
        return Ok();
    }

    // Put a new update on an existing vehicle
    [HttpPut("{Id}")]
    public IActionResult PutVehicle(int Id, Vehicle updatedVehicle)
    {
        //System.Console.WriteLine(Id);
        //System.Console.WriteLine(updatedVehicle);
        int index = Vehicles.FindIndex(v => v.VehicleId == Id);
        Vehicles[index] = updatedVehicle;

        return Ok(); 
    }

    // Delete an existing vehicle
    [HttpDelete("{Id}")]
    public IActionResult DeleteVehicle(int Id)
    {
        foreach(Vehicle vehicle in Vehicles)
        {
            if(vehicle.VehicleId == 0)
            {
                Vehicles.Remove(vehicle);
                return Ok();
            }
        }
        return NotFound();
    }
}