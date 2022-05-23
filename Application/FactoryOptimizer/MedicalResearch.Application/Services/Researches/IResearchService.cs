using MedicalResearch.Application.Models.Researches.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MedicalResearch.Application.Services.Researches
{
    public interface IResearchService
    {
        Task<IList<ResearchListItemDto>> GetResearchListItems(ResearchListQueryDto query);
        Task<int> Create(ResearchCreateUpdateDto model);
        Task<ResearchDto> GetResearch(int id);
        Task UpdateResearch(int id, ResearchCreateUpdateDto dto);
    }
}
