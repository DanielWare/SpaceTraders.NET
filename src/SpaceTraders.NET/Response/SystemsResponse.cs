using System.Collections.Generic;

namespace SpaceTraders.NET.Response
{
    public class SystemsResponse : BaseResponse
    {
        public IEnumerable<SpaceTraders.NET.Models.System> Systems { get; set; }
    }
}