using System;

namespace MedicalResearch.Application.Models.DepartmentResearches.Dto
{
    public class DepartmentResearchWorkScheduleDTO
    {
        public int Id { get; set; }
        public int DayOfWeekId { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
    }
}