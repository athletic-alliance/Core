using AthleticAlliance.Application.Common.Exceptions;
using AthleticAlliance.Application.Common.Interfaces;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AthleticAlliance.Application.Training.Exercises.Commands.DeleteExercise
{
    public class DeleteExerciseCommand : IRequest
    {
        public int Id { get; set; }
    }

    public class DeleteExerciseCommandHandler : IRequestHandler<DeleteExerciseCommand>
    {
        private readonly IApplicationDbContext _context;

        public DeleteExerciseCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(DeleteExerciseCommand request, CancellationToken cancellationToken)
        {
            var entity = await _context.Exercises.FindAsync(new object[] { request.Id }, cancellationToken);

            if (entity == null)
            {
                throw new NotFoundException(nameof(Exercises), request.Id);
            }

            _context.Exercises.Remove(entity);

            await _context.SaveChangesAsync(cancellationToken);

            return Unit.Value;
        }
    }
}
