namespace NIM
{
    public class NimGame
    {
        private StickPile[] stickPiles = new StickPile[4];
        private Player currentPlayer;
        private Player playerOne;
        private Player playerTwo;

        public NimGame()
        {
            InitiatePiles();
        }

        public NimGame(string player1Name, string player2Name)
        {
            InitiatePiles();
            playerOne = new Player(player1Name);
            playerTwo = new Player(player2Name);
            currentPlayer = playerOne;
        }

        public NimGame(Player P1, Player P2, First first)
        {
            InitiatePiles();

            playerOne = P1;
            playerTwo = P2;

            switch (first):
            case First.P1:
                {
                    playerOne.SetTurn(true);
                    playerTwo.SetTurn(false);

                    currentPlayer = playerOne;
                    break;
                }
            case First.P2:
                {
                    playerOne.SetTurn(false);
                    playerTwo.SetTurn(true);

                    currentPlayer = playerTwo;
                    break;
                }
            }

            private void InitiatePiles()
            {
                stickPiles[0] = new StickPile(1);
                stickPiles[1] = new StickPile(3);
                stickPiles[2] = new StickPile(5);
                stickPiles[3] = new StickPile(7);
            }

            public bool IsGameOver()
            {
                if (stickPiles[0].isEmpty() && stickPiles[1].isEmpty() && stickPiles[2].isEmpty() && stickPiles[3].isEmpty())
                {
                    return true;
                }
                return false;
            }

            //starting with 1 for the pile with just 1 stick and ending with 4 for the pile with 7 sticks!
            public void PlayTurn(int pileNum, int stickNum)
            {
                try
                {
                    switch (pileNum)
                    {
                        case 1:
                            if (stickNum == 1 && !stickPiles[0].isEmpty())
                            {
                                stickPiles[0].RemoveSticks(stickNum);
                                currentPlayer.AddStick(stickNum);
                                break;
                            }
                            else throw new ArgumentException("Invalid Input");
                        case 2:
                            if (stickNum > 0 && stickNum < 4 && !stickPiles[1].isEmpty())
                            {
                                stickPiles[1].RemoveSticks(stickNum);
                                currentPlayer.AddStick(stickNum);
                                break;
                            }
                            else throw new ArgumentException("Invalid Input");
                        case 3:
                            if (stickNum > 0 && stickNum < 6 && !stickPiles[2].isEmpty())
                            {
                                stickPiles[2].RemoveSticks(stickNum);
                                currentPlayer.AddStick(stickNum);
                                break;
                            }
                            else throw new ArgumentException("Invalid Input");
                        case 4:
                            if (stickNum > 0 && stickNum < 8 && !stickPiles[3].isEmpty())
                            {
                                stickPiles[3].RemoveSticks(stickNum)
                                    currentPlayer.AddStick(stickNum);
                                break;
                            }
                            else throw new ArgumentException("Invalid Input");
                        default:
                            throw new ArgumentException("Invalid Input");
                    }
                    if (currentPlayer == playerOne)
                    {
                        currentPlayer = playerTwo;
                    }
                    else
                    {
                        currentPlayer = playerOne;
                    }
                }
                catch (ArgumentException e)
                {
                    //insert any other error logic for UI here
                    Console.WriteLine(e.Message);
                }
            }
        }
    }
}