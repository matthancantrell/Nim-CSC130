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
        public AI_Player(): base() { }

        public AI_Player(PlayerName name): base(name) { }

        public AI_Player(PlayerName name, bool isTurn): base(name, isTurn) { }
    }
}
