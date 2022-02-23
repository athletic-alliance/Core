using AthleticAlliance.Application.Common.Mappings;
using AthleticAlliance.Application.Training.Workouts.Queries.GetWorkout;
using AthleticAlliance.Domain.Entities.Training;
using AutoMapper;

namespace AthleticAlliance.Application.Training.Plans.Queries.GetPlan;

public class PlanTrainingDayDto : IMapFrom<PlanTrainingDay>
{
    public int Id { get; set; }

    public string TrainingDescription { get; set; }

    public DateTime PlannedDate { get; set; }

    public WorkoutDto Workout { get; set; }

    public WarmUpDto WarmUp { get; set; }

    public AdditionalTrainingDto AdditionalTraining { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<PlanTrainingDay, PlanTrainingDayDto>();
    }
}