using Microsoft.AspNetCore.Components;
using WebApp.Interfaces;
using WebApp.Models;

namespace WebApp.Services;

public class AuthenticationService : IAuthenticationService
{
    private readonly IHttpService _httpService;
    private readonly NavigationManager _navigationManager;
    private readonly ILocalStorageService _localStorageService;

    public User User { get; private set; }

    public AuthenticationService(IHttpService httpService, ILocalStorageService localStorageService, NavigationManager navigationManager)
    {
        _httpService = httpService;
        _localStorageService = localStorageService;
        _navigationManager = navigationManager;
    }

    public async Task Logout()
    {
        User = null;
        await _localStorageService.RemoveItem("user");
        _navigationManager.NavigateTo("login");
    }

    public async Task Initialize()
    {
        User = await _localStorageService.GetItem<User>("user");
    }

    public async Task Login(string email, string password)
    {
        User = await _httpService.Post<User>("https://localhost:3001/Auth", new {email, password});
        await _localStorageService.SetItem("user", User);
    }
}