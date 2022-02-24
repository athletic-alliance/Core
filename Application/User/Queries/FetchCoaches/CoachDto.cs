using AthleticAlliance.Application.Common.Mappings;
using AthleticAlliance.Domain.Entities.User;
using AutoMapper;

namespace AthleticAlliance.Application.User.Queries.FetchCoaches;

public class CoachDto : IMapFrom<ApplicationUser>
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    
    public void Mapping(Profile profile)
    {
        profile.CreateMap<ApplicationUser, CoachDto>();
    }
}