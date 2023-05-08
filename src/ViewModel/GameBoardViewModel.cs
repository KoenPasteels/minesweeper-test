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
        public IEnumerable<IEnumerable<Square>> Rows { get; }

        public GameBoardViewModel(IGameBoard board)
        {
            this.gameBoard = board;
            this.Rows = GetRows(gameBoard);
        }

        IEnumerable<Square> GetRow(IGameBoard board, int row)
        {
            var squares = new List<Square>();
            var width = board.Width;

            for (int i = 0; i < width; i++)
            {
                var pos = new Vector2D(row, i);
                var square = board[pos];
                squares.Add(square);
            }

            return squares;
        }

        IEnumerable<IEnumerable<Square>> GetRows(IGameBoard board)
        {
            var rows = new List<IEnumerable<Square>>();
            var height = board.Height;

            for (int i = 0; i < height; i++)
            {
                var row = GetRow(board, i);
                rows.Add(row);
            }

            return rows;
        }
    }
}
