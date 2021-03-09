using System.Collections.Generic;
using SpaceTraders.NET.Models;

namespace SpaceTraders.NET.Response
{
    public class YourShipsResponse : BaseResponse
    {
        public IEnumerable<YourShip> Ships { get; set; }
    }
}