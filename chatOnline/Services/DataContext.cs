using chatOnline.Data;
using chatOnline.Pages;

namespace chatOnline.Services
{
    public class DataContext
    {
        public List<Chat> Chats = new List<Chat>();

        public List<User> Users = new List<User>()
        {
            new User("Name1", "Login1", "Password2"),
            new User("Name2", "Login2", "Password2"),
            new User("Name3", "Login3", "Password3")
        };
    }
}
