using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace LearningCoding.Data
{
    public class AppDbContextIdentity: IdentityDbContext<IdentityUser>
    {
        public AppDbContextIdentity(DbContextOptions<AppDbContextIdentity> options) : base(options)
        {
        }
    }
}
