using MedicalResearch.Application.Services.Departments;
using MedicalResearch.Models.Departments;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalResearch.Controllers
{
    [ApiController]
    [Route("department")]
    [Authorize]
    public class DepartmentController : ControllerBase
    {
        private readonly IDepartmentService _departmentService;

        public DepartmentController(IDepartmentService departmentService)
        {
            _departmentService = departmentService;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> GetDepartmentsAsync()
        {
            
            var departmentDTOs = await _departmentService.GetList();
            var departmentListItemViewModels = departmentDTOs.Select(i => i.AsViewModel());
            return Ok(departmentListItemViewModels);
        }

        [AllowAnonymous]
        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetDepartmentDetails([FromRoute] int id)
        {
            var item = await _departmentService.GetDetails(id);
            return Ok(item.AsViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> CreateDepartmentAsync(DepartmentCreateUpdateRequestModel model)
        {
            var result = await _departmentService.Create(model.AsDto());
            return Ok(result);
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] DepartmentCreateUpdateRequestModel model)
        {
            await _departmentService.Update(id, model.AsDto());
            return Ok();
        }
    }
}
