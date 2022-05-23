using MedicalResearch.Domain.Additional;
using MedicalResearch.Domain.DepartmentResearches;
using System.Collections.Generic;

namespace MedicalResearch.Domain.Departments
{
    public class Department
    {
        public int ID { get; set; }
        public int CityID { get; set; }
        public string Street { get; set; }
        public string Building { get; set; }
        public string PhoneNumber { get; set; }

        public City City { get; set; }
        public List<WorkSchedule> WorkSchedules { get; set; }
        public List<DepartmentResearch> DepartmentResearches { get; set; }
    }
}
