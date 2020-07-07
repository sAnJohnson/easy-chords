using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyChords.Models
{
    public class MockMusicalKeyRepository : IMusicalKeyRepository
    {
        public IEnumerable<MusicalKey> AllMusicalKeys =>
            new List<MusicalKey>
            {
                new MusicalKey{MusicalKeyId=1, MusicalKeyName="C", IsMajor=true, IsNatural=true, IsSharp=false, IsFlat=false},
                new MusicalKey{MusicalKeyId=2, MusicalKeyName="C#", IsMajor=true, IsNatural=false, IsSharp=true, IsFlat=false },
                new MusicalKey{MusicalKeyId=3, MusicalKeyName="D", IsMajor=true, IsNatural=true, IsSharp=false, IsFlat=false }
            };
    }
}
