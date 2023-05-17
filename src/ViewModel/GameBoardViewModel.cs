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
        public int Height { get; }

        public GameBoardViewModel(ICell<IGame> game)
        {
            this.Rows = GetRows(game);
        }

        IEnumerable<RowViewModel> GetRows(ICell<IGame> game)
        {
            var rows = new List<RowViewModel>();
            var height = game.Derive(g => g.Board.Height);

            for (int i = 0; i < height.Value; i++)
            {
                var rowViewModel = new RowViewModel(game, i);
                rows.Add(rowViewModel);
            }

            return rows;
        }
    }
}
