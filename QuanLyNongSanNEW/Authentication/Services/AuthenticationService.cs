namespace QLNongSan.Authentication.Services
{
    using Schemas;
    using Repositories;
    using Entities;
    using Errors;

    public class AuthenticationService : IAuthenticationService
    {
        public required IUserRepository userRepository;

        LoggedInUser IAuthenticationService.Authenticate(string username, string password)
        {
            User? user = userRepository.GetUserByUsername(username) ?? throw new AuthenticationError("User not found");
            // TODO: use bcrypt
            if (user.Password != password)
            {
                throw new AuthenticationError("Invalid password");
            }
            return LoggedInUser.FromEntity(user);
        }
    }
}        
   