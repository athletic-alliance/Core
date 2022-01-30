using AthleticAlliance.Application.Common.Interfaces;
using MediatR;

namespace AthleticAlliance.Application.Auth.Commands.Authenticate
{
    public class AuthenticationCommand : IRequest<AuthResponseDto>
    {
        public string? Email { get; set; }    
        public string? Password { get; set; }    
    }

    public class AuthenticationCommandHandler : IRequestHandler<AuthenticationCommand, AuthResponseDto>
    {
        private readonly IIdentityService _identityService;
        private readonly ITokenService _tokenService;

        public AuthenticationCommandHandler(IIdentityService identityService, ITokenService tokenService)
        {
            _identityService = identityService;
            _tokenService = tokenService;
        }

        public async Task<AuthResponseDto> Handle(AuthenticationCommand request, CancellationToken cancellationToken)
        {
            var user = await _identityService.FindByEmail(request.Email);

            var passwordValid = await _identityService.PasswordValid(user, request.Password);

            if (!passwordValid)
            {
                throw new UnauthorizedAccessException();
            }
            
            var token = _tokenService.BuildToken(user.UserName, "Admin");

            return new AuthResponseDto(token, token); 
        }
    }
}
