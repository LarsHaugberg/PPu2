using System;

namespace TrePaRadMartinLars
{
    internal class Board
    {
        readonly int[] _currentBoard;

        public Board()
        {
            _currentBoard = new int[9];
        }
        public void ShowBoard()
        {
            Console.WriteLine();
            Console.WriteLine("Use the number index for position");
            Console.WriteLine();   
            Console.WriteLine("012");
            Console.WriteLine("345");
            Console.WriteLine("678");
            Console.WriteLine("\n");
            System.Console.WriteLine("++++++++++++++++++++");

            for (int i = 0; i < 9; i++)
            {
                if (_currentBoard[i] == 0)
                {
                    Console.Write("_");
                }

                if (_currentBoard[i] == 1)
                {
                    Console.Write("X");
                }

                if (_currentBoard[i] == 2)
                {
                    Console.Write("O");
                }

                if (i == 2 || i == 5 || i == 8) { Console.WriteLine(); }
            }
            Console.WriteLine();
        }
        public void AddUserChoice(bool isPlayerOne, bool isPlayerTwo, int boardIndex)
        {
            if (isPlayerOne)
            {
                _currentBoard[boardIndex] = 1;
            }
            if (isPlayerTwo)
            {
                _currentBoard[boardIndex] = 2;
            }
        }
        public bool IsBoardIndexEmpty(int boardIndex)
        {
            if (_currentBoard[boardIndex] == 1 || _currentBoard[boardIndex] == 2)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool UserHasWon(int currentUser)
        {
            if (_currentBoard[0] == currentUser && _currentBoard[1] == currentUser && _currentBoard[2] == currentUser)
            {
                return true;
            }
            else if (_currentBoard[3] == currentUser && _currentBoard[4] == currentUser && _currentBoard[5] == currentUser)
            {
                return true;
            }
            else if (_currentBoard[6] == currentUser && _currentBoard[7] == currentUser && _currentBoard[8] == currentUser)
            {
                return true;
            }
            else if (_currentBoard[0] == currentUser && _currentBoard[3] == currentUser && _currentBoard[6] == currentUser)
            {
                return true;
            }
            else if (_currentBoard[1] == currentUser && _currentBoard[4] == currentUser && _currentBoard[7] == currentUser)
            {
                return true;
            }
            else if (_currentBoard[2] == currentUser && _currentBoard[5] == currentUser && _currentBoard[8] == currentUser)
            {
                return true;
            }
            else if (_currentBoard[0] == currentUser && _currentBoard[4] == currentUser && _currentBoard[8] == currentUser)
            {
                return true;
            }
            else if (_currentBoard[2] == currentUser && _currentBoard[4] == currentUser && _currentBoard[6] == currentUser)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool PlayerDraw()
        {
            int numberOfFilledSlots = 0;

            for (int i = 0; i < _currentBoard.Length; i++)
            {
                if (_currentBoard[i] == 1 || _currentBoard[i] == 2)
                {
                    numberOfFilledSlots++;
                }
            }

            if (numberOfFilledSlots == _currentBoard.Length)
            {
                System.Console.WriteLine("its a draw!");
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}