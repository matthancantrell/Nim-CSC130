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

namespace NIM_CSC130
{
    /// <summary>
    /// Interaction logic for ChooseFirstWindow.xaml
    /// </summary>
    /// 

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
            WindowGame game = new WindowGame();
            Console.WriteLine("<-- GAME -->");
            game.Show();
            this.Close();
        }

        private void PlayerTwoFirst(object sender, RoutedEventArgs e)
        {
            WindowGame game = new WindowGame();
            game.Show();
            this.Close();
        }
    }
}
