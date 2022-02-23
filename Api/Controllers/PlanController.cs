using AthleticAlliance.Application.Training.Plans.Commands.CreatePlan;
using AthleticAlliance.Application.Training.Plans.Queries.GetPlan;
using AthleticAlliance.Application.Training.Plans.Queries.GetPlanForUser;
using AthleticAlliance.Application.Training.Plans.Queries.GetPlans;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PlanController : ApiControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<PlanDto>>> Get()
        {
            return await Mediator.Send(new GetPlansQuery());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<PlanDto>> GetById(int id)
        {
            return await Mediator.Send(new GetPlanQuery() { Id = id });
        }

        [HttpPost]
        public async Task<ActionResult<int>> Post(CreatePlanCommand command)
        {
            return await Mediator.Send(command);
        }
        
        [HttpGet("user/{userId}")]
        public async Task<ActionResult<PlanDto>> GetPlanForUser(string userId)
        {
            return await Mediator.Send(new GetPlanForUserQuery() { UserId = userId });
        }
    }
}