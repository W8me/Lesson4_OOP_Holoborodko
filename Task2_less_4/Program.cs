using System;

namespace Task2_less_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Player player = new Player();

            IRecodable player2 = player as IRecodable;
            player2.Record();
            player2.Pause();
            player2.Stop();

            IPlayable player1 = player as IPlayable;
            player1.Play();
            player1.Pause();
            player1.Stop();

        

        }
    }
}
