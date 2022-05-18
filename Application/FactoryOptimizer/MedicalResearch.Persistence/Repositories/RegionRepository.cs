using MedicalResearch.Application.Interfaces;
using MedicalResearch.Application.Models.Regions.Dto;
using MedicalResearch.Domain.Additional;
using MedicalResearch.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalResearch.Persistence.Repositories
{
    public class RegionRepository: BaseRepository, IRegionRepository
    {
        public RegionRepository(IOptions<DatabaseOptions> databaseOptions, PepDbContext dbContext) : base(databaseOptions, dbContext) { }

        public async Task<IList<RegionListItemDto>> GetList()
        {
            return await DbContext.Set<Region>()
                .Select(r => new RegionListItemDto
                {
                    ID = r.ID,
                    Name = r.Name
                })
                .ToListAsync();
        }

        public Task<Region> GetRegion(int id)
        {
            return Get<Region>(id);
        }

        public Task Create(Region region)
        {
            return Create<Region>(region);
        }
    }
}
