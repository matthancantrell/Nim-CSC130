using System.Windows;
using NIM;

namespace Windows
{
    public enum Opponent { Human, Computer }

    public partial class ChooseOpponentWindow : Window
    {
        public ChooseOpponentWindow()
        {
            InitializeComponent();
        }

        private void SwitchWindowPlayer(object sender, RoutedEventArgs e)
        {
            ChooseFirstWindow chooseFirst = new ChooseFirstWindow(Opponent.Human); // Makes An Intstance of ChooseFirstWindow
            chooseFirst.Show(); // Opens ChooseFirstWindow So User Can Select What Type Of Opponent They Will Play Against
            this.Close(); // Closes This Window To Hide It And Save Memory
        }

        private void SwitchWindowComputer(object sender, RoutedEventArgs e)
        {
            ChooseFirstWindow chooseFirst = new ChooseFirstWindow(Opponent.Computer); // Makes An Intstance of ChooseFirstWindow
            chooseFirst.Show(); // Opens ChooseFirstWindow So User Can Select What Type Of Opponent They Will Play Against
            this.Close(); // Closes This Window To Hide It And Save Memory
        }
    }
}
