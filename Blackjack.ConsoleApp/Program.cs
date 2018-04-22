using System;

using Blackjack.Domain.Service;

namespace Blackjack.ConsoleApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var service = DomainContext.GetService<GameService>();
            var winner = service.Execute();

            Console.WriteLine($"{winner.HandleName}の勝利!");
            Console.WriteLine("続行するには何かキーを押してください．．．");
            Console.ReadKey();
        }
    }
}
