using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyChords.Models
{
    public class MusicalKey
    {
        public int MusicalKeyId { get; set; }
        public string MusicalKeyName { get; set; }
        public bool IsMajor { get; set; }
        public bool IsNatural { get; set; }
        public List<Chord> Chords { get; set; }

    }
}
