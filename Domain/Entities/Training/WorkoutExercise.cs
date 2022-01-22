using AthleticAlliance.Domain.Entities.Common;

namespace AthleticAlliance.Domain.Entities.Training
{
    public class WorkoutExercise : BaseEntity
    {
        public int Id { get; set; }

        public Workout? Workout { get; set; }

        public Exercise? Exercise { get; set; }
        public int ExerciseId { get; set; }

        public WorkoutExerciseDetails? Details { get; set; }
    }
}
