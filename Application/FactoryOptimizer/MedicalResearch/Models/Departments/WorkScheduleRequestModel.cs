using MedicalResearch.Application.Models.Departments.Dto;
using System;
using System.ComponentModel.DataAnnotations;

namespace MedicalResearch.Models.Departments
{
    public class WorkScheduleRequestModel
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public DayOfWeekEnum DayOfWeek { get; set; }
        [Required]
        public string StartTime { get; set; }
        [Required]
        public string EndTime { get; set; }
    }
    public static partial class ViewModelMapperExtensions
    {
        public static WorkScheduleDTO AsDto(this WorkScheduleRequestModel requestModel)
        {
            return new WorkScheduleDTO
            {
                Id = requestModel.Id,
                DayOfWeekId = (int)requestModel.DayOfWeek,
                StartTime = TimeSpan.Parse(requestModel.StartTime),
                EndTime = TimeSpan.Parse(requestModel.EndTime)
            };
        }
    }
}
