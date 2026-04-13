using System;

namespace CybersecurityAwarenessBot
{
    public class Chatbot
    {
        public void Start()
        {
            UIHelper.TypeMessage("Bot: Hello! I am your Cybersecurity Assistant.");
            UIHelper.TypeMessage("Bot: How can I help you stay safe today?");
            Console.WriteLine();

            Console.Write("You: ");
            string userInput = Console.ReadLine();

            UIHelper.TypeMessage("\nBot: Analyzing your input regarding: " + userInput);
            UIHelper.TypeMessage("Bot: Remember to never share your passwords with anyone!");
        }
    }
}