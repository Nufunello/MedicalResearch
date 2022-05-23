using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalResearch.Application.Models.Researches.Dto
{
    public class ResearchDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int DeadlineInDays { get; set; }
        public decimal Cost { get; set; }
        public int GroupResearchID { get; set; }
        public int PreparationDescription { get; set; }

        public GroupResearchDTO GroupResearchDto { get; set; }
        //public List<DepartmentResearch> DepartmentResearches { get; set; }
    }
}
