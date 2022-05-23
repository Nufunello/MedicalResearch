using MedicalResearch.Application.Interfaces;
using MedicalResearch.Application.Models.Researches;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MedicalResearch.Application.Services.GroupResearch
{
    public class GroupResearchService : IGroupResearchService
    {
        private readonly IGroupResearchRepository _groupResearchRepository;

        public GroupResearchService(IGroupResearchRepository groupResearchRepository)
        {
            _groupResearchRepository = groupResearchRepository ?? throw new ArgumentNullException(nameof(groupResearchRepository));
        }

        public async Task Create(GroupResearchDTO groupResearchDTO)
        {
            await _groupResearchRepository.Create(groupResearchDTO);
            await _groupResearchRepository.SaveChanges();
        }

        public async Task<IList<GroupResearchDTO>> GetList()
        {
            return await _groupResearchRepository.GetList();
        }
    }
}
