using System;
using System.Collections.Generic;
using System.Text;

namespace BowlingScore
{
    public class Game
    {
        private int _nbRolls;

        private Frame currentFrame;
        private List<Frame> listFrame = new List<Frame>();


        public void Roll(int nbPins)
        {
            if (currentFrame == null)
                currentFrame = new Frame();
                        
            currentFrame.Roll(nbPins);

            if (listFrame.Count > 0 && listFrame[listFrame.Count - 1].IsSpare)
                listFrame[listFrame.Count - 1].AddBonus(nbPins);

            _nbRolls++;
            if (_nbRolls % 2 == 0)
            {
                listFrame.Add(currentFrame);
                currentFrame = null;
            }
        }

        public int Score 
        { 
            get 
            { 
                int _score = 0;
                foreach(Frame f in listFrame)
                {
                    _score += f.Score;
                }
                return _score;
            }
        }
    }
}
