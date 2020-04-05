namespace Mikan.DAL.Models
{
    public class Amortization
    {
        public int Id { get; set; }

        public int Year { get; set; }

        public int InitialValue { get; set; }

        public decimal AmortizationPercentage { get; set; }

        public decimal Value { get; set; }

        public Machine Machine { get; set; }
    }
}
