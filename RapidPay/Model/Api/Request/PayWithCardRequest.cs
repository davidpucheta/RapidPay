namespace RapidPay.Model.Api.Request
{
    public class PayWithCardRequest
    {
        public required string CardNumber { get; set; }
        public decimal Amount { get; set; }
    }
}
