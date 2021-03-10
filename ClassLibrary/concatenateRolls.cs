using System;

namespace ClassLibrary
{
    public class concatenateRolls
    {
        public static int Fiverolls()
        {
            int fiveDigitNum = Convert.ToInt32(string.Format("{0}{1}{2}{3}{4}", DiceRoll.D6(), DiceRoll.D6(), DiceRoll.D6(), DiceRoll.D6(), DiceRoll.D6()));
            return fiveDigitNum;
        }
    }
}
