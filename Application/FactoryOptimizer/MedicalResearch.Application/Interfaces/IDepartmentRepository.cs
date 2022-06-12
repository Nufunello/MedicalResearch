using MedicalResearch.Application.Models.Departments.Dto;
using MedicalResearch.Domain.Departments;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MedicalResearch.Application.Interfaces
{
    public interface IDepartmentRepository : IBaseRepository
    {
        Task<IList<DepartmentDTO>> GetList();
        Task Create(Department department);
        Task<Department> Get(int id);
        Task<DepartmentDetailsDTO> GetDetails(int id);
        Task Delete(int id);
    }
}
