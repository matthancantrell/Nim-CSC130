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
using System.Windows.Shapes;
using NIM;

namespace Windows
{
    /// <summary>
    /// Interaction logic for ChooseFirstWindow.xaml
    /// </summary>
    /// 

    public enum First { P1, P2 }

    public partial class ChooseFirstWindow : Window
    {
        private Opponent opponent;

        public ChooseFirstWindow()
        {
            InitializeComponent();
        }

        public ChooseFirstWindow(Opponent opponent)
        {
            this.opponent = opponent;
            InitializeComponent();
        }

        private void PlayerOneFirst(object sender, RoutedEventArgs e)
        {
            WindowGame game = new WindowGame(opponent, First.P1);
            game.Show();
            this.Close();
        }

        private void PlayerTwoFirst(object sender, RoutedEventArgs e)
        {
            WindowGame game = new WindowGame(opponent, First.P2);
            game.Show();
            this.Close();
        }
    }
}
