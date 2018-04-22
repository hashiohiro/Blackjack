using Blackjack.Domain.Model;
using Blackjack.Domain.PublicIF;
using Blackjack.Domain.Service;
using Blackjack.Domain.Service.Policy;
using SimpleInjector;
using System;

namespace Blackjack.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var game = new GameService();
            var winner = game.Execute();
            Console.WriteLine($"{winner.HandleName}の勝利!");
            Console.WriteLine("続行するには何かキーを押してください．．．");
            Console.ReadKey();
        }
    }
}
