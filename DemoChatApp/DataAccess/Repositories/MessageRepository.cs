using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Repositories
{
    public class MessageRepository
    {
        private readonly ChatAppDbContext _context;

        public MessageRepository(ChatAppDbContext context)
        {
            _context = context;
        }

    }
}
