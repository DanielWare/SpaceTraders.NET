using SpaceTraders.NET.Models;

namespace SpaceTraders.NET.Response
{
    public class CreateFlightPlanResponse : BaseResponse
    {
        public FlightPlan FlightPlan { get; set; }
    }
}