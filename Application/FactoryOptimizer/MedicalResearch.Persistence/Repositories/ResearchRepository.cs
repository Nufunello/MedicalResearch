using MedicalResearch.Application.Interfaces;
using MedicalResearch.Application.Models.Researches.Dto;
using MedicalResearch.Domain.Researches;
using MedicalResearch.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalResearch.Persistence.Repositories
{
    public class ResearchRepository: BaseRepository, IResearchRepository
    {
        public ResearchRepository(IOptions<DatabaseOptions> databaseOptions, PepDbContext dbContext) : base(databaseOptions, dbContext) { }

        
        public async Task<IList<ResearchListItemDto>> GetResearches(int? groupId, string groupName, string name)
        {
            return await DbContext.Set<Research>()
                .Where(x => (groupId == null || x.GroupResearchID == groupId)
                    && (groupName == "" || x.GroupResearch.Name.Contains(groupName))
                    && (name == "" || x.Name.Contains(name)))
                .Select(x => new ResearchListItemDto
                {
                    ID = x.ID,
                    Name = x.Name,
                    Description = x.Description,
                    DeadlineInDays = x.DeadlineInDays,
                    Cost = x.Cost,
                    PreparationDescription = x.PreparationDescription,
                    GroupID = x.GroupResearchID,
                    GroupName = x.GroupResearch.Name
                })
                .ToListAsync();
        }

        public Task Create(Research research)
        {
            return Create<Research>(research);
        }
    }
}
