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
            SwitchToPlayScreen5 = new ActionCommand(() => CurrentScreen.Value = new PlayScreenViewModel(this.CurrentScreen, 5, 0.1, true));

            SwitchToSettingsScreen = new ActionCommand(() => CurrentScreen.Value = new SettingsScreenViewModel(this.CurrentScreen));
        }

        public ICommand SwitchToPlayScreen5 { get; }

        public ICommand SwitchToSettingsScreen { get; }
    }
}
