using AthleticAlliance.Domain.Entities.Common;
using AthleticAlliance.Domain.Entities.User;

namespace AthleticAlliance.Domain.Entities.Training
{
    public class Plan : BaseEntity
    {
        public int Id { get; set; }

        public string? Name { get; set; }

        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
        
        public ICollection<PlanTrainingDay> TrainingDays { get; set; }
        
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }
}
