namespace GymManager.Core.Models
{
    public class Transaction
    {
        public Guid Id { get; set; }
        public DateTime Timestamp { get; set; }
        public decimal Amount { get; set; }
        public string Method { get; set; }
        public Member Member { get; set; }
    }
}