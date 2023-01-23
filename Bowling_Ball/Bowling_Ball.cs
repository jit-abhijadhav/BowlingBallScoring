using Bowling_Ball.Helper;
using static Bowling_Ball.Interface.IBowlingBall;

namespace Bowling_Ball
{
    public class Bowling : IBowling
    {
        // Total frame count
        private const int frameCount = 10;

        // 2 for first 9 frames and 3 for 10th frame
        private readonly int[] throws = new int[21];

        /// <summary>
        /// Method to set bowling throws for each pin
        /// </summary>
        /// <param name="bowlingPins">Array of bowling Pins.</param>
        public void SetBowlingThrows(int[] bowlingPins)
        {
            for (int index = 0; index < bowlingPins.Length; index++)
            {
                throws[index] = bowlingPins[index];
            }
        }

        /// <summary>
        /// Method to get final bowling score
        /// </summary>
        /// <returns>Returns final bowling score</returns>
        public int GetFinalScore()
        {
            int frameIndex = 0;
            int bowlingScore = 0;

            // Total 10 frames
            for (int frame = 0; frame < frameCount; frame++)
            {
                if (BusinessHelper.CheckStrike(throws[frameIndex]))
                {
                    bowlingScore += 10 + throws[frameIndex + 1] + throws[frameIndex + 2];
                    frameIndex++;
                }
                else if (BusinessHelper.CheckSpare(throws[frameIndex], throws[frameIndex + 1]))
                {
                    bowlingScore += 10 + throws[frameIndex + 2];
                    frameIndex += 2;
                }
                else
                {
                    bowlingScore += throws[frameIndex] + throws[frameIndex + 1];
                    frameIndex += 2;
                }
            }
            return bowlingScore;
        }
    }
}
