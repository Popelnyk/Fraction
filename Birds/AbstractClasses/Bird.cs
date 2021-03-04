using System;

namespace Bird
{
    public abstract class Bird
    {
#nullable enable
        private readonly string? _name;
        private readonly string? _color;
        private readonly bool? _isPredator;
#nullable disable

        protected int MovingSpeed { get; private set; }
        
        protected Bird()
        {
            _name = null;
            _color = null;
            _isPredator = null;
            MovingSpeed = 0;
        }
        
        protected Bird(string name, bool isPredator, string color)
        {
            _name = name;
            _color = color;
            _isPredator = isPredator;
            MovingSpeed = 0;
        }

        protected void Move(int speed)
        {
            MovingSpeed += speed;
        }
        
        public void GetInfo()
        {
            Console.WriteLine($"Name: {_name}, color: {_color}, type: {(_isPredator is true ? "Predator": "Herbivore")}");
        }
    }
}