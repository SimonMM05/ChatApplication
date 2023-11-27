using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter your name: ");
        string userName = Console.ReadLine();
        Console.WriteLine($"Your chat room name is {userName}");

        User user = new User(userName);
        ChatRoom chatRoom = new ChatRoom();

        bool isChatting = true;
        while (isChatting)
        {
            Console.WriteLine(userName + " type a message or 'exit' to exit the chat room");

            string messageContent = Console.ReadLine();

            Console.SetCursorPosition(0, Console.CursorTop - 1); // Move the cursor to the beginning of the input line
            Console.Write(new string(' ', Console.WindowWidth)); // Clear the input line
            Console.SetCursorPosition(0, Console.CursorTop); // Move the cursor back to the input line

            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write($"{userName}");
            Console.ResetColor();
            Console.WriteLine($"]: {messageContent}");

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
