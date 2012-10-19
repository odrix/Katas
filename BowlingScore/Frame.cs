using System;
using System.Collections.Generic;
using System.Text;

namespace BowlingScore
{
    public class Frame
    {
        private int? nbPinRoll1;
        private int? nbPinRoll2;

        private int _Bonus;

        public void Roll(int nbPins)
        {
            if (!nbPinRoll1.HasValue)
                nbPinRoll1 = nbPins;
            else
                nbPinRoll2 = nbPins;
        }

        public int Score
        {
            get
            {
                if (IsFinish)
                {
                    if (!IsSpare)
                        return nbPinRoll1.Value + nbPinRoll2.Value;
                    if (IsSpare && _Bonus != 0)
                        return nbPinRoll1.Value + nbPinRoll2.Value + _Bonus;
                }

                return 0;
            }
        }

        public void AddBonus(int bonus)
        {
            _Bonus = bonus;
        }

        public bool IsSpare
        {
            get { return IsFinish && nbPinRoll1.Value + nbPinRoll2.Value == 10; }
        }

        public bool IsFinish
        {
            get { return nbPinRoll1.HasValue && nbPinRoll2.HasValue; }
        }
    }
}
