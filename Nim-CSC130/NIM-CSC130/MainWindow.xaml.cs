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

namespace NIM_CSC130
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        WindowGame gameWindow = new WindowGame();
        MainWindow mainWindow = new MainWindow();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SwitchWindow(object sender, RoutedEventArgs e)
        {

            if (StartPlayer1Button.IsPressed == true) { gameWindow.txt_TurnDisplay.Text = "Player 1 Turn"; gameWindow.IsPlayerTurn = true; }
            if (StartPlayer2Button.IsPressed == true) { gameWindow.txt_TurnDisplay.Text = "Player 2 Turn"; gameWindow.IsPlayerTurn = false; }
           
            gameWindow.Show();
        }
    }
}