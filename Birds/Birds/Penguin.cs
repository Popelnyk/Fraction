using System;

namespace Birds.Birds
{
    public class Penguin : Bird.Bird, ISwimming.ISwimming
    {
        public Penguin(string name) : base(name, false, "white")
        {
            Console.WriteLine("Penguin initialized");
        }

        public Penguin() : base() { Console.WriteLine("Penguin initialized"); }
        
        public void IncreaseSwimmingSpeed()
        {
            if (MovingSpeed + 2 <= 20)
            {
                Move(2);
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public void DecreaseSwimmingSpeed()
        {
            if (MovingSpeed - 2 >= 0)
            {
                Move(-2);
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}