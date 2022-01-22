using AthleticAlliance.Domain.Entities.Training;
using Microsoft.EntityFrameworkCore;

namespace AthleticAlliance.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Exercise> Exercises { get; }
        DbSet<Workout> Workouts { get; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
