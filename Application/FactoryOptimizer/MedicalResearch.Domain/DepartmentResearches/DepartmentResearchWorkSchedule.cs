using System;
using A = MedicalResearch.Domain.Additional;

namespace MedicalResearch.Domain.DepartmentResearches
{
    public class DepartmentResearchWorkSchedule
    {
        public int ID { get; set; }
        public int DayOfWeekID { get; set; }
        public int DepartmentResearchID { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }

        public A.DayOfWeek DayOfWeek { get; set; }
        public DepartmentResearch DepartmentResearch { get; set; }
    }
}
