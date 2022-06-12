using MedicalResearch.Application.Models.Departments.Dto;
using System;

namespace MedicalResearch.Models.Departments
{
    public class WorkScheduleViewModel
    {
        public int Id { get; set; }
        public DayOfWeekEnum DayOfWeek { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
    }

    public static partial class ViewModelMapperExtensions
    {
        public static WorkScheduleViewModel AsViewModel(this WorkScheduleDTO dto)
        {
            return new WorkScheduleViewModel
            {
                Id = dto.Id,
                DayOfWeek = (DayOfWeekEnum)dto.DayOfWeekId,
                StartTime = dto.StartTime.ToString(),
                EndTime = dto.EndTime.ToString()
            };
        }
    }
}
