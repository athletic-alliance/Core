using WebApp.Models;

namespace WebApp.Interfaces;

public interface IAuthenticationService
{
    User User { get; }
    Task Login(string email, string password);
    Task Logout();
    Task Initialize();
}