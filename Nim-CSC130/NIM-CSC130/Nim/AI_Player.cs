using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace NIM
{
    public class AI_Player: Player
    {
        AI_Player(): base() { }
        AI_Player(PlayerName name, bool isTurn): base(name, isTurn) { }
    }
}
