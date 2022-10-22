using LeChat.Messaging.Domain.Entities;
using LeChat.Messaging.Persistence.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace LeChat.Messaging.Persistence.Repository
{
    public class UserRepository
    {
        private ChatClientMessageDbContext _context;

        public async Task<User> GetUserById(Guid id, CancellationToken cancellationToken)
        {
            var query = _context.User.Where(x => x.Id == id);

            List<User> result = await query.ToListAsync(cancellationToken);

            User entity = result.FirstOrDefault();

            return entity;
        }

        public void AddUser(User entity, CancellationToken cancellationToken)
        {
            _context.Add<User>(entity);
        }
    }
}
