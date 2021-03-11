namespace SpaceTraders.NET.Request
{
    public class CreateFlightPlanRequest : BaseAuthenticatedRequest
    {
        public string ShipId { get; set; }
        public string Destination { get; set; }
    }
}