using MedicalResearch.Application.Models.Departments.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MedicalResearch.Application.Services.Departments
{
    public interface IDepartmentService
    {
        Task<IList<DepartmentDTO>> GetList();
        Task<DepartmentDetailsDTO> GetDetails(int id);
        Task<int> Create(DepartmentCreateUpdateDTO departmentDTO);
        Task Update(int id, DepartmentCreateUpdateDTO departmentDTO);
        Task Delete(int id);
    }
}
