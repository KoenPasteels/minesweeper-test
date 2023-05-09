using Cells;
using Model.Data;
using Model.MineSweeper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Input;

namespace ViewModel
{
    class UncoverSquareCommand : ICommand
    {
        public ICell<IGame> Game { get; }
        private Vector2D Position { get; }

        public UncoverSquareCommand(ICell<IGame> game, Vector2D position)
        {
            this.Game = game;
            this.Position = position;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            Debug.WriteLine(Position.ToString());
            Game.Value = Game.Value.UncoverSquare(Position);
        }

        public event EventHandler CanExecuteChanged;
    }
}
