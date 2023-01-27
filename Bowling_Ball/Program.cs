using Unity;
using static Bowling_Ball.Interface.IBowlingBall;

namespace Bowling_Ball
{
    /// <summary>
    /// Program Class
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Could you please enter rolls:");

            // 2 for first 9 frames and 3 for 10th frame.
            int[] bowlingPins = new int[21];

            for (int index = 0; index < bowlingPins.Length; index++)
            {
                if (int.TryParse(Console.ReadLine(), out int value))
                {
                    bowlingPins[index] = value;
                }
            }

            // Unity container to get instance of Bowling ball.
            IUnityContainer container = new UnityContainer();
            container.RegisterType<IBowling, Bowling>();
            IBowling bowling = container.Resolve<IBowling>();

            bowling.Roll(bowlingPins);

            int finalScore = bowling.GetScore();

            Console.WriteLine("Final bowling score is:" + finalScore.ToString());
            Console.ReadKey();
        }
    }
}