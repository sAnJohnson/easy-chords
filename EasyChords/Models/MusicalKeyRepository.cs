using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EasyChords.Models
{
    public class MusicalKeyRepository: IMusicalKeyRepository
    {
        private readonly AppDbContext _appDbContext;
        public MusicalKeyRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }
        public IEnumerable<MusicalKey> AllMusicalKeys => _appDbContext.MusicalKeys;
    }
}
