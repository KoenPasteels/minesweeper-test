using Model.MineSweeper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModel
{
    public class RowViewModel
    {
        public IEnumerable<Square> Squares { get; }

        public RowViewModel(IEnumerable<Square> row)
        {
            this.Squares = row;
        }
    }
}
