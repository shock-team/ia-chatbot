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
            Bot AI = new Bot();
            AI.loadSettings();
            AI.loadAIMLFromFiles(); 
            AI.isAcceptingUserInput = false;

            User myUser = new User("Santi", AI);
            AI.isAcceptingUserInput = true;

            while (true)
            {
                Console.Write("Me: ");
                Request r = new Request(Console.ReadLine(), myUser, AI);

                Result res = AI.Chat(r);

                Console.WriteLine("Shock!Bot: " + res.Output);
            }
        }
    }
}
