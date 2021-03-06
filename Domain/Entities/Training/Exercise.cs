using AthleticAlliance.Domain.Entities.Common;
using AthleticAlliance.Domain.Enums;

namespace AthleticAlliance.Domain.Entities.Training
{
    public class Exercise : BaseEntity
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public ExerciseType Type { get; set; }
    }
}
