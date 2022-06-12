using MedicalResearch.Application.Cities;
using MedicalResearch.Application.Interfaces;
using MedicalResearch.Application.Models.Departments.Dto;
using MedicalResearch.Application.Models.Regions.Dto;
using MedicalResearch.Domain.Additional;
using MedicalResearch.Domain.Departments;
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
    public class DepartmentRepository : BaseRepository, IDepartmentRepository
    {
        public DepartmentRepository(IOptions<DatabaseOptions> databaseOptions, PepDbContext dbContext) : base(databaseOptions, dbContext) { }

        public async Task<IList<DepartmentDTO>> GetList()
        {
            return await DbContext.Set<Department>()
                .Include(x => x.City)
                .ThenInclude(c => c.Region)
                .Select(x => new DepartmentDTO()
                {
                    ID = x.ID,
                    Building = x.Building,
                    City = new CityDto
                    {
                        ID = x.CityID,
                        Name = x.City.Name,
                        Region = new RegionListItemDto
                        {
                            ID = x.City.RegionID,
                            Name = x.City.Region.Name
                        }
                    },
                    CityID = x.CityID,
                    PhoneNumber = x.PhoneNumber,
                    Street = x.Street
                }).ToListAsync();
        }

        public async Task<Department> Get(int id)
        {
            return await DbContext.Set<Department>().SingleOrDefaultAsync(x => x.ID == id);
        }

        public Task Create(Department department)
        {
            return Create<Department>(department);
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
