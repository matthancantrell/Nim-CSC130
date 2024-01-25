using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NIM
{
    public class Human_Player : Player
    {
        public Human_Player() : base() { }

        public Human_Player(PlayerName name) : base(name) { }

        public Human_Player(PlayerName name, bool isTurn) : base(name, isTurn) { }

        public override void TakeTurn() { }
    }
}
