using MedicalResearch.Application.Models.Users;
using MedicalResearch.Domain.Users;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MedicalResearch.Application.Interfaces
{
    public interface IUserRepository: IBaseRepository
    {
        Task<IList<UserDto>> GetList();
        Task<UserDto> GetUser(int id);
        Task Create(User user);
        Task<User> LogIn(LogInDto item);
        Task<User> Get(string email, string password);
        Task<bool> ExistEmail(string email);
    }
}
