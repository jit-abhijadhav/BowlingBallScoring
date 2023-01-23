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
            /// Method to set bowling throws for each pin
            /// </summary>
            /// <param name="bowlingPins">Array of bowling Pins.</param>
            void SetBowlingThrows(int[] bowlingPins);

            /// <summary>
            /// Method to get total bowling score
            /// </summary>
            /// <returns>Returns total bowling score</returns>
            int GetFinalScore();
        }
    }
}
