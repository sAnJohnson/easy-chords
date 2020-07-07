using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyChords.Models
{
    public interface IChordRepository
    {
        IEnumerable<Chord> AllChords { get; }
        IEnumerable<Chord> MajorChords { get; }
        IEnumerable<Chord> MinorChords { get; }
        Chord GetChordById(int chordId);
    }
}
