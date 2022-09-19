using System;

namespace TicTacToe_2
{
    public enum Player
    {
        First = 1,
        Second
    }

    public enum Choice
    {
        x = 'x',
        o = 'o'
    }

    public enum State
    {
        Win = 1,
        Lose,
        Draw
    }

    public enum BoardState
    {
        Empty = 0,
        PartiallyFilled,
        Full = 3
    }
}
