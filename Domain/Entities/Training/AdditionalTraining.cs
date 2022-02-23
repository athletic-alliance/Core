using AthleticAlliance.Domain.Entities.Common;

namespace AthleticAlliance.Domain.Entities.Training;

public class AdditionalTraining : BaseEntity
{
    public int Id { get; set; }
        
    public string Description { get; set; }
}