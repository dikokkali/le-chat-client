using LeChat.Messaging.Application.Interfaces;
using LeChat.Messaging.Application.Models.Queries;
using LeChat.Messaging.Application.Models.ViewModels;
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
    public class UserRepository: IUserRepository
    {
        private readonly ChatClientMessageDbContext _context;

        public UserRepository(ChatClientMessageDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<User>> GetUsers(UserViewQuery query, CancellationToken cancellationToken)
        {
            IQueryable<User> dbquery = _context.User;

            if (query.Id.HasValue)
                dbquery = dbquery.Where(x => x.Id == query.Id);

            if (query.FirstName != null)
                dbquery = dbquery.Where(x => x.FirstName == query.FirstName);

            if (query.LastName != null)
                dbquery = dbquery.Where(x => x.LastName == query.LastName);

            if (query.Nickname != null)
                dbquery = dbquery.Where(x => x.Nickname == query.Nickname);

            var result = await dbquery.ToListAsync(cancellationToken);

            return result;
        }

        public async Task<User> GetUserById(Guid id, CancellationToken cancellationToken)
        {
            var query = _context.User.Where(x => x.Id == id);

            List<User> result = await query.ToListAsync(cancellationToken);

            User entity = result.FirstOrDefault();

            return entity;
        }

        public async void AddUser(User entity, CancellationToken cancellationToken)
        {
            _context.Add(entity);
            await _context.SaveChangesAsync();
        }
    }
}
