using AthleticAlliance.Domain.Entities.Common;

namespace AthleticAlliance.Domain.Entities.Training;

public class FinishedWorkoutDetails : BaseEntity
{
    public int Id { get; set; }
    public int TotalRounds { get; set; }
    public int TotalTime { get; set; }
    public int TotalReps { get; set; }
}