using AthleticAlliance.Domain.Entities.Common;

namespace AthleticAlliance.Domain.Entities.Training
{
    public class WorkoutExerciseDetails : BaseEntity
    {
        public int Id { get; set; }

        public int? Repetitions { get; set; }

        public int? Weight { get; set; }

        public int? Distance { get; set; }

        public WorkoutExercise Exercise { get; set; }
    }
}
