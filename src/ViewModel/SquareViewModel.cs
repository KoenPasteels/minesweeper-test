using Model.Data;
using Model.MineSweeper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace ViewModel
{
    public class SquareViewModel
    {
        public Square Square { get; }
        public ICommand Uncover { get; }

        public SquareViewModel(Square square, IGame game, Vector2D position)
        {
            this.Square = square;
            this.Uncover = new UncoverSquareCommand(game, position);
        }
    }
}
