namespace Models.Model.Api.Response
{
    public class CreateCardResponse
    {
        public int Id { get; set; }
        public required string CardNumber { get; set; }
        public decimal Balance { get; set; }
    }
}