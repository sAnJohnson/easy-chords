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
            modelBuilder.Entity<MusicalKey>().HasData(new MusicalKey { MusicalKeyId = 1, MusicalKeyName = "C Major", IsNatural = true, IsMajor = true });
            modelBuilder.Entity<MusicalKey>().HasData(new MusicalKey { MusicalKeyId = 2, MusicalKeyName = "C Minor", IsNatural = true, IsMajor = false });
            modelBuilder.Entity<MusicalKey>().HasData(new MusicalKey { MusicalKeyId = 3, MusicalKeyName = "C# Major", IsNatural = false, IsMajor = true });
            modelBuilder.Entity<MusicalKey>().HasData(new MusicalKey { MusicalKeyId = 4, MusicalKeyName = "C# Minor", IsNatural = false, IsMajor = false });
            modelBuilder.Entity<MusicalKey>().HasData(new MusicalKey { MusicalKeyId = 5, MusicalKeyName = "D Major", IsNatural = true, IsMajor = true });

            //seed Chords
            modelBuilder.Entity<Chord>().HasData(new Chord
            {
                ChordId = 1,
                ChordName = "C Major",
                IsMajor = true,
                IsNatural = true,
                ImageUrl = "https://chordify.net/img/diagrams/piano/C_maj.png",
                MusicalKeyId = 1
            });

            modelBuilder.Entity<Chord>().HasData(new Chord
            {
                ChordId = 2,
                ChordName = "C Minor",
                IsMajor = false,
                IsNatural = true,
                ImageUrl = "https://chordify.net/img/diagrams/piano/C_min.png",
                MusicalKeyId = 2
            });

            modelBuilder.Entity<Chord>().HasData(new Chord
            {
                ChordId = 3,
                ChordName = "C#/Db Major",
                IsMajor = true,
                IsNatural = false,
                ImageUrl = "https://chordify.net/img/diagrams/piano/Cs_maj.png",
                MusicalKeyId = 3
            });

            modelBuilder.Entity<Chord>().HasData(new Chord
            {
                ChordId = 4,
                ChordName = "C#/Db Minor",
                IsMajor = false,
                IsNatural = false,
                ImageUrl = "https://chordify.net/img/diagrams/piano/Cs_min.png",
                MusicalKeyId = 4
            });

            modelBuilder.Entity<Chord>().HasData(new Chord
            {
                ChordId = 5,
                ChordName = "D Major",
                IsMajor = true,
                IsNatural = true,
                ImageUrl = "https://chordify.net/img/diagrams/piano/D_maj.png",
                MusicalKeyId = 5
            });

            modelBuilder.Entity<Chord>().HasData(new Chord
            {
                ChordId = 6,
                ChordName = "D Minor",
                IsMajor = false,
                IsNatural = true,
                ImageUrl = "https://chordify.net/img/diagrams/piano/D_min.png",
                MusicalKeyId = 1
            });

        }
    }
}
