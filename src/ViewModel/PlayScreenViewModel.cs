using Cells;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace ViewModel
{
    public class PlayScreenViewModel : ScreenViewModel
    {
        public PlayScreenViewModel(ICell<ScreenViewModel> currentScreen, int boardsize, double mineprobability, bool flooding) : base(currentScreen)
        {
            SwitchToStartScreen = new ActionCommand(() => CurrentScreen.Value = new StartScreenViewModel(this.CurrentScreen));

            SwitchToSettingsScreen = new ActionCommand(() => CurrentScreen.Value = new SettingsScreenViewModel(this.CurrentScreen));
        }

        public ICommand SwitchToStartScreen { get; }
        public ICommand SwitchToSettingsScreen { get; }
    }
}
