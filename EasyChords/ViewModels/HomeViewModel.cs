using EasyChords.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyChords.ViewModels
{
    public class HomeViewModel
    {
        public IEnumerable<Chord> MajorChords { get; set; }
        public IEnumerable<Chord> MinorChords { get; set; }
    }
}
