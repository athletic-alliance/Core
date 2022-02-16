using AthleticAlliance.Application.Common.Interfaces;
using AthleticAlliance.Domain.Entities.Training;
using AthleticAlliance.Domain.Enums;
using MediatR;

namespace AthleticAlliance.Application.Training.Workouts.Commands.CreateWorkout
{
    public class CreateWorkoutCommand : IRequest<int>
    {
        public String Name { get; set; }
        public WorkoutType Type { get; set; }
        public int TimeLimit { get; set; }
        public String? Description { get; set; }
        public List<WorkoutExerciseDto> Exercises { get; set; }
    }

    public class CreateWorkoutCommandHandler : IRequestHandler<CreateWorkoutCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public CreateWorkoutCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateWorkoutCommand request, CancellationToken cancellationToken)
        {
            var workoutExercises = new List<WorkoutExercise>();

            foreach (var workoutExerciseDto in request.Exercises)
            {
                var details = new WorkoutExerciseDetails();
                details.Distance = workoutExerciseDto.Details.Distance;
                details.Weight = workoutExerciseDto.Details.Weight;
                details.Repetitions = workoutExerciseDto.Details.Repetitions;

                var workoutExercise = new WorkoutExercise();
                workoutExercise.Round = workoutExerciseDto.Round;
                workoutExercise.Order = workoutExerciseDto.Order;
                workoutExercise.ExerciseId = workoutExerciseDto.ExerciseId;
                workoutExercise.Details = details;
                workoutExercises.Add(workoutExercise);
            }

            var entity = new Workout
            {
                Name = request.Name,
                Description = request.Description,
                TimeLimit = request.TimeLimit,
                Type = request.Type,
                Exercises = workoutExercises
            };

            _context.Workouts.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return entity.Id;
        }
    }
}
