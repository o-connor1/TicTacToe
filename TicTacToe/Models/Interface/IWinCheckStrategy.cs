using TicTacToe.Models.ConcreteClass;
using static TicTacToe.Models.ConcreteClass.Board;

namespace TicTacToe.Models.Interface
{
    public interface IWinCheckStrategy
    {
        abstract FinalResult winCheckStrategy(List<List<IPiece>> board);
    }
}
