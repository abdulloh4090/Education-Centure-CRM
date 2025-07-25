namespace Education.Centure.CRM.DataAccess.Entities
{
    public class Report : BaseEntity
    {
        public DateTime GeneratedAt { get; set; }

        public string Title { get; set; }
        public string JsonData { get; set; } // Yoki boshqa format
    }
}
