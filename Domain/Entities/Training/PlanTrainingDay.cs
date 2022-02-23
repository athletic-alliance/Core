using AthleticAlliance.Domain.Entities.Common;

namespace AthleticAlliance.Domain.Entities.Training
{
    public class PlanTrainingDay : BaseEntity
    {
        public int Id { get; set; }

        public string TrainingDescription { get; set; }

        public DateTime PlannedDate { get; set; }

        public Workout Workout { get; set; }

        public int WorkoutId { get; set; }

        public WarmUp WarmUp { get; set; }

        public int WarmUpId { get; set; }

        public AdditionalTraining AdditionalTraining { get; set; }

        public int PlanTrainingDayDetailsId { get; set; }
    }
}