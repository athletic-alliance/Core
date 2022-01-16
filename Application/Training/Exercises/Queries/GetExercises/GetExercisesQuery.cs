using AthleticAlliance.Application.Common.Interfaces;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace AthleticAlliance.Application.Training.Exercises.Queries.GetExercises
{
    public class GetExercisesQuery : IRequest<ExercisesVm>
    {
    }

    public class GetExercisesQueryHandler : IRequestHandler<GetExercisesQuery, ExercisesVm>
    {
        private readonly IApplicationDbContext _context;
        private readonly IMapper _mapper;

        public GetExercisesQueryHandler(IApplicationDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<ExercisesVm> Handle(GetExercisesQuery request, CancellationToken cancellationToken)
        {
            return new ExercisesVm
            {
                Exercises = await _context.Exercises
                .AsNoTracking()
                .ProjectTo<ExerciseDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken),
            };
        }
    }
}
