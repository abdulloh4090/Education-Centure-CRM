namespace Education.Centure.CRM.DataAccess.Entities
{
    public class Schedule : BaseEntity
    {

        public int GroupId { get; set; }
        public Group Group { get; set; }

        public DayOfWeek DayOfWeek { get; set; } // Monday, Wednesday...
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

        public string Room { get; set; }
    }
}
