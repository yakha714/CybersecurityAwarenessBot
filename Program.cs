using System;
using System.Media;
using System.IO;

namespace CybersecurityAwarenessBot
{
    class Program
    {
        static void Main(string[] args)
        {
            // Voice greeting attempt - this adds a friendly touch when the bot starts
            try
            {
                string soundPath = "greeting.wav";
                if (File.Exists(soundPath))
                {
                    SoundPlayer player = new SoundPlayer(soundPath);
                    player.PlaySync();
                }
                else
                {
                    Console.WriteLine("Note: greeting.wav file not found. Voice greeting skipped.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Audio Error: " + ex.Message);
            }

            // Display the welcome header with ASCII art
            UIHelper.ShowHeader();

            // Start the main chatbot conversation
            Chatbot bot = new Chatbot();
            bot.Start();

            // Session has ended - show appropriate exit message
            UIHelper.TypeMessage("\nBot: Session ended. Thanks for learning about cybersecurity!");
            UIHelper.TypeMessage("Press Enter to close the window...");
            Console.ReadLine();
        }
    }
}
