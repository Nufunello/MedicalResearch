namespace MedicalResearch.Domain.Users
{
    public class User
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public bool CanChange { get; set; }
    }
}
