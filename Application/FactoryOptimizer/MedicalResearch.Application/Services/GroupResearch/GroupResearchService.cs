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

        public async Task<IList<GroupResearchDTO>> GetList()
        {
            return await _groupResearchRepository.GetList();
        }

        public async Task Create(GroupResearchDTO groupResearchDTO)
        {
            if (groupResearchDTO is null)
            {
                throw new ArgumentNullException(nameof(groupResearchDTO));
            }
            if (String.IsNullOrEmpty(groupResearchDTO.Description))
            {
                throw new ArgumentNullException(nameof(groupResearchDTO.Description));
            }

            await _groupResearchRepository.Create(groupResearchDTO);
            await _groupResearchRepository.SaveChanges();
        }

        public async Task Update(int id, GroupResearchDTO groupResearchDTO)
        {
            if(groupResearchDTO is null)
            {
                throw new ArgumentNullException(nameof(groupResearchDTO));
            }
            if(String.IsNullOrEmpty(groupResearchDTO.Description))
            {
                throw new ArgumentNullException(nameof(groupResearchDTO.Description));
            }

            _groupResearchRepository.Update(id, groupResearchDTO);
            await _groupResearchRepository.SaveChanges();
        }

        public async Task Delete(int id)
        {
            await _groupResearchRepository.Delete(id);
            await _groupResearchRepository.SaveChanges();
        }
    }
}
