using AthleticAlliance.Application.User.Commands.CreateUserCommand;
using AthleticAlliance.Application.User.Queries.FetchCoaches;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    // [Authorize(Roles = "Admin")]
    [ApiController]
    [Route("[controller]")]
    public class UserController : ApiControllerBase
    {
        [HttpGet("coaches")]
        public async Task<List<CoachDto>> GetCoaches()
        {
            return await Mediator.Send(new FetchCoachesQuery());
        }

        [HttpPost]
        public async Task<bool> Post(CreateUserCommand command)
        {
            return await Mediator.Send(command);
        }
    }
}