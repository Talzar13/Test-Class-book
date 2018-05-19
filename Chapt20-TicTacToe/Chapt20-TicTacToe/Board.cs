using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Chapt20_TicTacToe
{
    class Board
    {
        // Initial Variables, including char array for the board. 11 x 5
        private string player1 = "Player 1";
        private string player2 = "Player 2";
        private char[,] board = new char[11,5];
        private char x = 'X';
        private char o = 'O';
        //private char wall = '|';
        //private char floor = '-';
        //private char cross = '+';
        //private char space = ' ';


        // Constructors to build board frame.
        public Board()
        {
            DrawColumns(0);
            DrawRows(1);
            DrawColumns(2);
            DrawRows(3);
            DrawColumns(4);
        }

        public string Player1
        {
            get
            {
                return player1;
            }
            set
            {
                player1 = value;
            }

        }

        public string Player2
        {
            get
            {
                return player2;
            }
            set
            {
                player2 = value;
            }

        }

        // Methods
        public void DisplayBoard()
        {
            for (int j = 0; j <5; j++)
            {
                for (int i = 0; i < 11; i++)
                {
                    Write(board[i, j]);
                }
                WriteLine();
            }
        }

        private void DrawColumns(int row)
        {
            for (int i = 0; i < 11; i++)
            {
                if ((i + 1) % 4 == 0)
                {
                    board[i, row] = '|';
                }
            }
        }

        private void DrawRows(int row)
        {
            for (int i = 0; i < 11; i++)
            {
                if ((i + 1) % 4 == 0)
                {
                    board[i, row] = '+';
                }
                else
                {
                    board[i, row] = '-';
                }
            }
        }
    }
}
