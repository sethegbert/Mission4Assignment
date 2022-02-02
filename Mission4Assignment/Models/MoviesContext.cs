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
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(ModelBuilder mb)
        {
            mb.Entity<Category>().HasData(
                new Category { CategoryID = 1, CategoryName = "Superhero" },
                new Category { CategoryID = 2, CategoryName = "Drama" },
                new Category { CategoryID = 3, CategoryName = "Adventure" },
                new Category { CategoryID = 4, CategoryName = "Action" },
                new Category { CategoryID = 5, CategoryName = "Comedy" },
                new Category { CategoryID = 6, CategoryName = "Fantasy" },
                new Category { CategoryID = 7, CategoryName = "Horror" },
                new Category { CategoryID = 8, CategoryName = "Mystery" },
                new Category { CategoryID = 9, CategoryName = "Romance" },
                new Category { CategoryID = 10, CategoryName = "Thriller" },
                new Category { CategoryID = 11, CategoryName = "Western" }
            );
            

            mb.Entity<NewMovie>().HasData(
            
                new NewMovie
                {
                    MovieId = 1,
                    CategoryID = 1,
                    Title = "Avengers: Endgame",
                    Year = 2019,
                    Director = "Anthony and Joe Russo",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                },
                new NewMovie
                {
                    MovieId = 2,
                    CategoryID = 2,
                    Title = "The Pursuit of Happyness",
                    Year = 2006,
                    Director = "Gabriele Muccino",
                    Rating = "PG-13",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                },
                new NewMovie
                {
                    MovieId = 3,
                    CategoryID = 3,
                    Title = "The Secret Life of Walter Mitty",
                    Year = 2013,
                    Director = "Ben Stiller",
                    Rating = "PG",
                    Edited = false,
                    LentTo = "",
                    Notes = ""
                }
            );
        }
    }
}
