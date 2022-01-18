using AthleticAlliance.Application.Common.Interfaces;
using AthleticAlliance.Domain.Entities.Training;
using AthleticAlliance.Domain.Enums;
using MediatR;

namespace AthleticAlliance.Application.Training.Exercises.Commands.CreateExercise
{
    public class CreateExerciseCommand : IRequest<int>
    {
        public string? Name { get; set; }

        public ExerciseType ExerciseType { get; set; }
    }

    public class CreateExerciseCommandHandler : IRequestHandler<CreateExerciseCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public CreateExerciseCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(CreateExerciseCommand request, CancellationToken cancellationToken)
        {
            var entity = new Exercise
            {
                Name = request.Name,
                Type = request.ExerciseType
            };

            _context.Exercises.Add(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return entity.Id;
        }
    }
}
