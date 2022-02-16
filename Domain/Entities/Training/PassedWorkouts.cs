using AthleticAlliance.Domain.Entities.Common;

namespace AthleticAlliance.Domain.Entities.Training;

public class PassedWorkouts : BaseEntity
{
    public int Id { get; set; }
    
    public Workout Workout { get; set; }
}