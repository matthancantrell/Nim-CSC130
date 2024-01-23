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
        private bool isPlayerTurn;
        public bool endGame = true; // Player1 == true, Player2 == false

        public bool IsPlayerTurn { get; internal set; }

        public WindowGame()
        {
            InitializeComponent();
        }

        ///<summary>
        /// Interaction logic for the player turn
        /// Uses boolean and when button is activated it switches true or false for other player
        ///</summary>
        private void PlayerTurn()
        {
            if (isPlayerTurn)
            {
                txt_TurnDisplay.Text = "Player 1 Turn";
            }
            else if (!isPlayerTurn)
            {
                txt_TurnDisplay.Text = "Player 2 Turn";
            }

        }

        void OnEndTurn(object sender, EventArgs e)
        {
            //while (endGame != false)
            {
                switch (isPlayerTurn)
                {
                    case true:
                        PlayerTurn();
                        isPlayerTurn = false;
                        break;
                    case false:
                        PlayerTurn();
                        isPlayerTurn = true;
                        break;

                }

            }


        }
    }
}
