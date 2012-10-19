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
        private List<Frame> listFrame = new List<Frame>();


        public void Roll(int nbPins)
        {
            if (currentFrame == null)
                currentFrame = new Frame();
                        
            currentFrame.Roll(nbPins);
            _nbRolls++;
            if (_nbRolls % 2 == 0)
            {
                _score += currentFrame.Score;
                listFrame.Add(currentFrame);
                currentFrame = null;
            }
        }

        public int Score 
        { 
            get { return _score; }
        }
    }
}
