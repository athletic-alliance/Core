using AthleticAlliance.Application.Common.Interfaces;
using AthleticAlliance.Domain.Entities.Common;
using AthleticAlliance.Domain.Entities.Training;
using AthleticAlliance.Domain.Entities.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace AthleticAlliance.Infrastructure.Persistence
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole, string>,
        IApplicationDbContext
    {
        public DbSet<Plan> Plans => Set<Plan>();
        public DbSet<PlanTrainingDay> PlanTrainingDays => Set<PlanTrainingDay>();
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

            builder.Entity<ApplicationUser>().HasOne(a => a.Plan).WithOne(b => b.User)
                .HasForeignKey<Plan>(c => c.UserId);
            builder.Entity<Plan>().HasMany(w => w.TrainingDays);
            builder.Entity<PlanTrainingDay>().HasOne(pw => pw.Workout);
            builder.Entity<Workout>().HasMany(w => w.Exercises).WithOne(e => e.Workout);
            builder.Entity<Workout>().HasMany(w => w.PassedWorkouts).WithOne(pw => pw.Workout);
            builder.Entity<WorkoutExercise>().HasOne(w => w.Details);
            builder.Entity<WorkoutExercise>().HasOne(w => w.Exercise);
            builder.Entity<ApplicationUser>().HasOne(a => a.Profile).WithOne(b => b.User)
                .HasForeignKey<UserProfile>(c => c.UserId);
        }

        public override int SaveChanges()
        {
            AddTimestamps();
            return base.SaveChanges();
        }

        public override async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            AddTimestamps();
            return await base.SaveChangesAsync(cancellationToken);
        }

        private void AddTimestamps()
        {
            var entities = ChangeTracker.Entries()
                .Where(x => x.Entity is BaseEntity &&
                            (x.State == EntityState.Added || x.State == EntityState.Modified));

            foreach (var entity in entities)
            {
                var now = DateTime.UtcNow; // current datetime

                if (entity.State == EntityState.Added)
                {
                    ((BaseEntity) entity.Entity).Created = now;
                }

                ((BaseEntity) entity.Entity).LastModified = now;
            }
        }
    }
}