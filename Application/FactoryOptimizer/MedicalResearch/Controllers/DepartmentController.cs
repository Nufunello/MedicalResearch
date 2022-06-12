using MedicalResearch.Application.Services.Departments;
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

        //[HttpGet]
        //public async Task<IActionResult> GetDepartmentDetails()
        //{
        //    return Ok();
        //}

        [HttpPost]
        public async Task<IActionResult> CreateDepartmentAsync(DepartmentCreateUpdateRequestModel model)
        {
            var result = await _departmentService.Create(model.AsDto());
            return Ok(result);
        }
    }
}
