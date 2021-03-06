using MedicalResearch.Application.Interfaces;
using MedicalResearch.Application.Models.Researches;
using MedicalResearch.Domain.Researches;
using MedicalResearch.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MedicalResearch.Persistence.Repositories
{
    public class GroupResearchRepository : BaseRepository, IGroupResearchRepository
    {
        public GroupResearchRepository(IOptions<DatabaseOptions> databaseOptions, PepDbContext dbContext) : base(databaseOptions, dbContext) { }
        
        public async Task<IList<GroupResearchDTO>> GetList()
        {
            return await DbContext.Set<GroupResearch>()
                                  .Select(x => new GroupResearchDTO { Id = x.ID, Description = x.Name })
                                  .ToListAsync();
        }

        public async Task Create(GroupResearchDTO groupResearchDTO)
        {
            GroupResearch groupResearch = new GroupResearch
            {
                Name = groupResearchDTO.Description
            };
            await base.Create<GroupResearch>(groupResearch);
        }

        public void Update(int id, GroupResearchDTO groupResearchDTO)
        {
            GroupResearch groupResearch = new GroupResearch
            {
                ID = id,
                Name = groupResearchDTO.Description
            };

            DbContext.Update<GroupResearch>(groupResearch);
        }

        public async Task Delete(int id)
        {
            var model = await DbContext.Set<GroupResearch>().FirstOrDefaultAsync(x => x.ID == id);
            if(model is null)
            {
                return;
            }
            DbContext.Remove<GroupResearch>(model);
        }
    }
}
