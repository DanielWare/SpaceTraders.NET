using System.Collections.Generic;
using SpaceTraders.NET.Models;

namespace SpaceTraders.NET.Response
{
    public class LocationsResponse : BaseResponse
    {
        public IEnumerable<Location> Locations { get; set; }
    }
}