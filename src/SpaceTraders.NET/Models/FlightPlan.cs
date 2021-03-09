using System;

namespace SpaceTraders.NET.Models
{
    public class FlightPlan
    {
        public string Id { get; set; }
        public string Ship { get; set; }
        public int FuelConsumed { get; set; }
        public int FuelRemaining { get; set; }
        public int TimeRemainingInSeconds { get; set; }
        public DateTime ArrivesAt { get; set; }
        public DateTime? TerminatedAt { get; set; }
        public string Destination { get; set; }
        public string Departure { get; set; }
        public int Distance { get; set; }
    }
}