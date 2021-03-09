using System.Collections.Generic;
using SpaceTraders.NET.Models;

namespace SpaceTraders.NET.Response
{
    public class ShipsResponse : BaseResponse
    {
        public IEnumerable<Ship> Ships { get; set; }
    }
}