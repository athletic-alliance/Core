using AthleticAlliance.Application.Common.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace AthleticAlliance.Application.Training.Plans.Queries.GetPlan
{
    public class GetPlanQuery : IRequest<PlanDto>
    {
        public int Id { get; set; }
    }

    public class GetPlanQueryCommandHandler : IRequestHandler<GetPlanQuery, PlanDto>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetPlanQueryCommandHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<PlanDto> Handle(GetPlanQuery request, CancellationToken cancellationToken)
        {
            return await _context
                .Plans
                .Where(plan => plan.Id == request.Id)
                .Include(plan => plan.TrainingDays)
                .ThenInclude(w => w.Workout)
                .AsNoTracking()
                .ProjectTo<PlanDto>(_mapper.ConfigurationProvider)
                .FirstAsync(cancellationToken);
        }
    }
}