using TicTacToe.Models.ConcreteClass.WinCheckStrategy;
using TicTacToe.Models.Interface;

namespace TicTacToe.Models.ConcreteClass
{
    public sealed class Board
    {
        private int size;
        public List<List<IPiece>> board;
        private IWinCheckStrategy winCheckStrategy;

        public Board(int size)
        {
            this.size = size;
            this.board = new List<List<IPiece>>();

            for(int i = 0; i < size; i++)
            {
                List<IPiece> row = new List<IPiece>();
                for(int j = 0; j < size; j++)
                {
                    row.Add(null);
                }
                this.board.Add(row);
            }
        }

        public void addPiece(int row, int col, IPiece type)
        {
            this.board[row][col] = type;
        }

        public FinalResult checkFinalResult(IPiece type)
        {
            //row wise checking
            this.winCheckStrategy = new RowWinCheckStrategy(type);
            FinalResult rowWiseResult = this.winCheckStrategy.winCheckStrategy();     
            if (rowWiseResult == FinalResult.Win)
            {
                return FinalResult.Win;
            }

            //column wise checking
            this.winCheckStrategy = new ColumnWinCheckStrategy(type);
            FinalResult columnWiseResult = this.winCheckStrategy.winCheckStrategy();
            if (columnWiseResult == FinalResult.Win)
            {
                return FinalResult.Win;
            }

            //cross wise checking
            this.winCheckStrategy = new CrossWinCheckStrategy(type);
            FinalResult crossWiseResult = this.winCheckStrategy.winCheckStrategy();
            if (crossWiseResult == FinalResult.Win)
            {
                return FinalResult.Win;
            }

            //if any of the null spaces left in board then game is not over yet
            if (crossWiseResult == FinalResult.None || columnWiseResult == FinalResult.None || rowWiseResult == FinalResult.None)
            {
                return FinalResult.None;
            }

            return FinalResult.Tie;
        }

        public enum FinalResult
        {
            None, //between the game when it is not over yet
            Win, //if either player wins
            Tie, //after game is ended
            Lose // although we won't use this
        }
    }
}
