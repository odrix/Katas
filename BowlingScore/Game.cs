using System;
using System.Collections.Generic;
using System.Text;

namespace BowlingScore
{
    public class Game
    {
        private int _score = 0;
        private int _scoreTemporaire = 0;
        private int _nbRolls;

        private int nbPinRoll1;
        private int nbPinRoll2;

        public void Roll(int nbPins)
        {
            _scoreTemporaire += nbPins;
            _nbRolls++;
            if (_nbRolls % 2 == 0)
            {
                nbPinRoll2 = nbPins;
                if(nbPinRoll1 + nbPinRoll2 != 10) // is Spare
                    _score = _scoreTemporaire;
            }
            else
            {
                nbPinRoll1 = nbPins;
            }
        }

        public int Score 
        { 
            get { return _score; }
        }
    }
}
