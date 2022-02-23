using AthleticAlliance.Application.Common.Mappings;
using AthleticAlliance.Domain.Entities.Training;
using AutoMapper;

namespace AthleticAlliance.Application.Training.Plans.Queries.GetPlan;

public class WarmUpDto : IMapFrom<WarmUp>
{
    public string Description { get; set; }

    public void Mapping(Profile profile)
    {
        profile.CreateMap<WarmUp, WarmUpDto>();
    }
}