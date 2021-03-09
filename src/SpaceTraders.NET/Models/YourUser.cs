using System.Collections.Generic;

namespace SpaceTraders.NET.Models
{
    public class YourUser
    {
        public string Username { get; set; }
        public int Credits { get; set; }
        public IEnumerable<YourShip> Ships { get; set; }
        public IEnumerable<YourLoan> Loans { get; set; }
    }
}