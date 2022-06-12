using MedicalResearch.Application.Models.DepartmentResearches.Dto;
using MedicalResearch.Models.Researches;
using System.Collections.Generic;
using System.Linq;

namespace MedicalResearch.Models.DepartmentResearches
{
    public class DepartmentResearchListItemViewModel
    {
        public int ID { get; set; }
        public int ResearchID { get; set; }
        public int Cabinet { get; set; }
        public Research Research { get; set; }
        public List<DepartmentResearchWorkScheduleViewModel> WorkSchedules { get; set; }
    }

    public static partial class ViewModelMapperExtensions
    {
        public static DepartmentResearchListItemViewModel AsViewModel(this DepartmentResearchesListItemDto dto)
        {
            return new DepartmentResearchListItemViewModel
            {
                ID = dto.ID,
                ResearchID = dto.ResearchID,
                Cabinet = dto.Cabinet,
                Research = dto.Research.AsViewModel(),
                WorkSchedules = dto.WorkSchedule.Select(x => x.AsViewModel()).ToList()
            };
        }
    }
}
