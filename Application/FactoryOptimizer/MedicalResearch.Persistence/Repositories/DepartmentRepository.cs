using MedicalResearch.Application.Interfaces;
using MedicalResearch.Application.Models.Departments.Dto;
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
                .Select(x => new DepartmentDTO()
                {
                    ID = x.ID,
                    Building = x.Building,
                    City = x.City,
                    CityID = x.CityID,
                    DepartmentResearches = x.DepartmentResearches,
                    PhoneNumber = x.PhoneNumber,
                    Street = x.Street,
                    WorkSchedules = x.WorkSchedules
                }).ToListAsync();
        }

        public Task Create(DepartmentDTO departmentDTO)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task Update(int id, DepartmentDTO departmentDTO)
        {
            throw new NotImplementedException();
        }
    }
}
