﻿using Microsoft.EntityFrameworkCore;
using SampleApplication.Models;

namespace SampleApplication.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Joke> Joke { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Joke>().HasData(
                new Joke()
                {
                    Id = 1,
                    Setup = "Yesterday I saw a guy spill all his Scrabble letters on the road",
                    Punchline = "I asked him, What’s the word on the street?"
                }, new Joke()
                {
                    Id = 2,
                    Setup = "Did you hear about the actor who fell through the floorboards?",
                    Punchline = "He was just going through a stage"
                },
                new Joke()
                {
                    Id = 3,
                    Setup = "Did you hear about the claustrophobic astronaut?",
                    Punchline = "He just needed a little space"
                }
            );
        }
    }
}
