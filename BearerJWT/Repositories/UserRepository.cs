using BearerJWT.Models;

namespace BearerJWT.Repositories
{
    public class UserRepository
    {
        public static User? Get(string username, string password)
        {
            var users = new List<User>
            {
                new() {Id = 1, Username = "batman", Password = "batman", Role = "manager"},
                new() {Id = 2, Username = "flash", Password = "flash", Role = "speedester"}
            };
            return users
                .FirstOrDefault(x =>
                    x.Username.ToLower() == username.ToLower() && x.Password == password
                );
        }
    }
}
