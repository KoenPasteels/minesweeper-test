using Cells;
using Model.Data;
using Model.MineSweeper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModel
{
    public class RowViewModel
    {
        public IEnumerable<SquareViewModel> Squares { get; }

        public RowViewModel(ICell<IGame> game, int rowIndex)
        {
            var squares = new List<SquareViewModel>();
            ICell<IGameBoard> board = game.Derive(g => g.Board);
            ICell<int> width = board.Derive(g => g.Width);
            for (int i = 0; i < width.Value; i++)
            {
                var position = new Vector2D(i, rowIndex);
                squares.Add(new SquareViewModel(game, position));
            }

            this.Squares = squares;
        }
    }
}
