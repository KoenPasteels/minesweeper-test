using Cells;
using Model.MineSweeper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace ViewModel
{
    public class PlayScreenViewModel
    {
        public PlayScreenViewModel()
        {
            // Create empty cell
            CurrentScreen = Cell.Create<ScreenViewModel>(null);

            // Create start screen
            var firstScreen = new SettingsScreenViewModel(CurrentScreen);

            // Put first screen in CurrentScreen cell
            CurrentScreen.Value = firstScreen;
        }
        public ICell<ScreenViewModel> CurrentScreen { get; }
        //public ICommand SwitchToSettingsScreen { get; }
    }
}
