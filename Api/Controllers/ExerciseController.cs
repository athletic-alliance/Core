using AthleticAlliance.Application.Training.Exercises.Queries.GetExercises;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExerciseController : ApiControllerBase
    {
        [HttpGet]
        public async Task<ActionResult<ExercisesVm>> Get()
        {
            return await Mediator.Send(new GetExercisesQuery());
        }
    }
}