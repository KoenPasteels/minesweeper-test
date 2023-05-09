using Cells;
using Model.Data;
using Model.MineSweeper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModel
{
    public class GameBoardViewModel
    {
        public IEnumerable<RowViewModel> Rows { get; }

        public GameBoardViewModel(ICell<IGame> game)
        {
            this.Rows = GetRows(game);
        }

        IEnumerable<SquareViewModel> GetRow(ICell<IGame> game, int row)
        {
            var squares = new List<SquareViewModel>();
            var width = game.Derive(g => g.Board.Width);

            for (int i = 0; i < width.Value; i++)
            {
                var pos = new Vector2D(row, i);
                var squareViewModel = new SquareViewModel(game, pos);
                squares.Add(squareViewModel);
            }
            return squares;
        }

        IEnumerable<RowViewModel> GetRows(ICell<IGame> game)
        {
            var rows = new List<RowViewModel>();
            var height = game.Derive(g => g.Board.Height);

            for (int i = 0; i < height.Value; i++)
            {
                var row = GetRow(game, i);
                var rowViewModel = new RowViewModel(row, game, i);
                rows.Add(rowViewModel);
            }

            return rows;
        }
    }
}
