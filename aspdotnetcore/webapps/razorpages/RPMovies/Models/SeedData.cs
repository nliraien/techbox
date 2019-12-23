using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RPMovies.Data;
using System;
using System.Linq;

namespace RPMovies.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new RPMoviesContext(serviceProvider.GetRequiredService<DbContextOptions<RPMoviesContext>>()))
            {
                // Look for any movies.
                if (context.Movies.Any())
                {
                    // DB has already been seeded
                    return;
                }

                context.Actors.AddRange(
                    new Actor
                    {
                        FirstName = "Emma",
                        LastName = "Watson",
                        Gender = "female",
                        Birthday = DateTime.Parse("1988-2-13")
                    },
                    new Actor
                    {
                        FirstName = "Ryan",
                        LastName = "Reynold",
                        Gender = "male",
                        Birthday = DateTime.Parse("1980-4-1")
                    },
                    new Actor
                    {
                        FirstName = "Ryan",
                        LastName = "Gosling",
                        Gender = "male",
                        Birthday = DateTime.Parse("1981-6-6")
                    }
                );

                context.Movies.AddRange(
                    new Movie
                    {
                        Title = "When Harry Met Sally",
                        ReleaseDate = DateTime.Parse("1989-2-12"),
                        Genre = "Romantic Comedy",
                        Price = 7.99M,
                        Rating = "R"
                    },
                    new Movie
                    {
                        Title = "Ghostbusters",
                        ReleaseDate = DateTime.Parse("1984-3-13"),
                        Genre = "Comedy",
                        Price = 8.99M,
                        Rating = "PG-13"
                    },
                    new Movie
                    {
                        Title = "Ghostbusters 2",
                        ReleaseDate = DateTime.Parse("1986-2-23"),
                        Genre = "Comedy",
                        Price = 9.99M,
                        Rating = "PG-13"
                    },
                    new Movie
                    {
                        Title = "Rio Bravo",
                        ReleaseDate = DateTime.Parse("1959-4-15"),
                        Genre = "Western",
                        Price = 3.99M,
                        Rating = "PG-13"
                    }
                );

                context.SaveChanges();
            }
        }
    }
}