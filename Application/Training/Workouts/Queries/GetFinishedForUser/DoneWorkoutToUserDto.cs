using AthleticAlliance.Application.Common.Mappings;
using AthleticAlliance.Domain.Entities.Training;
using AutoMapper;

namespace AthleticAlliance.Application.Training.Workouts.Queries.GetFinishedForUser;

public class DoneWorkoutToUserDto : IMapFrom<DoneWorkoutToUser>
{
    public int Id { get; set; }
    public Workout? Workout { get; set; }
    public FinishedWorkoutDetails? Details { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<DoneWorkoutToUser, DoneWorkoutToUserDto>();
    }
}