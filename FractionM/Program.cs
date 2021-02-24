using System;
using Fraction;

namespace Fraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction obj = new Fraction(1, 5);
            Fraction obj1 = new Fraction(7, 1948);
            Fraction obj2 = new Fraction(obj);
            Fraction obj3 = new Fraction(1000);


            Fraction obj4 = obj + obj1;
            Fraction obj5 = obj - obj1;
            Fraction obj6 = obj / obj1;
            Fraction obj7 = obj * obj1;
            
            Console.WriteLine(obj.Equals(obj1));
            Console.WriteLine(obj2.Equals(obj));
            Console.WriteLine($"{obj7.Numerator}, {obj7.Denominator}");
            Console.WriteLine(obj > obj5);
            Console.WriteLine(obj5 < obj6);
            Console.WriteLine(obj == obj2);
            Console.WriteLine(obj1 == obj5);
            Console.WriteLine(obj != obj5);
            
            obj3 = obj;
            Console.WriteLine($"{obj3.Numerator}, {obj3.Denominator} : {obj.Numerator}, {obj.Denominator}");
        }
    }
}