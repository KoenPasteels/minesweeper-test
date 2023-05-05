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

            var row1 = new List<string> { "a", "b", "c", "d", "e" };
            var row2 = new List<string> { "e", "f", "g", "h", "i" };
            var row3 = new List<string> { "j", "k", "l", "m", "n" };
            var grid = new List<List<string>> { row1, row2, row3 };

            this.boardView.ItemsSource = grid;
        }
    }
}
