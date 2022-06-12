using MedicalResearch.Application.Models.Researches.Dto;
using System.Collections.Generic;

namespace MedicalResearch.Application.Models.DepartmentResearches.Dto
{
    public class DepartmentResearchesListItemDto
    {
        public int ID { get; set; }
        public int ResearchID { get; set; }
        public int Cabinet { get; set; }
        public ResearchDto Research { get; set; }
        public List<DepartmentResearchWorkScheduleDTO> WorkSchedule { get; set; }
    }
}
