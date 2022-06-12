using MedicalResearch.Domain.DepartmentResearches;
using System.Collections.Generic;

namespace MedicalResearch.Application.Models.Departments.Dto
{
    public class DepartmentCreateUpdateDTO
    {
        public int CityID { get; set; }
        public string Street { get; set; }
        public string Building { get; set; }
        public string PhoneNumber { get; set; }

        public List<WorkScheduleDTO> WorkSchedules { get; set; }
        public List<DepartmentResearch> DepartmentResearches { get; set; }
    }
}
