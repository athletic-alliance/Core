using AthleticAlliance.Application.Common.Interfaces;
using AthleticAlliance.Domain.Entities.User;
using Microsoft.AspNetCore.Identity;

namespace AthleticAlliance.Infrastructure.Identity
{
    public class IdentityService : IIdentityService
    {
        private readonly UserManager<ApplicationUser> _userManager;

        public IdentityService(UserManager<ApplicationUser> userManager)
        {
            _userManager = userManager;
        }

        public async Task<bool> CreateUser(string username, string password, string email, string firstName, string lastName)
        {
            var user = new ApplicationUser();
            user.UserName = username;
            user.Email = email;
            user.FirstName = firstName;
            user.LastName = lastName;

            var identityResult = await _userManager.CreateAsync(user, password);

            return identityResult.Succeeded;
        }

        public Task<bool> PasswordValid(ApplicationUser user, string? password)
        {
            return _userManager.CheckPasswordAsync(user, password);
        }

        public Task<ApplicationUser> FindByEmail(string? email)
        {
            return _userManager.FindByEmailAsync(email);
        }

        public Task<ApplicationUser> FindByUserName(string username)
        {
            return _userManager.FindByNameAsync(username);
        }

        public Task<IList<string>> GetRolesAsync(ApplicationUser user)
        {
            return _userManager.GetRolesAsync(user);
        }
    }
}
