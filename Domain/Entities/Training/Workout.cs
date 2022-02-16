using AthleticAlliance.Domain.Entities.Common;
using AthleticAlliance.Domain.Enums;

namespace AthleticAlliance.Domain.Entities.Training
{
    public class Workout : BaseEntity
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public WorkoutType Type { get; set; }

        public int TimeLimit { get; set; }

        public string? Description { get; set; }

        public ICollection<WorkoutExercise> Exercises { get; set; }
        
        public ICollection<PassedWorkout> PassedWorkouts { get; set; }
    }
}
