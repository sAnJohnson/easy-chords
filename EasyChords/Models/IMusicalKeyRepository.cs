using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyChords.Models
{
    public interface IMusicalKeyRepository
    {
        IEnumerable<MusicalKey> AllMusicalKeys { get; }
    }
}
