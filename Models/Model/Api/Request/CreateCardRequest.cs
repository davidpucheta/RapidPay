namespace Models.Model.Api.Request
{
    public class CreateCardRequest
    {
        public required string CardNumber { get; set; }
        public decimal Balance { get; set; }
    }
}
