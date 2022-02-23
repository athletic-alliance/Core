using AthleticAlliance.Application.Common.Interfaces;
using AthleticAlliance.Application.Training.Plans.Queries.GetPlan;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace AthleticAlliance.Application.Training.Plans.Queries.GetPlanForUser
{
    public class GetPlanForUserQuery : IRequest<PlanDto>
    {
        public string UserId { get; set; }
    }

    public class GetPlanForUserQueryCommandHandler : IRequestHandler<GetPlanForUserQuery, PlanDto>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetPlanForUserQueryCommandHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<PlanDto> Handle(GetPlanForUserQuery request, CancellationToken cancellationToken)
        {
            return await _context
                .Plans
                .Where(plan => plan.UserId == request.UserId)
                .Include(plan => plan.TrainingDays)
                .ThenInclude(w => w.Workout)
                .ThenInclude(w => w.Exercises)
                .AsNoTracking()
                .ProjectTo<PlanDto>(_mapper.ConfigurationProvider)
                .FirstAsync(cancellationToken);
        }
    }
}