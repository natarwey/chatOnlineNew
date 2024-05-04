namespace chatOnline.Data
{
    public class User
    {
        public User(string username, string password, string passwordConfig)
        {
            Id = Guid.NewGuid().ToString();
            Username = username;
            PasswordConfig = passwordConfig;
            Password = password;
        }

        public string Id { get; set; }
        public string Username { get; set; }
        public string PasswordConfig { get; set; }
        public string Password { get; set; }
    }
    }
