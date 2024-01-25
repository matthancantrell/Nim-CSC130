using Windows;
namespace NIM;

public class NimGame
{
    // private StickPile[] stickPiles = new StickPile[4];

    #region CurrentPlayer Variable and Methods
    private Player currentPlayer;
    public Player getCurrentPlayer() { return this.currentPlayer; }
    public void setCurrentPlayer(Player player) { this.currentPlayer = player; }
    public void switchCurrentPlayer()
    {
        switch(this.currentPlayer.getName())
        {
            case Player.PlayerName.P1:
                {
                    currentPlayer = playerTwo;

                    playerOne.set_isTurn(false);
                    playerTwo.set_isTurn(true);
                    break;
                }
            case Player.PlayerName.P2:
                {
                    currentPlayer = playerOne;

                    playerOne.set_isTurn(true);
                    playerTwo.set_isTurn(false);
                    break;
                }
        }
    }
    #endregion

    #region PlayerOne Variable and Methods
    private Player playerOne;
    public Player getPlayerOne() { return this.playerOne; }
    public void setPlayerOne(Player player) { this.playerOne = player; }
    #endregion

    #region PlayerTwo Variable and Methods
    private Player playerTwo { get; set; }
    public Player getPlayerTwo() { return this.playerTwo; }
    public void setPlayerTwo(Player player) { this.playerTwo = player; }
    #endregion

    public NimGame()
    {
        //InitiatePiles();
    }

    public NimGame(Player P1, Player P2, First first)
    {
        //InitiatePiles();

        playerOne = P1;
        playerTwo = P2;

        switch(first)
        {
            case First.P1:
                {
                    playerOne.set_isTurn(true);
                    playerTwo.set_isTurn(false);

                    setCurrentPlayer(playerOne);
                    break;
                }
            case First.P2:
                {
                    playerOne.set_isTurn(false);
                    playerTwo.set_isTurn(true);

                    setCurrentPlayer(playerTwo);
                    break;
                }
        }
    }

/*    private void InitiatePiles()
    {
        stickPiles[0] = new StickPile(1);
        stickPiles[1] = new StickPile(3);
        stickPiles[2] = new StickPile(5);
        stickPiles[3] = new StickPile(7);
    }*/

/*    public bool IsGameOver()
    {
        if (stickPiles[0].IsEmpty() && stickPiles[1].IsEmpty() && stickPiles[2].IsEmpty() && stickPiles[3].IsEmpty())
        {
            return true;
        }
        return false;
    }*/

    //starting with 1 for the pile with just 1 stick and ending with 4 for the pile with 7 sticks!
/*    public void PlayTurn(int pileNum, int stickNum)
    {
        try
        {
            switch (pileNum)
            {
                case 1:
                    if (stickNum == 1 && !stickPiles[0].IsEmpty())
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
                    if (stickNum > 0 && stickNum < 6 && !stickPiles[2].IsEmpty())
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
    }*/
}