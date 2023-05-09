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

        public SquareViewModel(Square square)
        {
            this.Square = square;
            this.Uncover = new UncoverSquareCommand();
        }
    }
}
