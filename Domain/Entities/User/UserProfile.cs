using AthleticAlliance.Domain.Entities.Common;

namespace AthleticAlliance.Domain.Entities.User;

public class UserProfile : BaseEntity
{
    public double Weight { get; set; }
    public int Height { get; set; }

    public ICollection<UserProfile> Users { get; set; }
}