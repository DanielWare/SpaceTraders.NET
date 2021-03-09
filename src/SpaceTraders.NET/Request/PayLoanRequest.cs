namespace SpaceTraders.NET.Request
{
    public class PayLoanRequest : BaseAuthenticatedRequest
    {
        public string LoanId { get; set; }
    }
}