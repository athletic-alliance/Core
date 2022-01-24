using AthleticAlliance.Application.Common.Interfaces;
using MediatR;

namespace AthleticAlliance.Application.Auth.Commands.Authenticate
{
    public class AuthenticationCommand : IRequest<string>
    {
        public string Username { get; set; }    
        public string Password { get; set; }    
    }

    public class AuthenticationCommandHandler : IRequestHandler<AuthenticationCommand, string>
    {
        private readonly IIdentityService _identityService;
        private readonly ITokenService _tokenService;

        public AuthenticationCommandHandler(IIdentityService identityService, ITokenService tokenService)
        {
            _identityService = identityService;
            _tokenService = tokenService;
        }

        public async Task<string> Handle(AuthenticationCommand request, CancellationToken cancellationToken)
        {
            var user = await _identityService.FindByUserName(request.Username);

            var token = _tokenService.BuildToken(user.UserName, "Admin");

            return token;
        }
    }
}
