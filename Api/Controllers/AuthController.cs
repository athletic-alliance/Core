using AthleticAlliance.Application.Auth.Commands.Authenticate;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AuthController : ApiControllerBase
    {
        [HttpPost]
        public async Task<AuthResponseDto> Post(AuthenticationCommand command)
        {
            return await Mediator.Send(command);
        }
    }
}