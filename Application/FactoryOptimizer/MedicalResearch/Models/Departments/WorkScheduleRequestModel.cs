using MedicalResearch.Application.Models.Departments.Dto;
using System;

namespace MedicalResearch.Models.Departments
{
    public class WorkScheduleRequestModel
    {
        public int Id { get; set; }
        public DayOfWeekEnum DayOfWeek { get; set; }
        public string StartTime { get; set; }
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
