using Model.Data;
using Model.MineSweeper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModel
{
    public class GameBoardViewModel
    {
        private readonly IGameBoard gameBoard;
        public IEnumerable<RowViewModel> Rows { get; }

        public GameBoardViewModel(IGameBoard board)
        {
            this.gameBoard = board;
            this.Rows = GetRows(gameBoard);
        }

        IEnumerable<SquareViewModel> GetRow(IGameBoard board, int row)
        {
            var squares = new List<SquareViewModel>();
            var width = board.Width;

            for (int i = 0; i < width; i++)
            {
                var pos = new Vector2D(row, i);
                var square = board[pos];
                var squareViewModel = new SquareViewModel(square);
                squares.Add(squareViewModel);
            }

            return squares;
        }

        IEnumerable<RowViewModel> GetRows(IGameBoard board)
        {
            var rows = new List<RowViewModel>();
            var height = board.Height;

            for (int i = 0; i < height; i++)
            {
                var row = GetRow(board, i);
                var rowViewModel = new RowViewModel(row);
                rows.Add(rowViewModel);
            }

            return rows;
        }
    }
}
