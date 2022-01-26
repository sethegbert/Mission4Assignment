using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mission4Assignment.Models
{
    public class MoviesContext : DbContext
    {
        public MoviesContext (DbContextOptions<MoviesContext> options) : base (options)
        {

        }

        public DbSet<NewMovie> Responses { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<NewMovie>().HasData(
            
                new NewMovie
                {
                    MovieId = 1,
                    Category = "Superhero",
                    Title = "Avengers: Endgame",
                    Year = 2019,
                    Director = "Anthony and Joe Russo",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = null,
                    Notes = null
                },
                new NewMovie
                {
                    MovieId = 2,
                    Category = "Drama",
                    Title = "The Pursuit of Happyness",
                    Year = 2006,
                    Director = "Gabriele Muccino",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = null,
                    Notes = null
                },
                new NewMovie
                {
                    MovieId = 3,
                    Category = "Adventure",
                    Title = "The Secret Life of Walter Mitty",
                    Year = 2013,
                    Director = "Ben Stiller",
                    Rating = "PG",
                    Edited = false,
                    LentTo = null,
                    Notes = null
                }
            );
        }
    }
}
