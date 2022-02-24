using AthleticAlliance.Application.Common.Interfaces;
using AthleticAlliance.Application.Training.Workouts.Queries.GetWorkout;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace AthleticAlliance.Application.User.Queries.FetchCoaches;

public class FetchCoachesQuery : IRequest<List<CoachDto>>
{
    public int Id { get; set; }
}

public class FetchCoachesQueryCommandHandler : IRequestHandler<FetchCoachesQuery, List<CoachDto>>
{
    private readonly IApplicationDbContext _context;
    private readonly IIdentityService _identityService;
    private readonly IMapper _mapper;

    public FetchCoachesQueryCommandHandler(IApplicationDbContext context, IIdentityService identityService,
        IMapper mapper)
    {
        _context = context;
        _identityService = identityService;
        _mapper = mapper;
    }

    public async Task<List<CoachDto>> Handle(FetchCoachesQuery request, CancellationToken cancellationToken)
    {
        var coaches = await _identityService.GetUserInRoleAsync("COACH");
        return coaches.AsQueryable().ProjectTo<CoachDto>(_mapper.ConfigurationProvider).ToList();
    }
}