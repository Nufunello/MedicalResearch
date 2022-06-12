using MedicalResearch.Application.Models.Departments.Dto;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;

namespace MedicalResearch.Models.Departments
{
    public class DepartmentCreateUpdateRequestModel
    {
        [Required]
        public int CityID { get; set; }
        [Required]
        [MaxLength(50)]
        public string Street { get; set; }
        [Required]
        [MaxLength(50)]
        public string Building { get; set; }
        [Required]
        [Phone]
        public string PhoneNumber { get; set; }
        [Required]
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
