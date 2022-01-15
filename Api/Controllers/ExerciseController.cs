using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExerciseController : ControllerBase
    {
        private static readonly string[] Exercises = new[]
        {
        "Push Up", "Pull Up", "Squat", "Front Squat", "Overhead Squat", "Bench Press", "Kettlebell Swings", "Snatch", "Clean", "Muscle Clean"
    };

        private readonly ILogger<ExerciseController> _logger;

        public ExerciseController(ILogger<ExerciseController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "Get all exercises")]
        public IEnumerable<String> Get()
        {
            return Exercises;
        }
    }
}