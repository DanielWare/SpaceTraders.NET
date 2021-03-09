namespace SpaceTraders.NET.Request
{
    public class LocationsRequest : BaseAuthenticatedRequest
    {
        public string SystemSymbol { get; set; }
    }
}