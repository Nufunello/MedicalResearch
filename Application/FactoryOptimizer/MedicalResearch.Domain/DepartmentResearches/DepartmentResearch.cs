using MedicalResearch.Domain.Departments;
using MedicalResearch.Domain.Researches;
using System.Collections.Generic;

namespace MedicalResearch.Domain.DepartmentResearches
{
    public class DepartmentResearch
    {
        public int ID { get; set; }
        public int DepartmentID { get; set; }
        public int ResearchID { get; set; }
        public int Cabinet { get; set; }

        public Department Department { get; set; }
        public Research Research { get; set; } 
        public List<DepartmentResearchWorkSchedule> DepartmentResearchWorkSchedules { get; set; }
    }
}
