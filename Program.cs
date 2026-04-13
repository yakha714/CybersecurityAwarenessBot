using System;
using System.Media;
using CybersecurityAwarenessBot;

namespace CybersecurityAwarenessBot
{
    class Program
    {
        static void Main(string[] args)
        {
            // TASK 1: Voice Greeting
            try
            {
                // Ensure the filename here matches your file in Solution Explorer
                SoundPlayer player = new SoundPlayer("greeting.wav...mpeg");
                player.Play();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Audio Error: " + ex.Message);
            }

            // TASK 2: UI Header & Logo
            UIHelper.ShowHeader();

            // TASK 3: Bot Conversation
            Chatbot myBot = new Chatbot();
            myBot.Start();

            Console.WriteLine("\n--- Session Active. Press Enter to exit. ---");
            Console.ReadLine();
        }
    }
}