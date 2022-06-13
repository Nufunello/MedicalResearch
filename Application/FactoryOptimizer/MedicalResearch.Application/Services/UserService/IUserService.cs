using MedicalResearch.Application.Models.Users;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MedicalResearch.Application.Services.UserService
{
    public interface IUserService
    {
        Task<IList<UserDto>> GetList();
        Task<UserDto> Get(int id);
        Task<int> Create(RegisterDto dto);
        Task<string> LogIn(LogInDto dto);
        Task Update(UserDto dto);
    }
}
