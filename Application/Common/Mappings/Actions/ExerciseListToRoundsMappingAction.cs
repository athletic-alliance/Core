using AthleticAlliance.Application.Training.Workouts.Queries.GetWorkout;
using AthleticAlliance.Domain.Entities.Training;
using AutoMapper;

namespace AthleticAlliance.Application.Common.Mappings.Actions;

public class ExerciseListToRoundsMappingAction : IMappingAction<Workout, WorkoutDto>
{
    public void Process(Workout workout, WorkoutDto destination, ResolutionContext context)
    {
        var x = workout.Exercises?.GroupBy(exercise => exercise.Round)
            .ToDictionary(g => g.Key, g => g.OrderBy(x => x.Order).ToList())
            .Select(kvp => new WorkoutRoundDto
                {Index = kvp.Key, Exercises = context.Mapper.Map<List<WorkoutRoundExerciseDto>>(kvp.Value)})
            .ToList();

        destination.Rounds = x;
    }
}