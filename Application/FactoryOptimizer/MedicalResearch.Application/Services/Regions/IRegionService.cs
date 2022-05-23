using MedicalResearch.Application.Models.Regions.Dto;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MedicalResearch.Application.Services.Regions
{
    public interface IRegionService
    {
        Task<IList<RegionListItemDto>> GetList();
    }
}
