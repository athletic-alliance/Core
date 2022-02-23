using AthleticAlliance.Domain.Entities.Common;

namespace AthleticAlliance.Domain.Entities.Training;

public class WarmUp : BaseEntity
{
    public int Id { get; set; }
        
    public string Description { get; set; }
}