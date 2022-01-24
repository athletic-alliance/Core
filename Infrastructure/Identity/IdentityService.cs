using AthleticAlliance.Application.Common.Interfaces;
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

        public Task<ApplicationUser> FindByUserName(string username)
        {
            return _userManager.FindByNameAsync(username);
        }
    }
}
