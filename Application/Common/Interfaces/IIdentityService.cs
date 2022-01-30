using AthleticAlliance.Domain.Entities.User;

namespace AthleticAlliance.Application.Common.Interfaces
{
    public interface IIdentityService
    {
        Task<ApplicationUser> FindByUserName(string username);
        Task<bool> CreateUser(string username, string password, string email, string firstName, string lastName);
        Task<bool> PasswordValid(ApplicationUser user, string? password);
        Task<ApplicationUser> FindByEmail(string? email);
    }
}
