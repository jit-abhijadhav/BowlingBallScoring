namespace Bowling_Ball.Helper
{
    public class BusinessHelper
    {
        /// <summary>
        /// Method to check if throw/roll is strike.
        /// </summary>
        /// <param name="currentIndexValue">Current Index Value.</param>
        /// <returns>Returns true if throw is strike otherwise false.</returns>
        public static bool CheckStrike(int currentIndexValue)
        {
            return currentIndexValue == 10;
        }

        /// <summary>
        /// Method to check if throw/roll is spare
        /// </summary>
        /// <param name="currentIndexValue">Current index value.</param>
        /// <param name="nextIndexValue">Next index value.</param>
        /// <returns>Returns true if throw is spare otherwise false.</returns>
        public static bool CheckSpare(int currentIndexValue, int nextIndexValue)
        {
            return currentIndexValue + nextIndexValue == 10;
        }
    }
}
