using System.Windows;

namespace Windows
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

        public WindowGame(Opponent opponent, First first)
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
