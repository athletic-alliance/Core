using AthleticAlliance.Application.Training.Workouts.Commands.CreateWorkout;
using AthleticAlliance.Application.Training.Workouts.Queries.GetWorkouts;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WorkoutController : ApiControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<WorkoutDto>>> Get()
        {
            return await Mediator.Send(new GetWorkoutsQuery());
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<WorkoutDto>> GetById(int id)
        {
            return await Mediator.Send(new GetWorkoutQuery() { Id = id });
        }

        [HttpPost]
        public async Task<int> Post(CreateWorkoutCommand command)
        {
            return await Mediator.Send(command);
        }
    }
}
