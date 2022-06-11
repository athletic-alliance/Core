using AthleticAlliance.Application.Common.Interfaces;
using AthleticAlliance.Domain.Entities.Training;
using MediatR;

namespace AthleticAlliance.Application.Training.Workouts.Commands.SaveFinished
{
    public class SaveFinishedWorkoutCommand : IRequest<int>
    {
        public string UserId { get; set; }
        public int WorkoutId { get; set; }
    }

    public class SaveFinishedWorkoutCommandHandler : IRequestHandler<SaveFinishedWorkoutCommand, int>
    {
        private readonly IApplicationDbContext _context;

        public SaveFinishedWorkoutCommandHandler(IApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<int> Handle(SaveFinishedWorkoutCommand request, CancellationToken cancellationToken)
        {
            var entity = new DoneWorkoutToUser()
            {
                UserId = request.UserId,
                WorkoutId = request.WorkoutId
            };

            _context.DoneWorkoutToUsers.Add(entity);
            await _context.SaveChangesAsync(cancellationToken);

            return entity.Id;
        }
    }
}