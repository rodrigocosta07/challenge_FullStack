using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace challenge_API.Contexts.Repositories
{
    public class BaseRepository
    {
        protected readonly DbAppContext _context;

        public BaseRepository(DbAppContext context)
        {
            _context = context;
        }
    }
}
