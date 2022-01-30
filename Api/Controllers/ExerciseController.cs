using AthleticAlliance.Application.Training.Exercises.Commands.CreateExercise;
using AthleticAlliance.Application.Training.Exercises.Commands.DeleteExercise;
using AthleticAlliance.Application.Training.Exercises.Queries.GetExercises;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
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
        
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id) {
            await Mediator.Send(new DeleteExerciseCommand { Id = id });
            return NoContent();
        }
    }
}