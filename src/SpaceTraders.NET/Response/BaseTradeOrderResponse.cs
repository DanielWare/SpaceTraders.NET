using System.Collections.Generic;
using SpaceTraders.NET.Models;

namespace SpaceTraders.NET.Response
{
    public class BaseTradeOrderResponse : BaseResponse
    {
        public int Credits { get; set; }
        public IEnumerable<Order> Order { get; set; }
        public YourShip Ship { get; set; }
    }
}