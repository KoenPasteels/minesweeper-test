using Cells;
using Model.MineSweeper;
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
            //SwitchToPlayScreen = new ActionCommand(() => CurrentScreen.Value = new PlayScreenViewModel(this.CurrentScreen, boardsize, mineprobability, flooding));
            
            this.MinimumSlider = IGame.MinimumBoardSize;
            this.MaximumSlider = IGame.MaximumBoardSize;
            //this.Flooding = ;
            //this.MineProbability = ;
        }

        public ICommand SwitchToStartScreen { get; }

        public ICommand SwitchToPlayScreen { get; }

        public int MinimumSlider { get; }
        public int MaximumSlider { get; }
        public bool Flooding { get; }
        public int MineProbability { get; }
    }
}
