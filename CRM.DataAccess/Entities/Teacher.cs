
namespace Education.Centure.CRM.DataAccess.Entities
{
    public class Teacher : BaseEntity
    {
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public string Specialty { get; set; }
        public DateTime HiredAt { get; set; }

        public ICollection<Group> Groups { get; set; }
    }
}
