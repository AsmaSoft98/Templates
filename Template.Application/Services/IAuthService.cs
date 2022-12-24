
namespace Template.Application.Services
{
    public interface IAuthService
    {
        AuthenticationResult Register(string firstname, string lasname, string email, string password);
        AuthenticationResult Login(string email, string password);
    }
}
