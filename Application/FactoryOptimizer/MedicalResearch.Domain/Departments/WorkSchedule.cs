using System;
using A = MedicalResearch.Domain.Additional;

namespace MedicalResearch.Domain.Departments
{
    public class WorkSchedule
    {
        public int ID { get; set; }
        public int DayOfWeekID { get; set; }
        public int DepartmentID { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

        public A.DayOfWeek DayOfWeek { get; set; }
        public Department Department { get; set; }
    }
}
