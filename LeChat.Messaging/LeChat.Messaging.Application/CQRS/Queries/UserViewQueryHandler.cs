
using AutoMapper;
using LeChat.Messaging.Application.Interfaces;
using LeChat.Messaging.Application.Models.Queries;
using LeChat.Messaging.Application.Models.ViewModels;
using MediatR;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace LeChat.Messaging.Application.CQRS.Queries
{
    public class UserViewQueryHandler: IRequestHandler<UserViewQuery, IEnumerable<UserViewModel>>
    {
        private readonly IMapper _mapper;
        private readonly IUserRepository _repository;

        public UserViewQueryHandler(IMapper mapper, IUserRepository repository)
        {
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<IEnumerable<UserViewModel>> Handle(UserViewQuery request, CancellationToken cancellationToken)
        {
            var resultEntities = await _repository.GetUsers(request, cancellationToken);

            if (resultEntities == null)
            {
                return null;
            }

            var resultViewModel = _mapper.Map<IEnumerable<UserViewModel>>(resultEntities);

            return resultViewModel;
        }
    }
}
