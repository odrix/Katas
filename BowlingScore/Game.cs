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

        public void Roll(int nbPins)
        {
            _scoreTemporaire += nbPins;
            _nbRolls++;
            if (_nbRolls % 2 == 0)
                _score = _scoreTemporaire;
        }

        public int Score 
        { 
            get { return _score; }
        }
    }
}
