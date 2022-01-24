using AthleticAlliance.Application.Training.Exercises.Commands.CreateExercise;
using AthleticAlliance.Application.Training.Exercises.Queries.GetExercises;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [Authorize]
    [ApiController]
    [Route("[controller]")]
    public class ExerciseController : ApiControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<List<ExerciseDto>>> Get()
        {
            return await Mediator.Send(new GetExercisesQuery());
        }

        [HttpPost]
        public async Task<int> Post(CreateExerciseCommand command) {
            return await Mediator.Send(command);
        }
    }
}