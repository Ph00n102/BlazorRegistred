namespace JWTAuthAPI.Dtos
{
    public class UserRegistrationDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string ComfirmPassword { get; set; }

        
    }
}