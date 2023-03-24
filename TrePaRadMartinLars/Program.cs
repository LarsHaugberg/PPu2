namespace TrePaRadMartinLars
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Run();         
        }
        public static void Run()
        {
            Console.WriteLine("Welcome to Tic Tac Toe");

            var board = new Board();
            bool isPlayerOne = true;
            bool isPlayerTwo = false;

            while (true)
            {
                board.ShowBoard();
                var currentPlayer = isPlayerOne ? 1 : 2;
                
                while (true)
                {
                    Console.Write($"Player {currentPlayer} enter the index position you want to choose: ");
                    var boardIndex = GetUserInput();

                    if (board.IsBoardIndexEmpty(boardIndex))
                    {
                        board.AddUserChoice(isPlayerOne, isPlayerTwo, boardIndex);
                        break;
                    }
                    Console.WriteLine("Position already filled");
                }
                
                board.ShowBoard();

                if (isPlayerOne)
                {
                    if (board.UserHasWon(currentPlayer))
                    {
                        Console.WriteLine($"Player 1 has won!");
                        break;
                    }
                }
                else if (isPlayerTwo)
                {
                    if (board.UserHasWon(currentPlayer))
                    {
                        Console.WriteLine($"Player 2 has won!");
                        break;
                    }
                }

                bool IsItADraw = board.PlayerDraw();

                if(IsItADraw)
                {
                    break;
                }

                isPlayerOne = !isPlayerOne;
                isPlayerTwo = !isPlayerTwo;
            }            
        }
        public static int GetUserInput()
        {
            while (true)
            {
                var userInput = Console.ReadLine();

                try
                {
                    int boardIndex = Convert.ToInt32(userInput);
                    return boardIndex;
                }
                catch
                {
                    Console.WriteLine("You did not enter a number");
                }
            }
        }
    }
}