using AthleticAlliance.Application.Common.Interfaces;
using AthleticAlliance.Domain.Entities.Training;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace AthleticAlliance.Application.Training.Workouts.Queries.GetWorkout
{
    public class GetWorkoutQuery : IRequest<WorkoutDto>
    {
        public int Id { get; set; }
    }

    public class GetWorkoutQueryCommandHandler : IRequestHandler<GetWorkoutQuery, WorkoutDto>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetWorkoutQueryCommandHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<WorkoutDto> Handle(GetWorkoutQuery request, CancellationToken cancellationToken)
        {
            Workout workout = await _context
                .Workouts
                .Where(w => w.Id == request.Id)
                .Include(w => w.Exercises).ThenInclude(w => w.Exercise)
                .Include(w => w.Exercises).ThenInclude(w => w.Details)
                .AsNoTracking()
                .FirstAsync(cancellationToken: cancellationToken);

            return _mapper.Map<WorkoutDto>(workout);
        }
    }
}