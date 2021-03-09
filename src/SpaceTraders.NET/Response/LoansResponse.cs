using System.Collections.Generic;
using SpaceTraders.NET.Models;

namespace SpaceTraders.NET.Response
{
    public class LoansResponse : BaseResponse
    {
        public IEnumerable<Loan> Loans { get; set; }
    }
}