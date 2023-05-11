using Cells;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace ViewModel
{
    public class SettingsScreenViewModel : ScreenViewModel
    {
        public SettingsScreenViewModel(ICell<ScreenViewModel> currentScreen) : base(currentScreen)
        {
            SwitchToStartScreen = new ActionCommand(() => CurrentScreen.Value = new StartScreenViewModel(this.CurrentScreen));
            SwitchToPlayScreen = new ActionCommand(() => CurrentScreen.Value = new PlayScreenViewModel(this.CurrentScreen));
        }

        public ICommand SwitchToStartScreen { get; }

        public ICommand SwitchToPlayScreen { get; }
    }
}
