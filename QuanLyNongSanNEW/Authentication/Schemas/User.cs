namespace QLNongSan.Authentication.Schemas
{
    public class LoggedInUser
    {
        public required Guid Id;
        public required string Username;

        public static LoggedInUser FromEntity(Entities.User user)
        {
            return new LoggedInUser
            {
                Id = user.Id,
                Username = user.Username,
            };
        }
    }
}