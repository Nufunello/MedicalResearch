using MedicalResearch.Application.Services.Regions;
using MedicalResearch.Models.Regions;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalResearch.Controllers
{
    [ApiController]
    [Route("regions")]
    public class RegionController : ControllerBase
    {
        private readonly IRegionService _regionService;
        public RegionController(IRegionService regionService)
        {
            _regionService = regionService;
        }

        [HttpGet()]
        public async Task<IActionResult> GetRegions()
        {
            var itemsDto = await _regionService.GetList();
            var itemsVM = itemsDto.Select(i => i.AsViewModel());
            return Ok(itemsVM);
        }
    }
}
