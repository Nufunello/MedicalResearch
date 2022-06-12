using MedicalResearch.Application.Models.Users;
using System.ComponentModel.DataAnnotations;

namespace MedicalResearch.Models.Users
{
    public class RegisterRequestModel
    {
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "Пароль введено не правильно.")]
        public string ConfirmPassword { get; set; }
    }

    public static partial class ViewModelMapperExtensions
    {
        public static RegisterDto AsDto(this RegisterRequestModel requestModel)
        {
            return new RegisterDto
            {
                Email = requestModel.Email,
                Password = requestModel.Password
            };
        }
    }
}
