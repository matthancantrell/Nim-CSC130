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

namespace Windows
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SwitchWindow(object sender, RoutedEventArgs e)
        {
            ChooseOpponentWindow chooseOpponent = new ChooseOpponentWindow(); // Makes An Intstance of ChooseOpponentWindow
            chooseOpponent.Show(); // Opens ChooseOpponentWindow So User Can Select What Type Of Opponent They Will Play Against
            this.Close(); // Closes This Window To Hide It And Save Memory
        }
    }
}