using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace Chapt20_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Board game = new Board();

            // Ask for names and pass to game object
            Write("Enter the name for player 1: ");
            game.Player1 = ReadLine();
            Write("Enter the name for player 2: ");
            game.Player2 = ReadLine();

            WriteLine($"Tic-Tac-Toe between {game.Player1} and {game.Player2}!");

            game.DisplayBoard();

            Read();
        }


    }
}
