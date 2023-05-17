using Cells;
using Model.Data;
using Model.MineSweeper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace ViewModel
{
    public class GameViewModel : ScreenViewModel
    {
        protected ICell<IGame> game;
        public ICell<GameBoardViewModel> Board { get; }
        //public bool Flooding { get; }

        public GameViewModel(IGame igame, ICell<ScreenViewModel> currentScreen) : base(currentScreen)
        {
            this.game = Cell.Create(igame);
            this.Board = game.Derive(g => new GameBoardViewModel(game));
            var boardSize = Board.Value.Height;

            SwitchToSettingsScreen = new ActionCommand(() => CurrentScreen.Value = new GameViewModel(IGame.CreateRandom(boardSize, 0.2, true), this.CurrentScreen));
        }

        public ICommand SwitchToSettingsScreen { get; }
    }
}
