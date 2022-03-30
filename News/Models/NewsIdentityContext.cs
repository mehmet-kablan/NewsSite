using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;


namespace SportsStore.Models
{
    public class NewsIdentityContext : IdentityDbContext<IdentityUser>
    {
        public NewsIdentityContext(DbContextOptions<NewsIdentityContext> options) : base(options)
        {
        }
    }
}