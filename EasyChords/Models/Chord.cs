using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyChords.Models
{
    public class Chord
    {
        public int ChordId { get; set; }
        public string ChordName { get; set; }
        public bool IsMajor { get; set; }
        public bool IsMinor { get; set; }
        public bool IsNatural { get; set; }
        public bool IsSharp { get; set; }
        public bool IsFlat { get; set; }
        public string ImageUrl { get; set; }
        public int MusicalKeyId { get; set; }
        public MusicalKey MusicalKey { get; set; }

    }
}
