using AthleticAlliance.Domain.Entities.Common;
using AthleticAlliance.Domain.Enums;
using System.Text.Json.Serialization;

namespace AthleticAlliance.Domain.Entities.Training
{
    public class Exercise : BaseEntity
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public ExerciseType Type { get; set; }

        public ICollection<WorkoutExercise> WorkoutExercise { get; set; }
    }
}
