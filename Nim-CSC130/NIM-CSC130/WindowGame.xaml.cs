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

namespace NIM_CSC130
{
    /// <summary>
    /// Interaction logic for WindowGame.xaml
    /// </summary>
    public partial class WindowGame : Window
    {
        private bool isPlayer = false;
       
        public WindowGame()
        {
            InitializeComponent();
        }

        ///<summary>
        /// Interaction logic for the player turn
        /// Uses boolean and when button is activated it switches true or false for non computer player
        ///</summary>
        private void PlayerTurn()
        {
            if (isPlayer == true)
            {
                txt_TurnDisplay.Text = "Player turn: Player";
            }
            else
            {
                txt_TurnDisplay.Text = "Player Turn: AI";
            }
        }

        void OnEndTurn (object sender, EventArgs e)
        {
            isPlayer = true;
            
        }
    }
}
