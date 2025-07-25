namespace Education.Centure.CRM.DataAccess.Entities
{
    public class Payment : BaseEntity
    {
        public int StudentId { get; set; }
        public Student Student { get; set; }

        public DateTime PaymentDate { get; set; }
        public decimal Amount { get; set; }

        public string Method { get; set; } // "Cash", "Click", "Payme"
        public string? Note { get; set; }
    }
}
