using AthleticAlliance.Application.User.Commands.CreateUserCommand;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ApiControllerBase
    {
        [HttpPost]
        public async Task<bool> Post(CreateUserCommand command)
        {
            return await Mediator.Send(command);
        }
    }
}
