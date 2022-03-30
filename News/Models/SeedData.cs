using System.Linq;
using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;


namespace SportsStore.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            var context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<NewsContext>();
            if (context.Database.GetPendingMigrations().Any()) context.Database.Migrate();
            if (true)
            {
                context.News.AddRange(
                    new News()
                    {
                        NewsTitle = "Kayak",
                        NewsText = "A boat for one person"
                    },
                    new News()
                    {
                        NewsTitle = "Kayak2",
                        NewsText = "A boat for one person"
                    },
                    new News()
                    {
                        NewsTitle = "Kayak3",
                        NewsText = "A boat for one person"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}