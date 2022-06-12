using MedicalResearch.Application.Models.Departments.Dto;

namespace MedicalResearch.Models.Departments
{
    public class DepartmentListItemViewModel
    {
        public int ID { get; set; }
        public int CityID { get; set; }
        public string Street { get; set; }
        public string Building { get; set; }
        public string PhoneNumber { get; set; }
        public string CityName { get; set; }
        public int RegionID { get; set; }
        public string RegionName { get; set; }
    }

    public static partial class ViewModelMapperExtensions
    {
        public static DepartmentListItemViewModel AsViewModel(this DepartmentDTO dto)
        {
            return new DepartmentListItemViewModel
            {
                ID = dto.ID,
                Building = dto.Building,
                CityName = dto.City.Name,
                CityID = dto.CityID,
                PhoneNumber = dto.PhoneNumber,
                Street = dto.Street,
                RegionID = dto.City.Region.ID,
                RegionName = dto.City.Region.Name
            };
        }
    }
}
