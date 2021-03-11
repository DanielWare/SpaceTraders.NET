namespace SpaceTraders.NET.Request
{
    public class BaseTradeOrderRequest : BaseAuthenticatedRequest
    {
        public string ShipId { get; set; }
        public string Good { get; set; }
        public int Quantity { get; set; }
    }
}