using TicTacToe.Models.Interface;

namespace TicTacToe.Models.ConcreteClass.BoardPiece
{
    public class CirclePiece : IPiece
    {
        public PieceType type { get; set; }

        public CirclePiece()
        {
            type = PieceType.O;
        }
    }
}
