using MedicalResearch.Domain.DepartmentResearches;
using System.Collections.Generic;

namespace MedicalResearch.Domain.Researches
{
    public class Research
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int DeadlineInDays { get; set; }
        public decimal Cost { get; set; }
        public int GroupResearchID { get; set; }
        public int PreparationID { get; set; }

        public GroupResearch GroupResearch { get; set; }
        public Preparation Preparation { get; set; }
        public List<DepartmentResearch> DepartmentResearches { get; set; }
    }
}
