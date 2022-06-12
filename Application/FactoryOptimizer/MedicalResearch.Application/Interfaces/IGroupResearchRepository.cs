using MedicalResearch.Application.Models.Researches;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MedicalResearch.Application.Interfaces
{
    public interface IGroupResearchRepository : IBaseRepository
    {
        Task<IList<GroupResearchDTO>> GetList();
        Task Create(GroupResearchDTO groupResearchDTO);
        void Update(int id, GroupResearchDTO groupResearchDTO);
        Task Delete(int id);
    }
}
