using Model.Data;
using Model.MineSweeper;
using ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
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

            var uncover = new Vector2D(0, 0);
            var flag = new Vector2D(0, 2);
            var mine = new Vector2D(1, 1);

            game = game.UncoverSquare(uncover);
            game = game.ToggleFlag(flag);
            game = game.UncoverSquare(new Vector2D(1, 2));
            game = game.UncoverSquare(mine);

            var gameViewModel = new GameViewModel(game);
            this.DataContext = gameViewModel;
        }

        
    }
}
