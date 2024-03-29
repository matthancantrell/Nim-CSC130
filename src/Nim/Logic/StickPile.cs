﻿namespace NIM;

public class StickPile
{
    public int NumberOfSticks { get; private set; }

    public StickPile(int initialSticks)
    {
        NumberOfSticks = initialSticks;
    }

    public bool IsEmpty()
    {
        return NumberOfSticks == 0;
    }

    public void RemoveSticks(int count)
    {
        NumberOfSticks -= count;
    }
}
