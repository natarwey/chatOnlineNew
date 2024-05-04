namespace chatOnline.Data
{
    public class Chat
    {
        public Chat()
        {
            Id = Guid.NewGuid().ToString();
            Messages = new List<Message>();
        }
        public string Id { get; private set; }
        public List<Message> Messages { get; private set; }

        public void SendMessage(Message m)
        {
            Messages.Add(m);
        }
    }
}
