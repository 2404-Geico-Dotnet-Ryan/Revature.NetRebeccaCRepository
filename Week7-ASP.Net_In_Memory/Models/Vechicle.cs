namespace VehicleAPI.Models;

public class Vehicle
{
    public int VehicleId {get; set;}
    public string VehicleMake {get; set;}
    public string VehicleModel {get; set;}
    public int VehicleYear {get; set;}
    public bool NeedsMaintenance {get; set;}

    public Vehicle(int VehicleId, 
                string VehicleMake, 
                string VehicleModel, 
                int VehicleYear, 
                bool NeedsMaintenance)
        {
        
            this.VehicleId = VehicleId;
            this.VehicleMake = VehicleMake;
            this.VehicleModel = VehicleModel;
            this.VehicleYear = VehicleYear;
            this.NeedsMaintenance = NeedsMaintenance;
        }

}