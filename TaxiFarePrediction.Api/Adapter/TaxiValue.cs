namespace TaxiFarePrediction.Api.Adapter
{
    public class TaxiValue
    {
        public string VendorId { get; set; }
        public float RateCode { get; set; }
        public float PassengerCount { get; set; }
        public float TripDistance { get; set; }
        public string PaymentType { get; set; }
        public decimal FareAmount { get; set; }
    }
}
