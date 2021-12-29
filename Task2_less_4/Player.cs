using System;
using System.Collections.Generic;
using System.Text;

namespace Task2_less_4
{
    class Player : IPlayable,IRecodable
    {
        public void Play()
        {
            Console.WriteLine("Воспроизводится запись");
        }

        public void Record()
        {
            Console.WriteLine("Запись началась");
        }
        public void Pause()
        {
            Console.WriteLine("На паузе");
        }

        public void Stop()
        {
            Console.WriteLine("Остановлено");
            Console.WriteLine(  new string ('-', 20));
        }
    }
}
