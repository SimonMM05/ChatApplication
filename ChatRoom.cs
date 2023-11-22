using System;
using System.Collections.Generic;

class ChatRoom
{
    private List<Message> messages = new List<Message>();

    public void AddMessage(Message message)
    {
        messages.Add(message);
    }

    public void DisplayMessages()
    {
        foreach (var message in messages)
        {
            Console.WriteLine($"{message.Sender.Name}: {message.Content}");
        }
    }
}