using System.Text.Json.Serialization;

namespace SpaceTraders.NET.Models
{
    public class ShipCargo
    {
        public string Good { get; set; }
        public int Quantity { get; set; }
    }
}