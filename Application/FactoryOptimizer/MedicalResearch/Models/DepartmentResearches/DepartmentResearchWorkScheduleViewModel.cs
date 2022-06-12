using MedicalResearch.Application.Models.DepartmentResearches.Dto;

namespace MedicalResearch.Models.DepartmentResearches
{
    public class DepartmentResearchWorkScheduleViewModel
    {
        public int Id { get; set; }
        public DayOfWeekEnum DayOfWeek{ get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
    }

    public static partial class ViewModelMapperExtensions
    {
        public static DepartmentResearchWorkScheduleViewModel AsViewModel(this DepartmentResearchWorkScheduleDTO dto)
        {
            return new DepartmentResearchWorkScheduleViewModel
            {
                Id = dto.Id,
                DayOfWeek = (DayOfWeekEnum)dto.DayOfWeekId,
                StartTime = dto.StartTime.ToString(),
                EndTime = dto.EndTime.ToString()
            };
        }
    }
}
