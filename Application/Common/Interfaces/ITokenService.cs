using AthleticAlliance.Domain.Entities.User;

namespace AthleticAlliance.Application.Common.Interfaces
{
    public interface ITokenService
    {
        public string BuildToken(ApplicationUser user, IList<string> roles);
    }
}
