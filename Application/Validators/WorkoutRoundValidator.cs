using AthleticAlliance.Application.Common.Exceptions.WorkoutException;
using AthleticAlliance.Application.Training.Workouts.Commands.CreateWorkout;
using AthleticAlliance.Domain.Entities.Training;

namespace AthleticAlliance.Application.Validators
{
    public class WorkoutRoundValidator
    {
        public WorkoutValidationResult Validate(List<WorkoutExerciseDto> exercises)
        {
            if(exercises.Count == 0)
            {
                throw new NoExerciseException("The workout must at least contain one round with one exercise");
            }

            if(exercises.Any(x => x.Round == 0))
            {
                throw new RoundNotSetException("The value of round attribute muste greater than 0 on each exercise");
            }

            return new WorkoutValidationResult(true);
        }
    }
}
