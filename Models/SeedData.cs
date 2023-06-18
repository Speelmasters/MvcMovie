using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {

            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Title = "17 Miracles",
                    ReleaseDate = DateTime.Parse("2011-6-03"),
                    Genre = "Adventure-Drama",
                    Price = 9.99M,
                    ImageName = "17miracles"
                },
                new Movie
                {
                    Title = "Ephraim's Rescue",
                    ReleaseDate = DateTime.Parse("2013-5-31"),
                    Genre = "Adventure-Drama",
                    Price = 19.99M,
                    ImageName = "ephraimsrescue"
                },
                new Movie
                {
                    Title = "Gordon B. Hinckley: A Giant Among Men",
                    ReleaseDate = DateTime.Parse("2008-11-25"),
                    Genre = "Romance",
                    Price = 3.99M,
                    ImageName = "gordonbhinckleyagiantamongmen"
                },
                new Movie
                {
                    Title = "Love, Kennedy",
                    ReleaseDate = DateTime.Parse("2017-6-02"),
                    Genre = "Drama",
                    Price = 9.99M,
                    ImageName = "lovekennedy"
                },
                new Movie
                {
                    Title = "Meet the Mormons",
                    ReleaseDate = DateTime.Parse("2014-10-10"),
                    Genre = "Documentary",
                    Price = 11.99M,
                    ImageName = "meetthemormons"
                }
            );
            context.SaveChanges();
        }
    }
}