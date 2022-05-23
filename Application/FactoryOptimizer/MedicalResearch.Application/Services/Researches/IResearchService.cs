using MedicalResearch.Application.Models.Regions.Dto;
using MedicalResearch.Application.Models.Researches.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MedicalResearch.Application.Services.Researches
{
    public interface IResearchService
    {
        Task<IList<ResearchListItemDto>> GetResearchListItems(ResearchListQueryDto query);
        Task<int> Create(ResearchCreateDto model);
    }
}
