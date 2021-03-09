namespace SpaceTraders.NET.Request
{
    public class MarketplaceRequest : BaseAuthenticatedRequest
    {
        public string LocationSymbol { get; set; }
    }
}