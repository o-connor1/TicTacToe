using static TicTacToe.Models.ConcreteClass.Board;

namespace TicTacToe.Models.Interface
{
    public interface IWinCheckStrategy
    {
        abstract IPiece type { get; set; }
        public abstract FinalResult winCheckStrategy();
    }
}
