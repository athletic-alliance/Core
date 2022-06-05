using AthleticAlliance.Application.Common.Mappings;
using AthleticAlliance.Domain.Entities.Training;
using AutoMapper;

namespace AthleticAlliance.Application.Training.Workouts.Queries.GetWorkout;

public class WorkoutRoundExerciseDto : IMapFrom<WorkoutExercise>
{
    public Exercise? Exercise { get; set; }
    public ViewWorkoutExerciseDetailsDto? Details { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<WorkoutExercise, WorkoutRoundExerciseDto>();
    }
}