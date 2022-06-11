using AthleticAlliance.Application.Training.Workouts.Commands.CreateWorkout;
using AthleticAlliance.Application.Training.Workouts.Commands.SaveFinished;
using AthleticAlliance.Application.Training.Workouts.Queries.GetFinishedForUser;
using AthleticAlliance.Application.Training.Workouts.Queries.GetOneFinishedForUser;
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

        [HttpPost("finished")]
        public async Task<int> SaveFinished(SaveFinishedWorkoutCommand command)
        {
            return await Mediator.Send(command);
        }

        [HttpGet("finished")]
        public async Task<List<DoneWorkoutToUserDto>> GetAllFinishedForUser([FromQuery(Name = "userId")] string userId)
        {
            return await Mediator.Send(new GetFinishedForUserQuery() {UserId = userId});
        }
        
        [HttpGet("finished/{workoutId}")]
        public async Task<List<DoneWorkoutToUserDto>> GetOneFinishedForUser([FromQuery(Name = "userId")] string userId, int workoutId)
        {
            return await Mediator.Send(new GetOneFinishedForUserQuery() {UserId = userId, WorkoutId = workoutId});
        }
    }
}