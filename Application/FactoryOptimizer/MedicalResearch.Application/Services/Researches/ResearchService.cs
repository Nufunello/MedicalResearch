using MedicalResearch.Application.Interfaces;
using MedicalResearch.Application.Models.Researches.Dto;
using MedicalResearch.Domain.Researches;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MedicalResearch.Application.Services.Researches
{
    public class ResearchService: IResearchService
    {
        private readonly IResearchRepository _researchRepository;

        public ResearchService(IResearchRepository researchRepository)
        {
            _researchRepository = researchRepository ?? throw new ArgumentNullException(nameof(researchRepository));
        }
        public async Task<IList<ResearchListItemDto>> GetResearchListItems(ResearchListQueryDto query)
        {
            return await _researchRepository.GetResearches(query.GroupID, query.GroupName, query.Name);
        }
        public async Task<int> Create(ResearchCreateUpdateDto model)
        {
            //add check

            var research = new Research
            {
                Name = model.Name,
                Description = model.Description,
                DeadlineInDays = model.DeadlineInDays,
                Cost = model.Cost,
                PreparationDescription = model.PreparationDescription,
                GroupResearchID = model.GroupResearchID
            };

            await _researchRepository.Create(research);
            await _researchRepository.SaveChanges();

            return research.ID;
        }

        public async Task<ResearchDto> GetResearch(int id)
        {
            var item = await _researchRepository.GetDetails(id);
            return item;
        }

        public async Task UpdateResearch(int id, ResearchCreateUpdateDto dto)
        {
            var item = await _researchRepository.Get(id);
            if (item == null)
                throw new ArgumentNullException($"research does not exist with this id ={id}");

            item.Cost = dto.Cost;
            item.DeadlineInDays = dto.DeadlineInDays;
            item.Description = dto.Description;
            item.GroupResearchID = dto.GroupResearchID;
            item.Name = dto.Name;
            item.PreparationDescription = dto.PreparationDescription;

            await _researchRepository.SaveChanges();
        }
    }
}
