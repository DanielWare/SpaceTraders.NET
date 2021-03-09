using System.Collections.Generic;

namespace SpaceTraders.NET.Models
{
    public class Planet
    {
        public string Symbol { get; set; }
        public string Type { get; set; }
        public string Name { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public IEnumerable<Marketplace> Marketplace { get; set; }
    }
}