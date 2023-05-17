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
            //SwitchToPlayScreen = new ActionCommand(() => CurrentScreen.Value = new PlayScreenViewModel(this.CurrentScreen, boardsize, mineprobability, flooding));
            
            this.MinimumBoardsize = IGame.MinimumBoardSize;
            this.MaximumBoardsize = IGame.MaximumBoardSize;
            //this.MineProbability = ;
        }

        public ICommand SwitchToPlayScreen { get; }

        public int MinimumBoardsize { get; }
        public int MaximumBoardsize { get; }
        public bool Flooding { get; set; }
        //public int MineProbability { get; }
    }
}
