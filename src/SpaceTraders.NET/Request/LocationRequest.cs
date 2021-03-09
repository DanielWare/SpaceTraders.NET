namespace SpaceTraders.NET.Request
{
    public class LocationRequest : BaseAuthenticatedRequest
    {
        public string LocationSymbol { get; set; }
    }
}