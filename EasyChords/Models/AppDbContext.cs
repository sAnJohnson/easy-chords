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
            modelBuilder.Entity<MusicalKey>().HasData(new MusicalKey { MusicalKeyId = 1, MusicalKeyName = "C#/Db Major", IsNatural = true, IsFlat = false, IsSharp = false, IsMajor = true });
            modelBuilder.Entity<MusicalKey>().HasData(new MusicalKey { MusicalKeyId = 1, MusicalKeyName = "D Major", IsNatural = true, IsFlat = false, IsSharp = false, IsMajor = true });
            modelBuilder.Entity<MusicalKey>().HasData(new MusicalKey { MusicalKeyId = 1, MusicalKeyName = "D#/Eb Major", IsNatural = true, IsFlat = false, IsSharp = false, IsMajor = true });
            modelBuilder.Entity<MusicalKey>().HasData(new MusicalKey { MusicalKeyId = 1, MusicalKeyName = "E Major", IsNatural = true, IsFlat = false, IsSharp = false, IsMajor = true });
            modelBuilder.Entity<MusicalKey>().HasData(new MusicalKey { MusicalKeyId = 1, MusicalKeyName = "F Major", IsNatural = true, IsFlat = false, IsSharp = false, IsMajor = true });
            modelBuilder.Entity<MusicalKey>().HasData(new MusicalKey { MusicalKeyId = 1, MusicalKeyName = "F#/Gb Major", IsNatural = true, IsFlat = false, IsSharp = false, IsMajor = true });
            modelBuilder.Entity<MusicalKey>().HasData(new MusicalKey { MusicalKeyId = 1, MusicalKeyName = "G Major", IsNatural = true, IsFlat = false, IsSharp = false, IsMajor = true });
            modelBuilder.Entity<MusicalKey>().HasData(new MusicalKey { MusicalKeyId = 1, MusicalKeyName = "G#/Ab Major", IsNatural = true, IsFlat = false, IsSharp = false, IsMajor = true });
            modelBuilder.Entity<MusicalKey>().HasData(new MusicalKey { MusicalKeyId = 1, MusicalKeyName = "A Major", IsNatural = true, IsFlat = false, IsSharp = false, IsMajor = true });
            modelBuilder.Entity<MusicalKey>().HasData(new MusicalKey { MusicalKeyId = 1, MusicalKeyName = "A#/Bb Major", IsNatural = true, IsFlat = false, IsSharp = false, IsMajor = true });
            modelBuilder.Entity<MusicalKey>().HasData(new MusicalKey { MusicalKeyId = 1, MusicalKeyName = "B Major", IsNatural = true, IsFlat = false, IsSharp = false, IsMajor = true });

        }
    }
}
