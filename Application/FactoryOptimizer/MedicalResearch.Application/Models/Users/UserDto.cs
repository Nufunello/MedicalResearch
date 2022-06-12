namespace MedicalResearch.Application.Models.Users
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public bool CanChange { get; set; }
    }
}
