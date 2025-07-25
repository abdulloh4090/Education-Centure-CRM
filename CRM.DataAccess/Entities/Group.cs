using System.ComponentModel.DataAnnotations.Schema;

namespace Education.Centure.CRM.DataAccess.Entities
{
    public class Group : BaseEntity
    {
        public string Name { get; set; } // Masalan: "Frontend-1"
        public int CourseId { get; set; }
        public Course Course { get; set; }

        public int TeacherId { get; set; }
        public Teacher Teacher { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }

        public ICollection<Schedule> Schedules { get; set; }
        public ICollection<StudentGroup> StudentGroups { get; set; }
    }
}
