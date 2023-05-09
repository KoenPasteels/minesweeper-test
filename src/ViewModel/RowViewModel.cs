using Model.MineSweeper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModel
{
    public class RowViewModel
    {
        public IEnumerable<SquareViewModel> Squares { get; }

        public RowViewModel(IEnumerable<SquareViewModel> row, IGame game, int rowIndex) //redundant parameter row, how to access from 2D array?
        {
            this.Squares = row;
        }
    }
}
