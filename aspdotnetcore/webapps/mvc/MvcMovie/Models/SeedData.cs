using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcMovieContext(
                serviceProvider.GetRequiredService<DbContextOptions<MvcMovieContext>>()))
            {
                if (context.Movies.Any())
                {
                    return;
                }

                context.Movies.AddRange(
                    new Movie
                    {
                        Title = "Avengers Endgame",
                        ReleaseDate = DateTime.Parse("2019-4-27"),
                        Genre = "Action",
                        Price = 19.99M
                    },
                    new Movie
                    {
                        Title = "La La Land",
                        ReleaseDate = DateTime.Parse("2017-5-6"),
                        Genre = "Musical",
                        Price = 14.99M
                    },
                    new Movie
                    {
                        Title = "Avengers Infinity War",
                        ReleaseDate = DateTime.Parse("2018-4-22"),
                        Genre = "Action",
                        Price = 19.99M
                    }
                );

                context.SaveChanges();
            }
        }
    }
}