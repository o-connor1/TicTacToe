using System.Collections.Generic;
using TicTacToe.Models.Interface;
using static TicTacToe.Models.ConcreteClass.Board;

namespace TicTacToe.Models.ConcreteClass.WinCheckStrategy
{
    public class RowWinCheckStrategy: IWinCheckStrategy
    {
        public IPiece type { get; set; }
        public RowWinCheckStrategy(IPiece type) 
        {
             this.type = type;
        }

        public FinalResult winCheckStrategy(List<List<IPiece>> board)
        {
            int size = board.Count;
            List<List<IPiece>> playBoard = board;
            bool allFilled = true;
            for(int i = 0; i < size; i++)
            {
                int cnt = 0;
                for(int j = 0; j < size; j++)
                {
                    if (playBoard[i][j].ToString() == this.type.ToString()) cnt++;
                    else if (playBoard[i][j] == null)
                    {
                        allFilled = false;
                        break;
                    }
                }
                if (cnt.Equals(size))
                {
                    return FinalResult.Win;
                }
            }
            if (allFilled)
            {
                return FinalResult.Tie;
            }
            return FinalResult.None;
        }
    }
}
