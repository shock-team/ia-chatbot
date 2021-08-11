using AIMLbot;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IA.ChatBot.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Loads data from .xml files.
            Bot bot = new Bot();
            bot.loadSettings();
            bot.loadAIMLFromFiles(); 
            bot.isAcceptingUserInput = false;

            // Needed to accept user input.
            User myUser = new User("Santi", bot);
            bot.isAcceptingUserInput = true;

            // Chat indefinitely with the bot.
            while (true)
            {
                Console.Write("Me: ");
                Request r = new Request(Console.ReadLine(), myUser, bot);

                Result res = bot.Chat(r);

                Console.WriteLine("Shock!Bot: " + res.Output);
            }
        }
    }
}
