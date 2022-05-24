using MedicalResearch.Application.Services.Department;
using MedicalResearch.Models.Departments;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalResearch.Controllers
{
    [ApiController]
    [Route("department")]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        [HttpGet]
        public async Task<IActionResult> GetDepartmentsAsync()
        {
            var departmentDTOs = await _departmentService.GetList();
            var departmentListItemViewModels = departmentDTOs.Select(i => i.AsViewModel());
            return Ok(departmentListItemViewModels);
        }
    }
}
