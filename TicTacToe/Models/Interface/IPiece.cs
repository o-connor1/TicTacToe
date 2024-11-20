namespace TicTacToe.Models.Interface
{
    public interface IPiece
    {
        abstract PieceType type { get; set; }
    }

    public enum PieceType
    {
        Cross,
        Circle
    };
}
