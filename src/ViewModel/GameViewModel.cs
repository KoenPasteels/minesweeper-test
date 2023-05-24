using Cells;
using Model.Data;
using Model.MineSweeper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text;
using System.Timers;
using System.Windows.Input;

namespace ViewModel
{
    public class GameViewModel : ScreenViewModel, INotifyPropertyChanged
    {
        protected ICell<IGame> game;
        public ICell<GameBoardViewModel> Board { get; }
        //public int BoardSize { get; set; }
        //public bool Flooding { get; }
        private static Timer timer;
        public event PropertyChangedEventHandler PropertyChanged;

        public GameViewModel(IGame igame, ICell<ScreenViewModel> currentScreen) : base(currentScreen)
        {
            if(timer != null) { timer.Stop(); }

            this.game = Cell.Create(igame);
            this.Board = game.Derive(g => new GameBoardViewModel(game));
            //this.BoardSize = Board.Value.Height;

            SwitchToSettingsScreen = new ActionCommand(() => CurrentScreen.Value = new SettingsScreenViewModel(this.CurrentScreen));
            //Debug.WriteLine("YOOO The var is: " + Board.Value.Height);
            //Debug.WriteLine("YOOO The size is: " + BoardSize);
            //StartNewGame = new ActionCommand(() => CurrentScreen.Value = new GameViewModel(IGame.CreateRandom(Board.Value.Height, 0.2, Flooding), this.CurrentScreen));

            this.StartTimer();
            //if(game.Value.Status != GameStatus.InProgress) { timer.Stop(); }
        }

        public ICommand SwitchToSettingsScreen { get; }
        public ICommand StartNewGame { get; }
        public double TimerInSeconds { get; set; }
        public ICell<GameStatus> GameStatus
        {
            get
            {
                return game.Derive(g => g.Status);
            }
        }

        private void StartTimer()
        {
            this.TimerInSeconds = 0;
            timer = new Timer(1000);
            timer.Elapsed += Timer_Elapsed;
            timer.Enabled = true;
            timer.AutoReset = true;
            timer.Start();
        }

        private void Timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            TimerInSeconds++;
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(TimerInSeconds)));
        }
    }
}
