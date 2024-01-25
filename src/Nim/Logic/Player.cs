namespace NIM;

public abstract class Player
{
    public PlayerName Name { get; set; }
    public bool isTurn { get; set; }
    public enum PlayerName { P1, P2 }

    public Player() { }
    public Player(PlayerName playername)
    {
        this.Name = playername;
    }
    public Player(PlayerName name, bool isTurn)
    {
        this.Name = name;
        this.isTurn = isTurn;
    }

    public void setTurn(bool isTurn)
    {
        this.isTurn = isTurn;
    }
}