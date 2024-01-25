using NIM;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace Windows
{
    /// <summary>
    /// Interaction logic for WindowGame.xaml
    /// </summary>
    public partial class WindowGame : Window
    {
        #region Internal Variables

        NIM.NimGame game;
        Button[][] stickpiles;
        bool isOver = false;
        List<Button> selectedButtons = new List<Button>();

        bool isFirstClick = false;
        int currentRow = 0;
        int prevRow = 0;

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
            updateTurnText();

            PlayGame();
            playagain.Visibility = Visibility.Hidden;
        }

        private void PlayGame()
        {
            if (isOver == false)
            {
                if (game.getCurrentPlayer().GetType().Name == "AI_Player")
                {
                    AI_TakeTurn();
                    ClickEndTurn();
                }
            }
        }

        private void ClickEndTurn()
        {
            RoutedEventArgs newEventArgs = new RoutedEventArgs(Button.ClickEvent);
            btn_EndTurn.RaiseEvent(newEventArgs);
        }

        public void InitializeArrays()
        {
            #region Initialize and Populate Button Arrays
            #region Row One
            rowOne = new Button[1];

            rowOne[0] = r1_s1;
            #endregion
            #region Row Two
            rowTwo = new Button[3];

            rowTwo[0] = r2_s1;
            rowTwo[1] = r2_s2;
            rowTwo[2] = r2_s3;
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

            stickpiles = new Button[][] { rowOne, rowTwo, rowThree, rowFour };

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

        private void updateTurnText()
        {
            txt_TurnDisplay.Text = getTurnText();
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
            btn.Background = Brushes.LawnGreen;

            if (!isFirstClick) { prevRow = currentRow; }
            currentRow = getRowOfButton(btn);

            if (currentRow != prevRow)
            {
                foreach (Button button in selectedButtons)
                {
                    button.Background = Brushes.White;
                    button.Content = null;
                }
                selectedButtons.Clear();
            }

            selectedButtons.Add(btn);
            btn.Content = ' ';
        }

        private int getRowOfButton(Button btn)
        {
            int i = 0;
            foreach (Object[] item in stickpiles)
            {
                i++;
                if (item.Contains(btn))
                {
                    break;
                }
            }

            return i;
        }

        private bool selectedButtonIsOnCurrentRow(Button btn)
        {
            return getRowOfButton(btn) == currentRow;
        }

        private void AI_TakeTurn()
        {
            Random rand = new Random();
            int rowToTakeFrom = rand.Next(1, 5);

            int potentialSticksToTake = 0;

            for (int i = 0; i < stickpiles[rowToTakeFrom - 1].Length; i++)
            {
                if (stickpiles[rowToTakeFrom - 1][i].Content != " ")
                {
                    potentialSticksToTake++;
                }
            }

            int sticksToTake = rand.Next(1, potentialSticksToTake + 1);

            for (int i = 0; i < sticksToTake; i++)
            {
                int button = -1;
                while (button == -1)
                {
                    int x = rand.Next(1, stickpiles[rowToTakeFrom - 1].Count()) - 1;
                    if (stickpiles[rowToTakeFrom - 1][x].Content == null)
                    {
                        Button btn = stickpiles[rowToTakeFrom - 1][x];
                        btn.Content = " ";
                        selectedButtons.Add(btn);
                        button = 1;
                    }
                }

            }
        }

        public bool isGameOver()
        {
            bool over = false;
            int x = 0;

            foreach (Button[] item in stickpiles)
            {
                foreach (Button btn in item)
                {
                    if (btn.Content == null)
                    {
                        over = false;
                    }
                    else
                    {
                        over = true;
                        x++;
                    }
                }
            }

            return x >= 16;
        }

        public void GameOver()
        {
            btn_EndTurn.Visibility = Visibility.Hidden;

            txt_TurnDisplay.Visibility = Visibility.Hidden;
            txt_WinnerDisplay.Visibility = Visibility.Visible;

            switch (game.getCurrentPlayer().getName())
            {
                case Player.PlayerName.P1:
                    {
                        txt_WinnerDisplay.Text = "Player One Wins!";
                        break;
                    }
                case Player.PlayerName.P2:
                    {
                        txt_WinnerDisplay.Text = "Player Two Wins!";
                        break;
                    }
            }

            playagain.Visibility = Visibility.Visible;
        }

        private void EndTurn_Click(object sender, RoutedEventArgs e)
        {
            if(selectedButtons.Count > 0)
            {
                foreach(Button button in selectedButtons)
                {
                    button.Visibility = Visibility.Hidden;
                }
                game.switchCurrentPlayer();
                updateTurnText();
                selectedButtons.Clear();
            }

            isOver = isGameOver();
            if (isOver)
            {
                GameOver();
            }
            else if (game.getCurrentPlayer().GetType().Name == "AI_Player")
            {
                AI_TakeTurn();
                ClickEndTurn();
            }
        }

        private void PlayAgain(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            this.Close();
        }
    }
}
