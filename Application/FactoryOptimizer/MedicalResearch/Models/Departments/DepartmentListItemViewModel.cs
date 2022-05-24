using MedicalResearch.Application.Models.Departments.Dto;
using MedicalResearch.Domain.Additional;
using MedicalResearch.Domain.DepartmentResearches;
using MedicalResearch.Domain.Departments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalResearch.Models.Departments
{
    public class DepartmentListItemViewModel
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

    public static partial class ViewModelMapperExtensions
    {
        public static DepartmentListItemViewModel AsViewModel(this DepartmentDTO dto)
        {
            return new DepartmentListItemViewModel
            {
                ID = dto.ID,
                Building = dto.Building,
                City = dto.City,
                CityID = dto.CityID,
                DepartmentResearches = dto.DepartmentResearches,
                PhoneNumber = dto.PhoneNumber,
                Street = dto.Street,
                WorkSchedules = dto.WorkSchedules

            };
        }
    }
}
