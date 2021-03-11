using System.Collections.Generic;

namespace SpaceTraders.NET.Models
{
    public class Error
    {
        public int? Code { get; set; }
        public ErrorMessage? Message { get; set; }
    }

    public class ErrorMessage
    {
        public object? Errors { get; set; }
    }
}