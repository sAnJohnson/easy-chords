using EasyChords.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyChords.ViewModels
{
    public class ChordsListViewModel
    {
        public IEnumerable<Chord> Chords { get; set; }
        public string CurrentMusicalKey { get; set; }
    }
}
