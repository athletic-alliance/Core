using AthleticAlliance.Application.Training.Workouts.Commands.CreateWorkout;
using AthleticAlliance.Application.Training.Workouts.Queries.GetWorkout;
using AthleticAlliance.Application.Training.Workouts.Queries.GetWorkouts;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    // [Authorize(Roles = "Admin, Coach")]
    [ApiController]
    [Route("[controller]")]
    public class WorkoutController : ApiControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<WorkoutDto>>> Get(bool includeDetails = false)
        {
            return await Mediator.Send(new GetWorkoutsQuery() {IncludeDetails = includeDetails});
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<WorkoutDto>> GetById(int id)
        {
            return await Mediator.Send(new GetWorkoutQuery() {Id = id});
        }

        [HttpPost]
        public async Task<int> Post(CreateWorkoutCommand command)
        {
            return await Mediator.Send(command);
        }
    }
}