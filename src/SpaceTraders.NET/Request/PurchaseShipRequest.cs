namespace SpaceTraders.NET.Request
{
    public class PurchaseShipRequest : BaseAuthenticatedRequest
    {
        public string Type { get; set; }
        public string Location { get; set; }
    }
}