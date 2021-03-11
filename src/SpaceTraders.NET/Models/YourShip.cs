using System.Collections.Generic;

namespace SpaceTraders.NET.Models
{
    public class YourShip
    {
        public string Class { get; set; }
        public IEnumerable<ShipCargo> Cargo { get; set; }
        public string Id { get; set; }
        public string? Location { get; set; }
        public string? FlightPlanId { get; set; }
        public string Manufacturer { get; set; }
        public int MaxCargo { get; set; }
        public int Plating { get; set; }
        public int SpaceAvailable { get; set; }
        public int Speed { get; set; }
        public string Type { get; set; }
        public int Weapons { get; set; }
    }
}