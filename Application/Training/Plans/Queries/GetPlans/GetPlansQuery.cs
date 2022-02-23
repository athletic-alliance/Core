using AthleticAlliance.Application.Common.Interfaces;
using AthleticAlliance.Application.Training.Plans.Queries.GetPlan;
using AthleticAlliance.Application.Training.Workouts.Queries.GetWorkout;
using AthleticAlliance.Application.Training.Workouts.Queries.GetWorkouts;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace AthleticAlliance.Application.Training.Plans.Queries.GetPlans
{
    public class GetPlansQuery : IRequest<List<PlanDto>>
    {
    }

    public class GetPlansQueryCommandHandler : IRequestHandler<GetPlansQuery, List<PlanDto>>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetPlansQueryCommandHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<PlanDto>> Handle(GetPlansQuery request, CancellationToken cancellationToken)
        {
            return await _context
                .Plans
                .AsNoTracking()
                .ProjectTo<PlanDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);
        }
    }
}