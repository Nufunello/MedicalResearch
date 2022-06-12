using MedicalResearch.Application.Interfaces;
using MedicalResearch.Application.Models.Cities;
using MedicalResearch.Application.Models.DepartmentResearches.Dto;
using MedicalResearch.Application.Models.Departments.Dto;
using MedicalResearch.Application.Models.Regions.Dto;
using MedicalResearch.Application.Models.Researches.Dto;
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
                        Id = x.CityID,
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
            return await DbContext.Set<Department>().Include(x => x.WorkSchedules).SingleOrDefaultAsync(x => x.ID == id);
        }

        public async Task<DepartmentDetailsDTO> GetDetails(int id)
        {
            var item = await DbContext.Set<Department>()
                .Include(x => x.City)
                .ThenInclude(x => x.Region)
                .Include(x => x.WorkSchedules)
                .Include(x => x.DepartmentResearches)
                .ThenInclude(x => x.Research)
                .ThenInclude(x => x.GroupResearch)
                .Include(x => x.DepartmentResearches)
                .ThenInclude(x => x.DepartmentResearchWorkSchedules)
                .SingleOrDefaultAsync(x => x.ID == id);

            return new DepartmentDetailsDTO
            {
                ID = item.ID,
                CityID = item.CityID,
                Street = item.Street,
                Building = item.Building,
                PhoneNumber = item.PhoneNumber,
                City = new CityDto
                {
                    Id = item.CityID,
                    Name = item.City.Name,
                    Region = new RegionListItemDto
                    {
                        ID = item.City.RegionID,
                        Name = item.City.Region.Name
                    }
                },
                WorkSchedules = item.WorkSchedules.Select(x => new WorkScheduleDTO
                {
                    Id = x.ID,
                    DayOfWeekId = x.DayOfWeekID,
                    StartTime = x.StartTime,
                    EndTime = x.EndTime
                }).ToList(),
                DepartmentResearches = item.DepartmentResearches.Select(x => new DepartmentResearchesListItemDto
                {
                    ID = x.ID,
                    ResearchID = x.ResearchID,
                    Cabinet = x.Cabinet,
                    Research = new ResearchDto
                    {
                        ID = x.ResearchID,
                        Name = x.Research.Name,
                        Description = x.Research.Description,
                        DeadlineInDays = x.Research.DeadlineInDays,
                        Cost = x.Research.Cost,
                        PreparationDescription = x.Research.PreparationDescription,
                        GroupID = x.Research.GroupResearchID,
                        GroupName = x.Research.GroupResearch.Name
                    },
                    WorkSchedule = x.DepartmentResearchWorkSchedules.Select(y => new DepartmentResearchWorkScheduleDTO
                    {
                        Id = y.ID,
                        DayOfWeekId = y.DayOfWeekID,
                        StartTime = y.StartTime,
                        EndTime = y.EndTime
                    }).ToList()
                }).ToList()
            };
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
