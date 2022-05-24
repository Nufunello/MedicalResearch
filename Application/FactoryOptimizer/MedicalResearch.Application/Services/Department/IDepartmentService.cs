using MedicalResearch.Application.Models.Departments.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MedicalResearch.Application.Services.Department
{
    public interface IDepartmentService
    {
        Task<IList<DepartmentDTO>> GetList();
        Task Create(DepartmentDTO departmentDTO);
        Task Update(int id, DepartmentDTO departmentDTO);
        Task Delete(int id);
    }
}
