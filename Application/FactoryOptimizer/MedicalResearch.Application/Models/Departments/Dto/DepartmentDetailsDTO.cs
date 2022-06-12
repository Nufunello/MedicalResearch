using MedicalResearch.Application.Models.Cities;
using MedicalResearch.Application.Models.DepartmentResearches.Dto;
using System.Collections.Generic;

namespace MedicalResearch.Application.Models.Departments.Dto
{
    public class DepartmentDetailsDTO
    {
        public int ID { get; set; }
        public int CityID { get; set; }
        public string Street { get; set; }
        public string Building { get; set; }
        public string PhoneNumber { get; set; }

        public CityDto City { get; set; }
        public List<WorkScheduleDTO> WorkSchedules { get; set; }
        public List<DepartmentResearchesListItemDto> DepartmentResearches { get; set; }
    }
}
