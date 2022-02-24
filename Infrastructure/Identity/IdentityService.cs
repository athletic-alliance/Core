using AthleticAlliance.Application.Common.Interfaces;
using AthleticAlliance.Domain.Entities.User;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace AthleticAlliance.Infrastructure.Identity
{
    public class IdentityService : IIdentityService
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public IdentityService(UserManager<ApplicationUser> userManager, RoleManager<IdentityRole> roleManager)
        {
            _userManager = userManager;
            _roleManager = roleManager;
        }

        public Task<List<ApplicationUser>> FindAll()
        {
            return _userManager.Users.ToListAsync();
        }

        public async Task<bool> CreateUser(string username, string password, string email, string firstName, string lastName)
        {
            bool y = await _roleManager.RoleExistsAsync("Coach");

            if (!y)
            {
                var role = new IdentityRole();
                role.Name = "Coach";
                await _roleManager.CreateAsync(role);
            }
            
            var user = new ApplicationUser
            {
                UserName = username,
                Email = email,
                FirstName = firstName,
                LastName = lastName
            };

            var identityResult = await _userManager.CreateAsync(user, password);

            if (identityResult.Succeeded)
            {
                var result1 = await _userManager.AddToRoleAsync(user, "Coach");
            }
            
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

        public async Task<IList<string>> GetRolesAsync(ApplicationUser user)
        {
            return await _userManager.GetRolesAsync(user);
        }

        public async Task<IList<ApplicationUser>> GetUserInRoleAsync(String roleName)
        {
            return await _userManager.GetUsersInRoleAsync(roleName);
        }
    }
}
