using AthleticAlliance.Domain.Entities.Common;
using AthleticAlliance.Domain.Entities.User;

namespace AthleticAlliance.Domain.Entities.Training;

public class DoneWorkoutToUser : BaseEntity
{
    public int Id { get; set; }
    public Workout? Workout { get; set; }
    public virtual int WorkoutId { get; set; }
    public ApplicationUser User { get; set; }
    public virtual string UserId { get; set; }
    public FinishedWorkoutDetails Details { get; set; }
    public virtual int DetailsId { get; set; }
}