using static TicTacToe.Models.ConcreteClass.Board;
using TicTacToe.Models.Interface;

namespace TicTacToe.Models.ConcreteClass.WinCheckStrategy
{
    public class CrossWinCheckStrategy : IWinCheckStrategy
    {
        public IPiece type { get; set; }
        public CrossWinCheckStrategy(IPiece type)
        {
            this.type = type;
        }

        public FinalResult winCheckStrategy(List<List<IPiece>> board)
        {
            //not implemented yet
            return FinalResult.None;
        }
    }
}
