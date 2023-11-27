class Message
{
    public User Sender { get; }
    public string Content { get; }

    public Message(User sender, string content)
    {
        Sender = sender;
        Content = content;
    }
}