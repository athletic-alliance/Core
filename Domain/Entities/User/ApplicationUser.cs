using Microsoft.AspNetCore.Identity;

namespace AthleticAlliance.Application.Identity
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
