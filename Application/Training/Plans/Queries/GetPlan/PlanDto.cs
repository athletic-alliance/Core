using AthleticAlliance.Application.Common.Mappings;
using AthleticAlliance.Domain.Entities.Training;
using AutoMapper;

namespace AthleticAlliance.Application.Training.Plans.Queries.GetPlan;

public class PlanDto : IMapFrom<Plan>
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }

    public ICollection<PlanTrainingDayDto> TrainingDays { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<Plan, PlanDto>();
    }
}