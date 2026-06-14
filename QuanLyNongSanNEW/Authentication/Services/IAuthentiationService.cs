namespace QLNongSan.Authentication.Services
{

    using QLNongSan.Authentication.Schemas;

    public interface IAuthenticationService
    {
        public LoggedInUser Authenticate(string username, string password);
    }
}
