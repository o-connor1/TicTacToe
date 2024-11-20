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

        public FinalResult winCheckStrategy()
        {
            //not implemented yet
            return FinalResult.None;
        }
    }
}
