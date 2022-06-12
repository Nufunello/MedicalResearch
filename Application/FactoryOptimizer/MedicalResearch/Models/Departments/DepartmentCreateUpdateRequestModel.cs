using MedicalResearch.Application.Models.Departments.Dto;
using System.Collections.Generic;
using System.Linq;

namespace MedicalResearch.Models.Departments
{
    public class DepartmentCreateUpdateRequestModel
    {
        public int CityID { get; set; }
        public string Street { get; set; }
        public string Building { get; set; }
        public string PhoneNumber { get; set; }

        public List<WorkScheduleRequestModel> WorkSchedules { get; set; }
    }
    public static partial class ViewModelMapperExtensions
    {
        public static DepartmentCreateUpdateDTO AsDto(this DepartmentCreateUpdateRequestModel requestModel)
        {
            return new DepartmentCreateUpdateDTO
            {
                CityID = requestModel.CityID,
                Street = requestModel.Street,
                Building = requestModel.Building,
                PhoneNumber = requestModel.PhoneNumber,
                WorkSchedules = requestModel.WorkSchedules.Select(x => x.AsDto()).ToList()
            };
        }
    }
}
