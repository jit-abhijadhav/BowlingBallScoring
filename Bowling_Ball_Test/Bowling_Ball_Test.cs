using Bowling_Ball;

namespace Bowling_Ball_Test
{
    [Collection("Sequential")]
    public class Bowling_Ball_Test
    {
        /// <summary>
        /// Test Bowling ball with no spare and no strike.
        /// </summary>
        [Fact]
        public void BowlingBallNoSpareStrike_Test()
        {
            var bowling = new Bowling();
            bowling.SetBowlingThrows(new int[] { 2, 2, 3, 5, 5, 0, 4, 1, 3, 1, 5, 2, 7, 1, 3, 5, 2, 1, 6, 2 });
            Assert.Equal(60, bowling.GetFinalScore());
        }

        /// <summary>
        /// Test Bowling ball with two strikes at final frame.
        /// </summary>
        [Fact]
        public void BowlingBallTwoStrikes_Test()
        {
            var bowling = new Bowling();
            bowling.SetBowlingThrows(new int[] { 5, 2, 3, 5, 5, 0, 4, 1, 9, 1, 5, 1, 7, 1, 10, 5, 2, 10, 10, 2 });
            Assert.Equal(100, bowling.GetFinalScore());
        }

        /// <summary>
        /// Test Bowling ball with spare and strike at final frame.
        /// </summary>
        [Fact]
        public void BowlingSpareStrikeAtEnd_Test()
        {
            var bowling = new Bowling();
            bowling.SetBowlingThrows(new int[] { 3, 5, 7, 3, 10, 1, 7, 5, 2, 6, 3, 7, 3, 6, 2, 10, 9, 1, 10 });
            Assert.Equal(134, bowling.GetFinalScore());
        }

        /// <summary>
        /// Test Bowling ball with perfect game.
        /// </summary>
        [Fact]
        public void BowlingBallPerfectGame_Test()
        {
            var bowling = new Bowling();
            bowling.SetBowlingThrows(new int[] { 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10, 10 });

            // 300 is perfect game score.
            Assert.Equal(300, bowling.GetFinalScore());
        }
    }
}