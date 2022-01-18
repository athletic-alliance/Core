using AthleticAlliance.Domain.Entities.Common;

namespace AthleticAlliance.Domain.Entities.Training
{
    public class Workout : BaseEntity
    {
        public int Id { get; set; }

        public string? Name { get; set; }


        public ICollection<WorkoutExercise> Exercises { get; set; }
    }
}
