using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIM
{
    public class Human_Player : Player
    {
        Human_Player() : base() { }
        Human_Player(PlayerName name, bool isTurn) : base(name, isTurn) { }
    }
}
