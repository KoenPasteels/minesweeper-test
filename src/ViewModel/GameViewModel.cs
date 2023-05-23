using Cells;
using Model.Data;
using Model.MineSweeper;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;
using System.Windows.Input;

namespace ViewModel
{
    public class GameViewModel : ScreenViewModel
    {
        protected ICell<IGame> game;
        public ICell<GameBoardViewModel> Board { get; }
        //public int BoardSize { get; set; }
        //public bool Flooding { get; }

        public GameViewModel(IGame igame, ICell<ScreenViewModel> currentScreen) : base(currentScreen)
        {
            this.game = Cell.Create(igame);
            this.Board = game.Derive(g => new GameBoardViewModel(game));
            //this.BoardSize = Board.Value.Height;

            SwitchToSettingsScreen = new ActionCommand(() => CurrentScreen.Value = new SettingsScreenViewModel(this.CurrentScreen));
            //Debug.WriteLine("YOOO The var is: " + Board.Value.Height);
            //Debug.WriteLine("YOOO The size is: " + BoardSize);
            //StartNewGame = new ActionCommand(() => CurrentScreen.Value = new GameViewModel(IGame.CreateRandom(Board.Value.Height, 0.2, Flooding), this.CurrentScreen));
        }

        public ICommand SwitchToSettingsScreen { get; }
        public ICommand StartNewGame { get; }
    }
}
