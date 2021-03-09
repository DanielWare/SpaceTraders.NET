using SpaceTraders.NET.Models;

namespace SpaceTraders.NET.Request
{
    public class TakeLoanRequest : BaseAuthenticatedRequest
    {
        public string Type { get; set; } = "STARTUP";
    }
}