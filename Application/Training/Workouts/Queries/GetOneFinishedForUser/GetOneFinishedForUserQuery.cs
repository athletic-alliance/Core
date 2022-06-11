using AthleticAlliance.Application.Common.Interfaces;
using AthleticAlliance.Application.Training.Workouts.Queries.GetFinishedForUser;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace AthleticAlliance.Application.Training.Workouts.Queries.GetOneFinishedForUser
{
    public class GetOneFinishedForUserQuery : IRequest<List<DoneWorkoutToUserDto>>
    {
        public string UserId { get; set; }
        public int WorkoutId { get; set; }
    }

    public class
        GetOneFinishedForUserQueryCommandHandler : IRequestHandler<GetOneFinishedForUserQuery,
            List<DoneWorkoutToUserDto>>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetOneFinishedForUserQueryCommandHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<DoneWorkoutToUserDto>> Handle(GetOneFinishedForUserQuery request,
            CancellationToken cancellationToken)
        {
            return await _context.DoneWorkoutToUsers
                .Where(x => x.UserId.Equals(request.UserId) && x.WorkoutId == request.WorkoutId)
                .Include(w => w.Workout)
                .Include(w => w.Details)
                .AsNoTracking()
                .ProjectTo<DoneWorkoutToUserDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);
        }
    }
}