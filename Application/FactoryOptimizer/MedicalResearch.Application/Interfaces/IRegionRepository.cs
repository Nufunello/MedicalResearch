using MedicalResearch.Application.Models.Regions.Dto;
using MedicalResearch.Domain.Additional;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MedicalResearch.Application.Interfaces
{
    public interface IRegionRepository: IBaseRepository
    {
        Task<IList<RegionListItemDto>> GetList();
        Task<Region> GetRegion(int id);
        Task Create(Region region);
    }
}
