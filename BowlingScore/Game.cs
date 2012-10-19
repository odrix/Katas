using System;
using System.Collections.Generic;
using System.Text;

namespace BowlingScore
{
    public class Game
    {
        private int _score = 0;
        private int _nbRolls;

        public void Roll(int nbPins)
        {
            _score += nbPins;
            _nbRolls++;
        }

        public int Score 
        { 
            get 
            {
                if (_nbRolls % 2 == 0)
                    return _score;
                else
                    return 0;
            }
        }
    }
}
