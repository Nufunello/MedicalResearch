using MedicalResearch.Domain.Additional;
using MedicalResearch.Domain.DepartmentResearches;
using MedicalResearch.Domain.Departments;
using System;
using System.Collections.Generic;
using System.Text;

namespace MedicalResearch.Application.Models.Departments.Dto
{
    public class DepartmentDTO
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
