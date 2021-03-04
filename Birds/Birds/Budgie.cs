using System;

namespace Birds.Birds
{
    public class Budgie : Bird.Bird, IFlying.IFlying
    {
        public Budgie(string name, string color) : base(name, false, color)
        {
            Console.WriteLine("Budgie initialized");
        }
        
        public Budgie() : base() { Console.WriteLine("Budgie initialized"); }
        
        public void IncreaseFlyingSpeed()
        {
            if (MovingSpeed + 10 <= 50)
            {
                Move(10);
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public void DecreaseFlyingSpeed()
        {
            if (MovingSpeed - 10 >= 0)
            {
                Move(-10);
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }
    }
}