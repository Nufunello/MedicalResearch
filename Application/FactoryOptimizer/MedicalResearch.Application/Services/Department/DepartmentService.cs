using MedicalResearch.Application.Models.Departments.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MedicalResearch.Application.Services.Department
{
    public class DepartmentService : IDepartmentService
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentService(IDepartmentService departmentService)
        {
            _departmentService = departmentService ?? throw new ArgumentNullException(nameof(departmentService));
        }

        public async Task<IList<DepartmentDTO>> GetList()
        {
            return await _departmentService.GetList();
        }

        public Task Create(DepartmentDTO departmentDTO)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, DepartmentDTO departmentDTO)
        {
            throw new NotImplementedException();
        }
    }
}
