using System;
using System.Collections.Generic;
using System.Text;

namespace BowlingScore
{
    public class Frame
    {
        private int nbPinRoll1 = 0;
        private int nbPinRoll2 = 0;

        private int _score = 0;

        public void Roll(int nbPins)
        {
            if (nbPinRoll1 == 0)
                nbPinRoll1 = nbPins;
            else
            {
                nbPinRoll2 = nbPins;
                if(!IsSpare)
                    _score = nbPinRoll1 + nbPinRoll2;
            }
        }

        public int Score
        {
            get { return _score; }
        }

        public bool IsSpare
        {
            get {return nbPinRoll1 + nbPinRoll2 == 10; }
        }
    }
}
