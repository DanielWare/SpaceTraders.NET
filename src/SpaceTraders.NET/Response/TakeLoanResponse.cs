using SpaceTraders.NET.Models;

namespace SpaceTraders.NET.Response
{
    public class TakeLoanResponse : BaseResponse
    {
        public YourLoan Loan { get; set; }
    }
}