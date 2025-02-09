using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SafeVault.Models;

nnamespace SafeVault.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser> // Adjust to your user class if needed
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        { }
    }
}
