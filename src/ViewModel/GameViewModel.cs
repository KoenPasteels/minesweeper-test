using Model.Data;
using Model.MineSweeper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ViewModel
{
    public class GameViewModel
    {
        private readonly IGame game;
        public GameBoardViewModel Board { get; }

        public GameViewModel(IGame igame)
        {
            this.game = igame;
            this.Board = new GameBoardViewModel(game.Board);
        }     
    }
}
