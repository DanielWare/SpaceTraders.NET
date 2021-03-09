using System.Collections.Generic;
using SpaceTraders.NET.Models;

namespace SpaceTraders.NET.Response
{
    public abstract class BaseResponse
    {
        public Error? Error { get; set; }
    }
}

