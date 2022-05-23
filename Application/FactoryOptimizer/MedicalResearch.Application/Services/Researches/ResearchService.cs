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
        public async Task<int> Create(ResearchCreateDto model)
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
    }
}
