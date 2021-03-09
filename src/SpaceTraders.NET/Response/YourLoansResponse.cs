using System.Collections.Generic;
using SpaceTraders.NET.Models;

namespace SpaceTraders.NET.Response
{
    public class YourLoansResponse : BaseResponse
    {
        public IEnumerable<YourLoan> Loans { get; set; }
    }
}