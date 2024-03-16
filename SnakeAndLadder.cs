using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SnakeAndLadder
{
    internal class SnakeAndLadder
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Player 1 name: ");
            string playerOne = Console.ReadLine();
            Console.WriteLine("Enter Player 2 name: ");
            string playerTwo = Console.ReadLine();
            Game game = new Game();
            game.play(playerOne, playerTwo);
        }
    }
}
