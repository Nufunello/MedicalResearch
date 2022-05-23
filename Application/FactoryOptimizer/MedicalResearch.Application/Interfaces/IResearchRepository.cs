using MedicalResearch.Application.Models.Researches.Dto;
using MedicalResearch.Domain.Researches;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MedicalResearch.Application.Interfaces
{
    public interface IResearchRepository: IBaseRepository
    {
        Task<IList<ResearchListItemDto>> GetResearches(int? groupId, string groupName, string name);

        Task Create(Research research);
    }
}
