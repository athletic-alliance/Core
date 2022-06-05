using AthleticAlliance.Application.Common.Mappings;
using AthleticAlliance.Application.Common.Mappings.Actions;
using AthleticAlliance.Domain.Entities.Training;
using AthleticAlliance.Domain.Enums;
using AutoMapper;

namespace AthleticAlliance.Application.Training.Workouts.Queries.GetWorkout;

public class WorkoutDto : IMapFrom<Workout>
{
    public int Id { get; set; }
    public string? Name { get; set; }

    public WorkoutType Type { get; set; }

    public int TimeLimit { get; set; }
    public string? Description { get; set; }

    public ICollection<WorkoutRoundDto>? Rounds { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<Workout, WorkoutDto>().BeforeMap<ExerciseListToRoundsMappingAction>();
    }
}