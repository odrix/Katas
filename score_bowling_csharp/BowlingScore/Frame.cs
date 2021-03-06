using System;
using System.Collections.Generic;
using System.Text;

namespace BowlingScore
{
    public class Frame
    {
        private int? nbPinRoll1;
        private int? nbPinRoll2;

        private int? _Bonus1;
        private int? _Bonus2;

        private const int MAX_PIN_KNOCKDOWN = 10;

        public void Roll(int nbPins)
        {
            if (!nbPinRoll1.HasValue)
                nbPinRoll1 = nbPins;
            else
                nbPinRoll2 = nbPins;
        }

        public void AddBonus(int bonus)
        {
            if (!_Bonus1.HasValue)
                _Bonus1 = bonus;
            else if (!_Bonus2.HasValue)
                _Bonus2 = bonus;
        }

        public int Score
        {
            get
            {
                if (HaveTwoRolls)
                {
                    if (!IsSpare)
                        return nbPinRoll1.Value + nbPinRoll2.Value;
                    if (IsSpare && _Bonus1.HasValue)
                        return MAX_PIN_KNOCKDOWN + _Bonus1.Value;
                }
                else if (IsStrike && _Bonus1.HasValue && _Bonus2.HasValue)
                    return MAX_PIN_KNOCKDOWN + _Bonus1.Value + _Bonus2.Value;

                return 0;
            }
        }

        public bool IsSpare
        {
            get { return HaveTwoRolls && (nbPinRoll1.Value + nbPinRoll2.Value == MAX_PIN_KNOCKDOWN); }
        }

        public bool IsStrike
        {
            get { return nbPinRoll1.HasValue && nbPinRoll1.Value == MAX_PIN_KNOCKDOWN; }
        }

        public bool IsFinish
        {
            get { return HaveTwoRolls || IsStrike; }
        }

        private bool HaveTwoRolls
        {
            get { return nbPinRoll1.HasValue && nbPinRoll2.HasValue; }
        } 
    }
}
