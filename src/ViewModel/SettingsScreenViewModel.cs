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
            SwitchToPlayScreen = new ActionCommand(() => CurrentScreen.Value = new GameViewModel(IGame.CreateRandom(BoardSize.Value, MineProbability.Value, Flooding), CurrentScreen));

            this.BoardSize = Cell.Create(5);
            this.MineProbability = Cell.Create(0.1);
            this.MinimumBoardsize = IGame.MinimumBoardSize;
            this.MaximumBoardsize = IGame.MaximumBoardSize;
            this.MinimumMineProbability = 0.1;
            this.MaximumMineProbability = 0.5;

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
        public double MinimumMineProbability { get; }
        public double MaximumMineProbability { get; }
        public ICell<double> MineProbability { get; set; }
    }
}
