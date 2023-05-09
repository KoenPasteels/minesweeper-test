using Cells;
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
        public ICell<Square> Square{ get; }
        public ICommand Uncover { get; }

        public SquareViewModel(ICell<IGame> game, Vector2D position)
        {
            this.Square = game.Derive(g => g.Board[position]);
            this.Uncover = new UncoverSquareCommand(game, position);
        }
    }
}
