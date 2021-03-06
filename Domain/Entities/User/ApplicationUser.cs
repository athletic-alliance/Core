using AthleticAlliance.Domain.Entities.Training;
using Microsoft.AspNetCore.Identity;

namespace AthleticAlliance.Domain.Entities.User
{
    public class ApplicationUser : IdentityUser
    {
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? RefreshToken { get; set; }
        public DateTime RefreshTokenExpiryTime { get; set; }

        public UserProfile Profile { get; set; }
        public Plan Plan { get; set; }
    }
}