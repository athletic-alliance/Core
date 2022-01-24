using AthleticAlliance.Domain.Entities.Common;
namespace AthleticAlliance.Domain.Entities.Training
{
    public class PlanWorkout : BaseEntity
    {
        public int Id { get; set; }

        public DateTime PlannedDate { get; set; }

        public Workout Workout { get; set; }
        public int WorkoutId { get; set; }
    }
}
