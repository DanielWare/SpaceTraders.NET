namespace SpaceTraders.NET.Request
{
    public class YourFlightPlanRequest : BaseAuthenticatedRequest
    {
        public string FlightPlanId { get; set; }
    }
}