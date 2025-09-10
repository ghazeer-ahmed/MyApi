using Microsoft.AspNetCore.Identity;

namespace MyApi.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string? FullName { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
    }
}