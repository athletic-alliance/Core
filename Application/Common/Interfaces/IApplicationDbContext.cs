using AthleticAlliance.Domain.Entities.Training;
using Microsoft.EntityFrameworkCore;

namespace AthleticAlliance.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Plan> Plans { get; }
        public DbSet<PlanTrainingDay> PlanTrainingDays { get; }
        DbSet<Exercise> Exercises { get; }
        DbSet<Workout> Workouts { get; }
        DbSet<DoneWorkoutToUser> DoneWorkoutToUsers { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}