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
                    new Product
                    {
                        Name = "Witcher",
                        Description = "Geralt the Witcher -- revered and hated -- holds the line against the monsters plaguing humanity in this collection of adventures " +
                        "in the NYT bestselling series that inspired the blockbuster video games",
                        Author = "Andrzej Sapkowski",
                        Category = "Fantasy",
                        Price = 20.70M
                    },
                    new Product
                    {
                        Name = "The Hobbit",
                        Description = "A great modern classic and the prelude to The Lord of the Rings.",
                        Author ="J.R.R. Tolkien",
                        Category = "Fantasy",
                        Price = 20
                    },
                    new Product
                    {
                        Name = "Elon Musk: Tesla, SpaceX, and the Quest for a Fantastic Future",
                        Description = "New York Times and International Bestseller \nNamed One of the Best Books of the Year by The Wall Street Journal, NPR, Audible and " +
                        "Amazon"
                        + "More than 2 million copies sold",
                        Author = "Ashlee Vance",
                        Category = "Biography",
                        Price = 19.99M
                    },
                    new Product
                    {
                        Name = "Solaris",
                        Description = "“A fantastic book.” —Steven Soderbergh",
                        Author ="Stanisław Lem",
                        Category = "ScinceFiction",
                        Price = 20
                    },
                    new Product
                    {
                        Name = "A Game of Thrones",
                        Description = "Here is the first volume in George R. R. Martin’s magnificent cycle of novels that includes A Clash of Kings and A Storm of Swords. " +
                        "As a whole, this series comprises a genuine masterpiece of modern fantasy, bringing together the best the genre has to offer.",
                        Author = "George R.R. Martin",
                        Category = "Fantasy",
                        Price = 9.99M
                    },
                    new Product
                    {
                        Name = "The Silmarillion",
                        Description = "The story of the creation of the world and of the First Age, this is the ancient drama to which the characters in The Lord of the Rings" +
                        " look back and in whose events some of them, such as Elrond and Galadriel, took part.",
                        Author = "J.R.R. Tolkien",
                        Category = "Fantasy",
                        Price = 9.99M
                        },
                    new Product
                    {
                        Name = "Dune",
                        Description = "Set in the far future amidst a sprawling feudal interstellar empire where planetary dynasties are controlled by noble houses that " +
                        "owe an allegiance to the imperial House Corrino, Dune tells the story of young Paul Atreides (the heir apparent to Duke Leto Atreides and heir of " +
                        "House Atreides) as he and his family accept control of the desert planet Arrakis, the only source of the 'spice' melange, the most important and " +
                        "valuable substance in the cosmos. ",
                        Author = "Frank Herbert",
                        Category = "ScienceFiction",
                        Price = 9.99M
                        },
                    new Product
                    {
                        Name = "Farenheit 451",
                        Description = "Fahrenheit 451 ofrece la historia de un sombrío y horroroso futuro. Montag, el protagonista, pertenece a una extraña brigada de bomberos " +
                        "cuya misión, paradójicamente, no es la de sofocar incendios sino la de provocarlos, para quemar libros. Porque en el país de Montag está " +
                        "terminantemente prohibido leer. Porque leer obliga a pensar, y en el país de Montag esta prohibido pensar. Porque leer impide ser ingenuamente feliz, " +
                        "y en el país de Montag hay que ser feliz a la fuerza...",
                        Author = "Ray Bradboury",
                        Category = "ScienceFiction",
                        Price = 5.99M
                        },
                    new Product
                    {
                        Name = "1984",
                        Description = "Among the seminal texts of the 20th century, Nineteen Eighty-Four is a rare work that grows more haunting as its futuristic purgatory " +
                        "becomes more real. Published in 1949, the book offers political satirist George Orwell's nightmarish vision of a totalitarian, bureaucratic world and " +
                        "one poor stiff's attempt to find individuality.",
                        Author = "George Orwell",
                        Category = "ScienceFiction",
                        Price = 12.99M
                        },
                    new Product
                    {
                        Name = "The Wright Brothers",
                        Description = "Two-time winner of the Pulitzer Prize David McCullough tells the dramatic story-behind-the-story about the courageous brothers who " +
                        "taught the world how to fly: Wilbur and Orville Wright.",
                        Author = "David McCullough",
                        Category = "Biography",
                        Price = 13.99M
                        },
                    new Product
                    {
                        Name = "Leonardo da Vinci",
                        Description = "Based on thousands of pages from Leonardo's astonishing notebooks and new discoveries about his life and work, Walter Isaacson weaves " +
                        "a narrative that connects his art to his science. He shows how Leonardo's genius was based on skills we can improve in ourselves, such as passionate " +
                        "curiosity, careful observation, and an imagination so playful that it flirted with fantasy.",
                        Author = "Walter Isaacson",
                        Category = "Biography",
                        Price = 14.99M
                    },
                    new Product
                    {
                        Name = "Steve Jobs",
                        Description = "From the author of the bestselling biographies of Benjamin Franklin and Albert Einstein, this is the exclusive, New York Times " +
                        "bestselling biography of Apple co-founder Steve Jobs.",
                        Author = "Walter Isaacson",
                        Category = "Biography",
                        Price = 21.21M
                    });

                context.SaveChanges();
            }
        }
    }
}
