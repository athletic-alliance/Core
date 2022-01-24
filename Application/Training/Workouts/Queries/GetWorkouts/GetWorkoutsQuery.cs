using AthleticAlliance.Application.Common.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace AthleticAlliance.Application.Training.Workouts.Queries.GetWorkouts
{
    public class GetWorkoutsQuery : IRequest<List<WorkoutDto>>
    {
    }

    public class GetWorkoutsQueryCommandHandler : IRequestHandler<GetWorkoutsQuery, List<WorkoutDto>>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetWorkoutsQueryCommandHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<WorkoutDto>> Handle(GetWorkoutsQuery request, CancellationToken cancellationToken)
        {
            return await _context
                .Workouts
                .Include(w => w.Exercises)
                .ThenInclude(w => w.Exercise)
                //.OrderBy(w => w.Exercises.OrderBy(e => e.Round))
                .AsNoTracking()
                .ProjectTo<WorkoutDto>(_mapper.ConfigurationProvider)
                .ToListAsync();
        }
    }
}
