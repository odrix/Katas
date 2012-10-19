using System;
using System.Collections.Generic;
using System.Text;

namespace BowlingScore
{
    public class Game
    {
        private int _score = -1;

        public void Roll(int nbPins)
        {
            _score = 0;
        }

        public int Score { get { return _score; } }
    }
}
