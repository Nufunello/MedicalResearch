using System;

namespace MedicalResearch.Application.Models.Departments.Dto
{
    public class WorkScheduleDTO
    {
        public int Id { get; set; }
        public int DayOfWeekId { get; set; }
        public TimeSpan StartTime { get; set; }
        public TimeSpan EndTime { get; set; }
    }
}
