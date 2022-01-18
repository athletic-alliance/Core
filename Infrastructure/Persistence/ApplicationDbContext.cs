using AthleticAlliance.Application.Common.Interfaces;
using AthleticAlliance.Domain.Entities.Training;
using AthleticAlliance.Infrastructure.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace AthleticAlliance.Infrastructure.Persistence
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>, IApplicationDbContext
    {
        public DbSet<Exercise> Exercises => Set<Exercise>();
        public DbSet<Workout> Workouts => Set<Workout>();
        public DbSet<WorkoutExercise> WorkoutExercises => Set<WorkoutExercise>();
        public DbSet<WorkoutExerciseDetails> WorkoutExerciseDetails => Set<WorkoutExerciseDetails>();

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Workout>().HasMany(w => w.Exercises).WithOne(e => e.Workout);
            builder.Entity<Exercise>().HasMany(w => w.WorkoutExercise).WithOne(e => e.Exercise);
            builder.Entity<WorkoutExercise>().HasMany(w => w.WorkoutExerciseDetails).WithOne(e => e.Exercise);
        }
    }
}
