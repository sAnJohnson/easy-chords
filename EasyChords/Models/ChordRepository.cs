using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyChords.Models
{
    public class ChordRepository: IChordRepository
    {
        private readonly AppDbContext _appDbContext;
        public ChordRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Chord> AllChords 
        {
            get
            {
                return _appDbContext.Chords.Include(m => m.MusicalKey);
            }
        }

        public IEnumerable<Chord> MajorChords
        {
            get
            {
                return _appDbContext.Chords.Include(m => m.MusicalKey).Where(c => c.IsMajor);
            }
        }

        public IEnumerable<Chord> MinorChords
        {
            get
            {
                return _appDbContext.Chords.Include(m => m.MusicalKey).Where(c => c.IsMajor == false);
            }
        }

        public Chord GetChordById(int chordId)
        {
            return _appDbContext.Chords.FirstOrDefault(c => c.ChordId == chordId);
        }
    }
}
