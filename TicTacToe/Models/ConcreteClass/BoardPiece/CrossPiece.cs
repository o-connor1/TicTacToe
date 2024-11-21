using TicTacToe.Models.Interface;

namespace TicTacToe.Models.ConcreteClass.BoardPiece
{
    public class CrossPiece : IPiece
    {
        public PieceType type { get; set; }
        public CrossPiece()
        {
            type = PieceType.X;
        }
    }
}
