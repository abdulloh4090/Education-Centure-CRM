namespace Education.Centure.CRM.DataAccess.Entities
{
    public class Student : BaseEntity
    {
        public string FullName { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Gender { get; set; }
        public DateTime RegisterAt { get; set; }
        public bool IsActive { get; set; }

        public int GroupId { get; set; }
        public Group Group { get; set; }

        public ICollection<Payment> Payments { get; set; }
        public ICollection<Attendance> Attandances { get; set; }
    }
}
