using Cells;
using Model.Data;
using Model.MineSweeper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace ViewModel
{
    public class SquareViewModel
    {
        public ICell<Square> Square{ get; }
        public ICell<IGame> Game { get; }
        public ICell<bool> ContainsMine { get; }
        public ICommand Uncover { get; }
        public ICommand Flag { get; }

        public SquareViewModel(ICell<IGame> game, Vector2D position)
        {
            this.Square = game.Derive(g => g.Board[position]);
            this.Game = game;
            this.ContainsMine = game.Derive(g =>
                {
                    if (game.Value.Status != GameStatus.InProgress)
                    {
                        if (g.Mines.Contains(position))
                        {
                            return true;
                        }
                        else return false;
                    }
                    else return false;
                });

            this.Uncover = new UncoverSquareCommand(game, position);
            this.Flag = new FlagSquareCommand(game, position);
        }
    }
}
