using LeChat.Messaging.Application.Models.Queries;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace LeChat.Messaging.Application.Interfaces
{
    public interface IUserRepository
    {
        public Task<IEnumerable<Domain.Entities.User>> GetUsers(UserViewQuery query, CancellationToken cancellationToken);
        public Task<Domain.Entities.User> GetUserById(Guid id, CancellationToken cancellationToken);
        public void AddUser(Domain.Entities.User entity, CancellationToken cancellationToken);       
    }
}
