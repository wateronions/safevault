using Microsoft.AspNetCore.Identity;

namespace SafeVault.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Role { get; set; } // Add Role property if it's part of your design
    }
}