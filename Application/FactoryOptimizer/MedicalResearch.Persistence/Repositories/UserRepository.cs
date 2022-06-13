using MedicalResearch.Application.Interfaces;
using MedicalResearch.Application.Models.Users;
using MedicalResearch.Domain.Users;
using MedicalResearch.Persistence.DatabaseContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MedicalResearch.Persistence.Repositories
{
    public class UserRepository: BaseRepository, IUserRepository
    {
        public UserRepository(IOptions<DatabaseOptions> databaseOptions, PepDbContext dbContext) : base(databaseOptions, dbContext) { }

        public async Task<IList<UserDto>> GetList()
        {
            return await DbContext.Set<User>()
                .Select(r => new UserDto
                {
                    Id = r.Id,
                    Email = r.Email,
                    CanChange = r.CanChange
                })
                .ToListAsync();
        }

        public async Task<UserDto> GetUser(int id)
        {
            var item = await Get<User>(id);
            return new UserDto
            {
                Id = item.Id,
                Email = item.Email,
                CanChange = item.CanChange
            };
        }

        public Task Create(User user)
        {
            return Create<User>(user);
        }

        public async Task<User> LogIn(LogInDto dto)
        {
            return await DbContext.Set<User>().FirstOrDefaultAsync(x => x.Email == dto.Email && x.Password == dto.Password && x.CanChange == true);
        }

        public async Task<User> Get(string email, string password)
        {
            return await DbContext.Set<User>().FirstOrDefaultAsync(x => x.Email == email && x.Password == password);
        }

        public async Task<bool> ExistEmail(string email)
        {
            return await DbContext.Set<User>().AnyAsync(x => x.Email == email);
        }

    }
}
