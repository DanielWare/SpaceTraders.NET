using System.Collections.Generic;

namespace SpaceTraders.NET.Models
{
    public class Ship
    {
        public string Class { get; set; }
        public int DockingEfficiency { get; set; }
        public int FuelEfficiency { get; set; }
        public int Maintenance { get; set; }
        public string Manufacturer { get; set; }
        public int MaxCargo { get; set; }
        public int Plating { get; set; }
        public IEnumerable<PurchaseLocation> PurchaseLocations { get; set; }
        public int Speed { get; set; }
        public string Type { get; set; }
        public int Weapons { get; set; }
    }
}