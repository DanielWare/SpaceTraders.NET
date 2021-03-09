namespace SpaceTraders.NET.Models
{
    public class Loan
    {
        public string Type { get; set; }
        public double Amount { get; set; }
        public bool CollateralRequired { get; set; }
        public double Rate { get; set; }
        public int TermInDays { get; set; }
    }
}