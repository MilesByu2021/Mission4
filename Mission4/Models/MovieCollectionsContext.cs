using System;
using Microsoft.EntityFrameworkCore;

namespace Mission4.Models
{
    //inherit from the parent program to here by using Microsoft.EntityFrameworkCore
    public class MovieCollectionsContext : DbContext
    {
        public MovieCollectionsContext(DbContextOptions<MovieCollectionsContext> options) : base (options)
        {
            //leave blank here
        }

        public DbSet<AddNewMovie> AddNewMovies { get; set; }

        //Override and post the below object into the database
        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<AddNewMovie>().HasData
                (
                    new AddNewMovie
                    {
                        MovieId = 1,
                        Category = "Marfia",
                        Title = "The Godfather",
                        Year = 1972,
                        Director = "Francis Ford Coppola",
                        Rating = "R",
                        Edited = false,
                        Lent = "Shaun",
                        Notes ="Michael is the real boss"

                    },
                    new AddNewMovie
                    {
                        MovieId = 2,
                        Category = "Action/Adventure",
                        Title = "Spider-Man: No Way Home",
                        Year = 2022,
                        Director = "Jon Watts",
                        Rating = "PG-13",
                        Edited = false,
                        Lent = "Thor",
                        Notes = "Peter Parker is Spiderman"

                    },
                    new AddNewMovie
                    {
                        MovieId = 3,
                        Category = "Action/Adventure",
                        Title = "Snake Eyes",
                        Year = 2021,
                        Director = "Robert Schwentke",
                        Rating = "PG-13",
                        Edited = true,
                        Lent = "Caden",
                        Notes = "Sanke Eyes can speak!"

                    }

                );
        }

    }
}
