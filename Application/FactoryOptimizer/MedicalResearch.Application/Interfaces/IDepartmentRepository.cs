using MedicalResearch.Application.Models.Departments.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MedicalResearch.Application.Interfaces
{
    public interface IDepartmentRepository : IBaseRepository
    {
        Task<IList<DepartmentDTO>> GetList();
        Task Create(DepartmentDTO departmentDTO);
        Task Update(int id, DepartmentDTO departmentDTO);
        Task Delete(int id);
    }
}
