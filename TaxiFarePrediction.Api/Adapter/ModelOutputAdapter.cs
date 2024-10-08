using static TaxiFarePrediction_Core.TaxiFareModel;

namespace TaxiFarePrediction.Api.Adapter
{
    public static class ModelOutputAdapter
    {
        public static TaxiValue Adapt(ModelInput input, ModelOutput output)
        {
            var fareAmount = Convert.ToDecimal(output.Score.ToString());
            return new TaxiValue
            {
                VendorId = input.Vendor_id,
                RateCode = input.Rate_code,
                PassengerCount = input.Passenger_count,
                TripDistance = input.Trip_distance,
                PaymentType = input.Payment_type,
                FareAmount = Math.Round(fareAmount, 2)
            };
        }
    }
}
