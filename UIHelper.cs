using System;
using System.Threading;

namespace CybersecurityAwarenessBot
{
    public static class UIHelper
    {
        public static void TypeMessage(string message)
        {
            foreach (char c in message)
            {
                Console.Write(c);
                Thread.Sleep(30);
            }
            Console.WriteLine();
        }

        public static void ShowHeader()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"
                 _________________
                /                \
               /      S A F E     \
              |      _______       |
              |     |  [X]  |      |
              |     |_______|      |
               \                  /
                \________________/
            ");
            Console.WriteLine("************************************************************");
            Console.WriteLine("*             CYBERSECURITY AWARENESS BOT                  *");
            Console.WriteLine("************************************************************");
            Console.ResetColor();
        }
    }
}