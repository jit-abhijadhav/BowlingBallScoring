namespace Bowling_Ball.Interface
{
    public interface IBowlingBall
    {
        /// <summary>
        /// Interface For bowling ball class
        /// </summary>
        public interface IBowling
        {
            /// <summary>
            /// Method to set bowling throws/rolls for each pin
            /// </summary>
            /// <param name="pins">Array of bowling Pins.</param>
            void Roll(int[] pins);

            /// <summary>
            /// Method to get total bowling score
            /// </summary>
            /// <returns>Returns total bowling score</returns>
            int GetScore();
        }
    }
}
