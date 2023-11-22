using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your name: ");
        string userName = Console.ReadLine();

        User user = new User(userName); // Create a new User object
        ChatRoom chatRoom = new ChatRoom();

        bool isChatting = true;
        while (isChatting)
        {
            Console.WriteLine("Type a message that other people can see and reply to, or 'exit' to exit the chat room");
            string messageContent = Console.ReadLine();

            if (messageContent.ToLower() == "exit")
            {
                isChatting = false;
            }
            else
            {
                Message message = new Message(user, messageContent);
                chatRoom.AddMessage(message);
            }
        }

        Console.WriteLine("\nChat History:");
        chatRoom.DisplayMessages();
    }
}