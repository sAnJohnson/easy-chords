using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyChords.Models
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Chord> Chords { get; set; }
        public DbSet<MusicalKey> MusicalKeys { get; set; }

        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //seed Musical Keys
            modelBuilder.Entity<MusicalKey>().HasData(new MusicalKey { MusicalKeyId = 1, MusicalKeyName = "C Major", IsNatural = true, IsFlat = false, IsSharp = false, IsMajor = true });

            //seed Chords
            modelBuilder.Entity<Chord>().HasData(new Chord
            {
                ChordId = 1,
                ChordName = "C Major",
                IsMajor = true,
                IsNatural = true,
                ImageUrl = "https://cdn.instructables.com/F01/5VA7/IQPFDKBU/F015VA7IQPFDKBU.LARGE.jpg?auto=webp&frame=1&fit=bounds",
                MusicalKeyId = 1
            });

            modelBuilder.Entity<Chord>().HasData(new Chord
            {
                ChordId = 2,
                ChordName = "D Minor",
                IsMajor = false,
                IsNatural = true,
                ImageUrl = "https://www.pianochord.org/images/dm.png",
                MusicalKeyId = 1
            });

        }
    }
}
