using NIM;
using System.Windows;
using System.Windows.Controls;

namespace Windows
{
    /// <summary>
    /// Interaction logic for WindowGame.xaml
    /// </summary>
    public partial class WindowGame : Window
    {
        #region Internal Variables

        NIM.NimGame game;
        Object[] stickpiles;
        bool isOver = false;

        #region Button Arrays
        Button[] rowOne;
        Button[] rowTwo;
        Button[] rowThree;
        Button[] rowFour;
        #endregion

        #endregion

        public WindowGame()
        {
            InitializeComponent();
        }

        public WindowGame(Opponent opponent, First first)
        {
            InitializeComponent();
            InitializeArrays();

            #region Initialize Game Variable Based On Opponent Type
            switch (opponent)
            {
                case Opponent.Human:
                    {
                        game = new NimGame(new Human_Player(Player.PlayerName.P1), new Human_Player(Player.PlayerName.P2), first);
                        break;
                    }
                case Opponent.Computer:
                    {
                        game = new NimGame(new Human_Player(Player.PlayerName.P1), new AI_Player(Player.PlayerName.P2), first);
                        break;
                    }
            }
            #endregion

            txt_WinnerDisplay.Visibility = Visibility.Hidden;
            txt_TurnDisplay.Text = getTurnText();
        }

        public void InitializeArrays()
        {
            stickpiles = new Object[4];

            #region Initialize and Populate Button Arrays
            #region Row One
            rowOne = new Button[1];

            rowOne[0] = r1_s1;
            #endregion
            #region Row Two
            rowTwo = new Button[3];

            rowTwo[0] = r2_s1;
            rowTwo[1] = r2_s2;
            #endregion
            #region Row Three
            rowThree = new Button[5];

            rowThree[0] = r3_s1;
            rowThree[1] = r3_s2;
            rowThree[2] = r3_s3;
            rowThree[3] = r3_s4;
            rowThree[4] = r3_s5;
            #endregion
            #region Row Four
            rowFour = new Button[7];

            rowFour[0] = r4_s1;
            rowFour[1] = r4_s2;
            rowFour[2] = r4_s3;
            rowFour[3] = r4_s4;
            rowFour[4] = r4_s5;
            rowFour[5] = r4_s6;
            rowFour[6] = r4_s7;
            #endregion
            #endregion

            #region Populate Object Array
            stickpiles[0] = rowOne;
            stickpiles[1] = rowTwo;
            stickpiles[2] = rowThree;
            stickpiles[3] = rowFour;
            #endregion
        }

        ///<summary>
        /// Interaction logic for the player turn
        /// Uses boolean and when button is activated it switches true or false for non computer player
        ///</summary>
/*        private void PlayerTurn()
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
            
        }*/

        private void PlayGame()
        {

        }

        private string getTurnText()
        {
            string str = "";
            switch(game.getCurrentPlayer().getName())
            {
                case Player.PlayerName.P1:
                    {
                        str = "Player One's Turn!";
                        break;
                    }
                case Player.PlayerName.P2: 
                    {
                        str = "Player Two's Turn!";
                        break;
                    }
            }
            return str;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            int i = 0;
            foreach (Object[] item in stickpiles)
            {
                i++;
                if (item.Contains(btn))
                {
                    txt_TurnDisplay.Text = "Button in row: " + i;
                }
            }
        }
    }
}
