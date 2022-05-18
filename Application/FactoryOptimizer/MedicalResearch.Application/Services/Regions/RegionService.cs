using MedicalResearch.Application.Interfaces;
using MedicalResearch.Application.Models.Regions.Dto;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MedicalResearch.Application.Services.Regions
{
    public class RegionService: IRegionService
    {
        private readonly IRegionRepository _regionRepository;

        public RegionService(IRegionRepository regionRepository)
        {
            _regionRepository = regionRepository ?? throw new ArgumentNullException(nameof(regionRepository));
        }

        public async Task<IList<RegionListItemDto>> GetList()
        {
            return await _regionRepository.GetList();
        }
    }
}
