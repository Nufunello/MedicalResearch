using MedicalResearch.Application.Models.Users;

namespace MedicalResearch.Models.Users
{
    public class UserViewModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public bool CanChange { get; set; }
    }

    public static partial class ViewModelMapperExtensions
    {
        public static UserViewModel AsViewModel(this UserDto dto)
        {
            return new UserViewModel
            {
                Id = dto.Id,
                Email = dto.Email,
                CanChange = dto.CanChange
            };
        }
    }
}
