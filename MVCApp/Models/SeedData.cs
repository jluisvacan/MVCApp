using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MVCApp.Data;
using System;
using System.Linq;

namespace MVCApp.Models
{
    public static class SeedData
    {
        public static void  Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MVCAppContext(serviceProvider.GetRequiredService<DbContextOptions<MVCAppContext>>()))
            {
                //Look for any movies
                if (context.Movie.Any())
                {
                    return; //DB has been seeded
                }

                    context.Movie.AddRange(
                        new Movie
                        {
                            Title = "When Harry Met Sally",
                            ReleaseDate = DateTime.Parse("1989-02-12"),
                            Genre = "Romantic Comedy",
                            Price = 7.99M,
                            Rating ="R"
                        },
                        new Movie
                        {
                            Title = "Ghostbusters",
                            ReleaseDate = DateTime.Parse("1984-03-13"),
                            Genre = "Comedy",
                            Price = 8.99M,
                            Rating = "PG-13"
                        },
                        new Movie
                        {
                            Title = "Superman: Man of Steel",
                            ReleaseDate = DateTime.Parse("2013-06-12"),
                            Genre = "Action/Sci-fi",
                            Price = 668M,
                            Rating = "PG-13"
                        },
                        new Movie
                        {
                            Title = "Venom",
                            ReleaseDate = DateTime.Parse("2018-10-05"),
                            Genre = "Action/Sci-fi",
                            Price = 856M,
                            Rating = "PG-13"
                        }
                        );
                context.SaveChanges();
                }
            }
        }
}
