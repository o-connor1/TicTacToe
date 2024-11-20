using TicTacToe.Models.Interface;

namespace TicTacToe.Models.ConcreteClass
{
    public class Player
    {
        public string name { get; set; }
        public IPiece type { get; set; }

        public Player(string name, IPiece type)
        {
            this.name = name;
            this.type = type;
        }   
    }
}
