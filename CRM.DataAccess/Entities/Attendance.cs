﻿namespace Education.Centure.CRM.DataAccess.Entities
{
    public class Attendance : BaseEntity
    {

        public int StudentId { get; set; }
        public Student Student { get; set; }

        public DateTime Date { get; set; }
        public bool IsPresent { get; set; }
    }
}
