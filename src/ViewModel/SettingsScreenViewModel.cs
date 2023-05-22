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
            SwitchToPlayScreen = new ActionCommand(() => CurrentScreen.Value = new GameViewModel(IGame.CreateRandom(BoardSize.Value, 0.2, Flooding), CurrentScreen));

            this.BoardSize = Cell.Create(5);
            this.MinimumBoardsize = IGame.MinimumBoardSize;
            this.MaximumBoardsize = IGame.MaximumBoardSize;
            //this.MineProbability = 0.2;

            Start5 = new ActionCommand(() => CurrentScreen.Value = new GameViewModel(IGame.CreateRandom(5, 0.2, true), CurrentScreen));
            Start10 = new ActionCommand(() => CurrentScreen.Value = new GameViewModel(IGame.CreateRandom(10, 0.2, true), CurrentScreen));
            Start20 = new ActionCommand(() => CurrentScreen.Value = new GameViewModel(IGame.CreateRandom(20, 0.2, true), CurrentScreen));
        }

        public ICommand SwitchToPlayScreen { get; }
        public ICommand Start5 { get; }
        public ICommand Start10 { get; }
        public ICommand Start20 { get; }

        public int MinimumBoardsize { get; }
        public int MaximumBoardsize { get; }
        public ICell<int> BoardSize { get; set; }
        public bool Flooding { get; set; }
        //public int MineProbability { get; }
    }
}
