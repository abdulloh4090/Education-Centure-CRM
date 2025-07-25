using Education.Centure.CRM.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace Education.Centure.CRM.DataAccess.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<Attendance> Attendances { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Report> Reports { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<Teacher> Teachers { get; set; }
        public DbSet<StudentGroup> StudentGroups { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Course -> Groups
            modelBuilder.Entity<Course>()
                .HasMany(g => g.Groups)
                .WithOne(c => c.Course)
                .HasForeignKey(c => c.CourseId)
                .OnDelete(DeleteBehavior.Restrict);

            // StudentGroup: Composite Key
            modelBuilder.Entity<StudentGroup>()
                .HasKey(sg => new { sg.StudentId, sg.GroupId });

            modelBuilder.Entity<StudentGroup>()
                .HasOne(sg => sg.Student)
                .WithMany(s => s.StudentGroups)
                .HasForeignKey(sg => sg.StudentId)
                .OnDelete(DeleteBehavior.Restrict); // 💡 muammoni hal qilish uchun

            modelBuilder.Entity<StudentGroup>()
                .HasOne(sg => sg.Group)
                .WithMany(g => g.StudentGroups)
                .HasForeignKey(sg => sg.GroupId)
                .OnDelete(DeleteBehavior.Restrict); // 💡 bu ham muammoni hal qiladi

            // Group -> Schedule
            modelBuilder.Entity<Group>()
                .HasMany(s => s.Schedules)
                .WithOne(g => g.Group)
                .HasForeignKey(s => s.GroupId)
                .OnDelete(DeleteBehavior.Restrict);

            // Teacher -> Groups
            modelBuilder.Entity<Teacher>()
                .HasMany(t => t.Groups)
                .WithOne(g => g.Teacher)
                .HasForeignKey(g => g.TeacherId)
                .OnDelete(DeleteBehavior.Restrict);

            // Student -> Payments
            modelBuilder.Entity<Student>()
                .HasMany(s => s.Payments)
                .WithOne(p => p.Student)
                .HasForeignKey(p => p.StudentId)
                .OnDelete(DeleteBehavior.Restrict);

            // Student -> Attendances
            modelBuilder.Entity<Student>()
                .HasMany(s => s.Attandances)
                .WithOne(a => a.Student)
                .HasForeignKey(a => a.StudentId)
                .OnDelete(DeleteBehavior.Restrict);

            base.OnModelCreating(modelBuilder);
        }

    }
}
