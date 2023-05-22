using Cells;
using Model.Data;
using Model.MineSweeper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace ViewModel
{
    class FlagSquareCommand : ICommand
    {
        public ICell<IGame> Game { get; }
        private Vector2D Position { get; }

        public FlagSquareCommand(ICell<IGame> game, Vector2D position)
        {
            this.Game = game;
            this.Position = position;
        }

        public bool CanExecute(object parameter)
        {
            if (Game.Value.Status != GameStatus.InProgress || Game.Value.Board[Position].Status == SquareStatus.Uncovered)
            {
                return false;
            }
            return true;
        }

        public void Execute(object parameter)
        {
            Game.Value = Game.Value.ToggleFlag(Position);
        }

        public event EventHandler CanExecuteChanged;
    }
}
