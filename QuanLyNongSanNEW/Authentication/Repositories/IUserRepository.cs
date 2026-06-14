namespace QLNongSan.Authentication.Repositories
{
    public class CreateUserParams {
        public required string Username { get; set; }
        public required string Password { get; set; }
    }

    public interface IUserRepository
    {
        // FIXME: should authenticate password by using some kind of bcrypt
        public Entities.User? GetUserByUsername(string username);

        public Entities.User CreateUser(CreateUserParams create_params);
    }
}