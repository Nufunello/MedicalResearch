using MedicalResearch.Application.Models.Users;

namespace MedicalResearch.Models.Users
{
    public class LogInRequestModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
    }

    public static partial class ViewModelMapperExtensions
    {
        public static LogInDto AsDto(this LogInRequestModel requestModel)
        {
            return new LogInDto
            {
                Email = requestModel.Email,
                Password = requestModel.Password
            };
        }
    }
}
