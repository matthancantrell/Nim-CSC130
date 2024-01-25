namespace NIM;

public abstract class Player
{
    #region Internal Variables and Enums

    #region Playername Name Variable and Methods
    private PlayerName Name;
    public PlayerName getName() { return this.Name; }
    public void setName(PlayerName name) { this.Name = name; }
    #endregion

    #region Bool isTurn Variable and Methods
    private bool isTurn;
    public bool get_isTurn() { return this.isTurn; }
    public void set_isTurn(bool isTurn) {  this.isTurn = isTurn; }
    #endregion
    public enum PlayerName { P1, P2 }

    #endregion

    #region Contructors

    public Player() { }

    public Player(PlayerName playername)
    {
        this.Name = playername;
    }

    public Player(PlayerName name, bool isTurn)
    {
        setName(name);
        this.isTurn = isTurn;
    }

    #endregion
}