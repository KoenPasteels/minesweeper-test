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
        public IGame Game { get; }

        public UncoverSquareCommand(IGame game)
        {
            this.Game = game;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            Debug.WriteLine("You clicked me");
        }

        public event EventHandler CanExecuteChanged;
    }
}
