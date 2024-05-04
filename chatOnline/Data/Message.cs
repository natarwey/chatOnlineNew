namespace chatOnline.Data
{
    public class Message
    {
        public Message(string valueMessage, User userOwner)
        {
            Id = Guid.NewGuid().ToString();
            ValueMessage = valueMessage;
            DateTime = DateTime.Now;
            UserOwner = userOwner;
        }

        public string Id { get; private set; }
        public string ValueMessage { get; set; }
        public DateTime DateTime { get; private set; }
        public User UserOwner { get; private set; }
    }
}
