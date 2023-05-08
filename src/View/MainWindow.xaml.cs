using Model.Data;
using Model.MineSweeper;
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

            var board = Rows(game.Board);
            this.DataContext = board;
        }

        IEnumerable<Square> Row(IGameBoard board, int row)
        {
            var squares = new List<Square>();
            var width = board.Width;

            for(int i=0; i<width; i++)
            {
                var pos = new Vector2D(row, i);
                var square = board[pos];
                squares.Add(square);
            }

            return squares;
        }

        IEnumerable<IEnumerable<Square>> Rows(IGameBoard board)
        {
            var rows = new List<IEnumerable<Square>>();
            var height = board.Height;

            for(int i=0; i<height; i++)
            {
                var row = Row(board, i);
                rows.Add(row);
            }

            return rows;
        }
    }
}
