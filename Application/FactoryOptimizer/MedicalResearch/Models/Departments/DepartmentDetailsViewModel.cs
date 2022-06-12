using MedicalResearch.Application.Models.Departments.Dto;
using MedicalResearch.Models.DepartmentResearches;
using System.Collections.Generic;
using System.Linq;

namespace MedicalResearch.Models.Departments
{
    public class DepartmentDetailsViewModel
    {
        public int ID { get; set; }
        public int CityID { get; set; }
        public string Street { get; set; }
        public string Building { get; set; }
        public string PhoneNumber { get; set; }
        public string CityName { get; set; }
        public int RegionID { get; set; }
        public string RegionName { get; set; }
        public List<WorkScheduleViewModel> WorkSchedules { get; set; }
        public List<DepartmentResearchListItemViewModel> DepartmentResearches { get; set; }
        
    }

    public static partial class ViewModelMapperExtensions
    {
        public static DepartmentDetailsViewModel AsViewModel(this DepartmentDetailsDTO dto)
        {
            return new DepartmentDetailsViewModel
            {
                ID = dto.ID,
                Building = dto.Building,
                CityName = dto.City.Name,
                CityID = dto.CityID,
                PhoneNumber = dto.PhoneNumber,
                Street = dto.Street,
                RegionID = dto.City.Region.ID,
                RegionName = dto.City.Region.Name,
                WorkSchedules = dto.WorkSchedules.Select(x => x.AsViewModel()).ToList(),
                DepartmentResearches = dto.DepartmentResearches.Select(x => x.AsViewModel()).ToList()
            };
        }
    }
}
