using MedicalResearch.Application.Models.Researches;
using MedicalResearch.Application.Services.GroupResearch;
using MedicalResearch.Models.GroupResearches;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalResearch.Controllers
{

    [ApiController]
    [Route("group-research")]
    public class GroupResearchController : ControllerBase
    {
        private readonly IGroupResearchService _groupResearchService;

        public GroupResearchController(IGroupResearchService groupResearchService)
        {
            _groupResearchService = groupResearchService;
        }

        [HttpGet]
        public async Task<IActionResult> GetGroupResearchAsync()
        {
            
            var groupResearchDTOs = await _groupResearchService.GetList();
            var groupReserachItemViewModels = groupResearchDTOs.Select(i => i.AsViewModel());
            return Ok(groupReserachItemViewModels);
        }

        [HttpPost]
        public async Task<IActionResult> CreateGroupResearchAsync(GroupResearchDTO groupResearchDTO)
        {
            await _groupResearchService.Create(groupResearchDTO);
            return Ok();
        }
    }
}
