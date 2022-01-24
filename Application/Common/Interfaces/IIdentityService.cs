using AthleticAlliance.Infrastructure.Identity;

namespace AthleticAlliance.Application.Common.Interfaces
{
    public interface IIdentityService
    {
        public Task<ApplicationUser> FindByUserName(string username);
        public Task<bool> CreateUser(string username, string password, string email, string firstName, string lastName);
    }
}
