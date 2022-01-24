namespace AthleticAlliance.Application.Common.Interfaces
{
    public interface ITokenService
    {
        public string BuildToken(string userName, string roles);
    }
}
