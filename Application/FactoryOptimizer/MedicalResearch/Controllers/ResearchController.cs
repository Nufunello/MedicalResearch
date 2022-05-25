using MedicalResearch.Application.Services.Regions;
using MedicalResearch.Application.Services.Researches;
using MedicalResearch.Models.Regions;
using MedicalResearch.Models.Researches;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalResearch.Controllers
{
    [ApiController]
    [Route("researches")]
    public class ResearchController : ControllerBase
    {
        private readonly IResearchService _researchService;
        public ResearchController(IResearchService researchService)
        {
            _researchService = researchService;
        }

        [HttpPost()]
        public async Task<IActionResult> GetResearches([FromBody]ResearchListQuery query)
        {
            var queryDto = query.AsDto();
            var itemsDto = await _researchService.GetResearchListItems(queryDto);
            var itemsVM = itemsDto.Select(i => i.AsViewModel());
            return Ok(itemsVM);
        }

        [HttpPost("new")]
        public async Task<IActionResult> Create([FromBody] ResearchCreateUpdateRequestModel model)
        {
            return Ok(await _researchService.Create(model.AsDto()));
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> Get([FromRoute] int id)
        {
            var item = await _researchService.GetResearch(id);
            return Ok(item.AsViewModel());
        }

        [HttpPut("{id:int}")]
        public async Task<IActionResult> Update([FromRoute] int id, [FromBody] ResearchCreateUpdateRequestModel model)
        {
            await _researchService.UpdateResearch(id, model.AsDto());
            return Ok();
        }

    }
}
