using AthleticAlliance.Domain.Entities.Common;

namespace AthleticAlliance.Domain.Entities.Training
{
    public class Plan : BaseEntity
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public ICollection<PlanWorkout> Workouts { get; set; }
    }
}
