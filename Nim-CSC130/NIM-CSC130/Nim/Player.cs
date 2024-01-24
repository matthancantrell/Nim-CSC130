public class Player
{
    public string Name { get; }

    private int sticksPulled;

    public Player(string name)
    {
        Name = name;
        sticksPulled = 0;
    }

    public void AddStick(int sticksAdded)
    {
        sticksPulled += sticksAdded;
    }

    public int GetSticksPulled() { return sticksPulled; }

    public void ResetSticksPulled() { sticksPulled = 0; }
}