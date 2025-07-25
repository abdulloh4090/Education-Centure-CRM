namespace Education.Centure.CRM.DataAccess.Entities
{
    public class Course : BaseEntity
    {
        public string Title { get; set; } // "Frontend Development", "IELTS"
        public string Description { get; set; }
        public decimal MonthlyFee { get; set; }
        public int DurationInMonths { get; set; }

        public ICollection<Group> Groups { get; set; }
    }
}
