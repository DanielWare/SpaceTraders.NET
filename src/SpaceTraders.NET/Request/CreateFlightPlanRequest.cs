namespace SpaceTraders.NET.Request
{
    public class CreateFlightPlanRequest : BaseAuthenticatedRequest
    {
        public string ShipId { get; set; }
        public string Location { get; set; }
    }
}