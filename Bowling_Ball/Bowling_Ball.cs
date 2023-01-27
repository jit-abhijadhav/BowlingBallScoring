using Bowling_Ball.Helper;
using static Bowling_Ball.Interface.IBowlingBall;

namespace Bowling_Ball
{
    public class Bowling : IBowling
    {
        // Frame count
        private const int frameCount = 10;

        // 2 for first 9 frames and 3 for 10th frame
        private readonly int[] rolls = new int[21];

        /// <summary>
        /// Method to set bowling throws/rolls for each pin
        /// </summary>
        /// <param name="pins">Array of bowling Pins.</param>
        public void Roll(int[] pins)
        {
            for (int index = 0; index < pins.Length; index++)
            {
                rolls[index] = pins[index];
            }
        }

        /// <summary>
        /// Method to get final bowling score
        /// </summary>
        /// <returns>Returns final bowling score</returns>
        public int GetScore()
        {
            int frameIndex = 0;
            int bowlingScore = 0;

            // Total 10 frames
            for (int frame = 0; frame < frameCount; frame++)
            {
                if (BusinessHelper.CheckStrike(rolls[frameIndex]))
                {
                    bowlingScore += 10 + rolls[frameIndex + 1] + rolls[frameIndex + 2];
                    frameIndex++;
                }
                else if (BusinessHelper.CheckSpare(rolls[frameIndex], rolls[frameIndex + 1]))
                {
                    bowlingScore += 10 + rolls[frameIndex + 2];
                    frameIndex += 2;
                }
                else
                {
                    bowlingScore += rolls[frameIndex] + rolls[frameIndex + 1];
                    frameIndex += 2;
                }
            }
            return bowlingScore;
        }
    }
}
