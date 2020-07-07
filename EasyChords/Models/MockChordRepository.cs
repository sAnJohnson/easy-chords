using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyChords.Models
{
    public class MockChordRepository : IChordRepository
    {
        private readonly IMusicalKeyRepository _musicalKeyRepository = new MockMusicalKeyRepository();
        public IEnumerable<Chord> AllChords =>
            new List<Chord>
            {
                new Chord {ChordId=1, ChordName="C", ImageUrl="https://pianotels.com/wp-content/uploads/2018/12/C-Chord-300x225.jpg", IsMajor=true, MusicalKey = _musicalKeyRepository.AllMusicalKeys.ToList()[0]},
                new Chord {ChordId=1, ChordName="C#", ImageUrl="https://www.pianosongdownload.com/wpimages/wp905da803_05_06.jpg", IsMajor=true, MusicalKey = _musicalKeyRepository.AllMusicalKeys.ToList()[1]},
                new Chord {ChordId=1, ChordName="D", ImageUrl="https://qph.fs.quoracdn.net/main-qimg-360abc8e4dc352e30191fbea37aa76ff", IsMajor=true, MusicalKey = _musicalKeyRepository.AllMusicalKeys.ToList()[2]}
            };

        public IEnumerable<Chord> MajorChords { get; }

        public IEnumerable<Chord> MinorChords { get; }

        public Chord GetChordById(int chordId)
        {
            return AllChords.FirstOrDefault(p => p.ChordId == chordId);
        }
    }
}
