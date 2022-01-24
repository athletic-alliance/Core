using AthleticAlliance.Application.Common.Interfaces;
using MediatR;

namespace AthleticAlliance.Application.User.Commands.CreateUserCommand
{
    public class CreateUserCommand : IRequest<bool>
    {
        public String Username { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
    }

    public class CreateUserCommandHandler : IRequestHandler<CreateUserCommand, bool>
    {
        private readonly IIdentityService _identityService;

        public CreateUserCommandHandler(IIdentityService identityService)
        {
            _identityService = identityService;
        }

        public Task<bool> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            var result = _identityService.CreateUser(request.Username, request.Password, request.Email, request.FirstName, request.LastName);
            return result;
        }
    }
}
