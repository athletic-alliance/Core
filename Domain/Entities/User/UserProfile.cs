using AthleticAlliance.Domain.Entities.Common;

namespace AthleticAlliance.Domain.Entities.User;

public class UserProfile : BaseEntity
{
    public int Id { get; set; }
    public double Weight { get; set; }
    public int Height { get; set; }
    
    public string UserId { get; set; }
    public ApplicationUser User { get; set; }
}