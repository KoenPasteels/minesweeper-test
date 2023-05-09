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

        public GameBoardViewModel(IGame game)
        {
            this.Rows = GetRows(game);
        }

        IEnumerable<SquareViewModel> GetRow(IGame game, int row)
        {
            var squares = new List<SquareViewModel>();
            var width = game.Board.Width;

            for (int i = 0; i < width; i++)
            {
                var pos = new Vector2D(row, i);
                var squareViewModel = new SquareViewModel(game, pos);
                squares.Add(squareViewModel);
            }
            return squares;
        }

        IEnumerable<RowViewModel> GetRows(IGame game)
        {
            var rows = new List<RowViewModel>();
            var height = game.Board.Height;

            for (int i = 0; i < height; i++)
            {
                var row = GetRow(game, i);
                var rowViewModel = new RowViewModel(row, game, i);
                rows.Add(rowViewModel);
            }

            return rows;
        }
    }
}
