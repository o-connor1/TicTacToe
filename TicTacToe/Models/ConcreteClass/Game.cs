using TicTacToe.Models.ConcreteClass.BoardPiece;
using TicTacToe.Models.Interface;
using static TicTacToe.Models.ConcreteClass.Board;

namespace TicTacToe.Models.ConcreteClass
{
    public class Game
    {
        public Player player1 { get; set; }
        public Player player2 { get; set; }
        private Board board { get; set; }

        public Game(string name1, string name2, int size)
        {
            this.player1 = new Player(name1, new CrossPiece());
            this.player2 = new Player(name2, new CirclePiece());
            this.board = new Board(size);
        }

        public void Play(int size)
        {
            int turn = 0;
            while(true)
            {
                string playerName = this.player1.name;
                if (turn % 2 != 0)
                {
                    playerName = this.player2.name;
                } 
                Console.WriteLine($"{playerName}, enter your move (row and column):");

                int row, col;

                //taking row input
                Console.Write("Enter row: ");
                while (!int.TryParse(Console.ReadLine(), out row) || row < 0 || row >= size)
                {
                    Console.WriteLine("Invalid input. Please enter a valid row (non-negative integer).");
                }

                //taking column input
                Console.Write("Enter column: ");
                while (!int.TryParse(Console.ReadLine(), out col) || col < 0 || col >= size)
                {
                    Console.WriteLine("Invalid input. Please enter a valid column (non-negative integer).");
                }

                if (this.board.board[row][col] != null)
                {
                    Console.WriteLine($"Invalid input. That place is already filled.");
                    continue;
                }

                IPiece currentType = (turn % 2 == 0) ? new CrossPiece() : new CirclePiece();
                this.board.board[row][col] = currentType;

                //Logging move for player
                Console.WriteLine($"{playerName} has placed their piece at row {row}, column {col}.");
                
                //Print board

                FinalResult currentResult = this.board.checkFinalResult(currentType);
                if (currentResult == FinalResult.None)
                {
                    Console.WriteLine("Game Tied!");
                    break;
                }
                turn++;
            }
        }
    }
}
