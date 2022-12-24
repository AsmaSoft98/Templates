
namespace Template.Application.Services
{
    public class AuthService : IAuthService
    {
        public AuthenticationResult Login(string email, string password)
        {
            return new AuthenticationResult
            (
                Guid.NewGuid(),
                "firstname",
                "lastname",
                email,
                "token"

            );
        }

        public AuthenticationResult Register(string firstname, string lasname, string email, string password)
        {
            return new AuthenticationResult
           (
               Guid.NewGuid(),
               "firstname",
               "lastname",
               email,
               "token"

           ); 
        }
    }
}
