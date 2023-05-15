using Cells;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace ViewModel
{
    public class StartScreenViewModel : ScreenViewModel
    {
        public StartScreenViewModel(ICell<ScreenViewModel> currentScreen) : base(currentScreen)
        {
            var boardsize = 5;
            var mineProbability = 0.1;
            var flooding = true;
            SwitchToPlayScreen = new ActionCommand(() => CurrentScreen.Value = new PlayScreenViewModel(this.CurrentScreen, boardsize, mineProbability, flooding));

            SwitchToSettingsScreen = new ActionCommand(() => CurrentScreen.Value = new SettingsScreenViewModel(this.CurrentScreen));
        }

        public ICommand SwitchToPlayScreen { get; }

        public ICommand SwitchToSettingsScreen { get; }
    }
}
