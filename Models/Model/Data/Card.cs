namespace Models.Model.Data
{
    public class Card
    {
        public int Id { get; set; }
        public required string CardNumber { get; set; }
        public decimal Balance { get; set; }
    }
}
