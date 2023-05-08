using Model.MineSweeper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModel
{
    public class RowViewModel
    {
        public IEnumerable<SquareViewModel> Squares { get; }

        public RowViewModel(IEnumerable<SquareViewModel> row)
        {
            this.Squares = row;
        }
    }
}
