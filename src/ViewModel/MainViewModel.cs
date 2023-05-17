using Cells;
using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModel
{
    public class MainViewModel
    {
        public MainViewModel()
        {
            // Create empty cell
            CurrentScreen = Cell.Create<ScreenViewModel>(null);

            // Create start screen
            var firstScreen = new SettingsScreenViewModel(CurrentScreen);

            // Put first screen in CurrentScreen cell
            CurrentScreen.Value = firstScreen;
        }
        public ICell<ScreenViewModel> CurrentScreen { get; }
    }
}
