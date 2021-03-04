using System;

namespace Birds.Birds
{
    public class Kiwi : Bird.Bird, IFlying.IFlying
    {
        public Kiwi(string name) : base(name, false, "green")
        {
            Console.WriteLine("Kiwi initialized");
        }

        public Kiwi() : base() { Console.WriteLine("Kiwi initialized"); }
        
        public void IncreaseFlyingSpeed()
        {
            if (MovingSpeed + 11 <= 28)
            {
                Move(11);
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public void DecreaseFlyingSpeed()
        {
            if (MovingSpeed - 11 >= 0)
            {
                Move(- 11);
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}