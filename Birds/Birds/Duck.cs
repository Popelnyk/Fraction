using System;

namespace Birds.Birds
{
    public class Duck: Bird.Bird, IFlying.IFlying, ISwimming.ISwimming
    {
        public Duck(string name) : base(name, false, "brown")
        {
            Console.WriteLine("Duck initialized");
        }
        
        public Duck() : base() { Console.WriteLine("Duck initialized"); }
        
        public void IncreaseFlyingSpeed()
        {
            if (MovingSpeed + 5 <= 25)
            {
                Move(5);
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public void IncreaseSwimmingSpeed()
        {
            if (MovingSpeed + 4 <= 15)
            {
                Move(4);
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public void DecreaseFlyingSpeed()
        {
            if (MovingSpeed - 5 >= 0)
            {
                Move(-5);
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public void DecreaseSwimmingSpeed()
        {
            if (MovingSpeed - 4 >= 0)
            {
                Move(-4);
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}