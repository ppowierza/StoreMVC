using Microsoft.Extensions.DependencyInjection;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;

namespace BookStore.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            var scope = app.ApplicationServices.CreateScope();

            ApplicationDbContext context = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product {
                        Name = "Witcher",
                        Description = "Geralt the Witcher -- revered and hated -- holds the line against the monsters plaguing humanity in this collection of adventures in the NYT bestselling series that inspired the blockbuster video games",
                        Category = "Fantasy",
                        Price = 30 },
                    new Product {
                        Name = "The Hobbit",
                        Description = "A great modern classic and the prelude to The Lord of the Rings.",
                        Category = "Fantasy",
                        Price = 20 },
                    new Product
                    {
                        Name = "Elon Musk: Tesla, SpaceX, and the Quest for a Fantastic Future",
                        Description = "New York Times and International Bestseller \nNamed One of the Best Books of the Year by The Wall Street Journal, NPR, Audible and Amazon \n"
                        + "More than 2 million copies sold",
                        Category = "Biography",
                        Price = 20
                    },
                    new Product
                    {
                        Name = "Solaris",
                        Description = "“A fantastic book.” —Steven Soderbergh",
                        Category = "ScinceFiction",
                        Price = 20
                    });
                context.SaveChanges();
            }
        }
    }
}
