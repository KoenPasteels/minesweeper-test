﻿using Model.MineSweeper;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ViewModel;

namespace View.Screens
{
    /// <summary>
    /// Interaction logic for PlayScreen.xaml
    /// </summary>
    public partial class PlayScreen : UserControl
    {
        public PlayScreen()
        {
            InitializeComponent();

            var game = IGame.Parse(new List<string>
            {
                "..*..",
                ".*...",
                "*...*",
                ".....",
                "...*."
            });

            var gameViewModel = new GameViewModel(game);
            this.DataContext = gameViewModel;
        }
    }
}
