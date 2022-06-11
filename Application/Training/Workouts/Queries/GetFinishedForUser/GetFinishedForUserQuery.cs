using AthleticAlliance.Application.Common.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace AthleticAlliance.Application.Training.Workouts.Queries.GetFinishedForUser
{
    public class GetFinishedForUserQuery : IRequest<List<DoneWorkoutToUserDto>>
    {
        public string UserId { get; set; }
    }

    public class
        GetFinishedForUserQueryCommandHandler : IRequestHandler<GetFinishedForUserQuery, List<DoneWorkoutToUserDto>>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetFinishedForUserQueryCommandHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<List<DoneWorkoutToUserDto>> Handle(GetFinishedForUserQuery request,
            CancellationToken cancellationToken)
        {
            return await _context.DoneWorkoutToUsers
                .Where(x => x.UserId.Equals(request.UserId))
                .Include(w => w.Workout)
                .Include(w => w.Details)
                .AsNoTracking()
                .ProjectTo<DoneWorkoutToUserDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);
        }
    }
}