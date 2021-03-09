using System.Collections.Generic;

namespace SpaceTraders.NET.Models
{
    public class System
    {
        public string Symbol { get; set; }
        public string Name { get; set; }
        public IEnumerable<Location> Locations { get; set; }
    }
}