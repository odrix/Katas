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

        private Frame currentFrame;


        public void Roll(int nbPins)
        {
            if (currentFrame == null)
                currentFrame = new Frame();

            _scoreTemporaire += nbPins;
            currentFrame.Roll(nbPins);
            _nbRolls++;
            if (_nbRolls % 2 == 0)
            {
                if(!currentFrame.IsSpare) // is Spare
                    _score = _scoreTemporaire;
                currentFrame = null;
            }
        }

        public int Score 
        { 
            get { return _score; }
        }
    }
}
