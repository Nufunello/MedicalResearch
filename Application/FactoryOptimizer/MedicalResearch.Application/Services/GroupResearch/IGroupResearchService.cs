using MedicalResearch.Application.Models.Researches;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MedicalResearch.Application.Services.GroupResearch
{
    public interface IGroupResearchService
    {
        Task<IList<GroupResearchDTO>> GetList();
        Task Create(GroupResearchDTO groupResearchDTO);
        Task Update(int id, GroupResearchDTO groupResearchDTO);
        Task Delete(int id);
    }
}
