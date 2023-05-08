using Model.MineSweeper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModel
{
    public class SquareViewModel
    {
        public Square Square { get; }

        public SquareViewModel(Square square)
        {
            this.Square = square;
        }
    }
}
