using AthleticAlliance.Application.Common.Interfaces;
using AthleticAlliance.Domain.Entities.Training;
using MediatR;

namespace AthleticAlliance.Application.Training.Plans.Commands.CreatePlan;

public class CreatePlanCommand : IRequest<int>
{
    public string Name { get; set; }
    public List<string> UserIds { get; set; }
    public List<CreatePlanWorkoutDto> Workouts { get; set; }
    public DateTime? StartDate { get; set; }
    public DateTime? EndDate { get; set; }
}

public class CreatePlanCommandHandler : IRequestHandler<CreatePlanCommand, int>
{
    private readonly IApplicationDbContext _context;

    public CreatePlanCommandHandler(IApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<int> Handle(CreatePlanCommand request, CancellationToken cancellationToken)
    {
        var savedPlanCount = 0;

        foreach (var userId in request.UserIds)
        {
            var plan = new Plan
            {
                Name = request.Name,
                UserId = userId,
                StartDate = request.StartDate,
                EndDate = request.EndDate,
                TrainingDays = new List<PlanTrainingDay>()
            };

            foreach (var workout in request.Workouts)
            {
                var workoutOfPlan = new PlanTrainingDay
                {
                    PlannedDate = workout.PlannedDate,
                    WorkoutId = workout.WorkoutId
                };
                plan.TrainingDays.Add(workoutOfPlan);
            }

            _context.Plans.Add(plan);

            await _context.SaveChangesAsync(cancellationToken);

            savedPlanCount++;
        }

        return savedPlanCount;
    }
}