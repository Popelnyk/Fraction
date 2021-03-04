using System;
using Birds;
using Birds.Birds;
using Bird;

namespace Birds
{
    class Program
    {
        static void Main(string[] args)
        {
            Kiwi obj = new Kiwi("Doi");
            Duck obj2 = new Duck();
            Penguin obj3 = new Penguin();
            Budgie obj4 = new Budgie("FoFo", "Silver");
            
            obj.IncreaseFlyingSpeed();
            obj.DecreaseFlyingSpeed();
            obj.IncreaseFlyingSpeed();
            obj.IncreaseFlyingSpeed();
            obj.GetInfo();
            
            obj2.GetInfo();
            obj2.IncreaseFlyingSpeed();
            obj2.IncreaseFlyingSpeed();
            obj2.IncreaseFlyingSpeed();
            obj2.GetInfo();

            try
            {
                obj3.DecreaseSwimmingSpeed();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            obj4.GetInfo();
            obj4.IncreaseFlyingSpeed();
            obj4.GetInfo();
        }
    }
}