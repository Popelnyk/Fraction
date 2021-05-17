using System;
using System.Threading;
using ClassPrintMessage;
namespace main
{
    class Program
    {
        static void CheckForPositive(ref int a)
        {
            while (true)
            {
                a = Convert.ToInt32(Console.ReadLine());
                if (a >= 0)
                    break;
                Console.WriteLine("You have entered a negative number. Try again");
            }
        }
        static void Enter(ref int n, ref int p)
        {
            Console.WriteLine("Enter the number of repeats");
            CheckForPositive(ref n);
            Console.WriteLine("Enter the duration of pause");
            CheckForPositive(ref p);
        }

        static void Main(string[] args)
        {
            int n = 0;
            int p = 0;
            Console.WriteLine("Enter the number of repeats for all threads");
            CheckForPositive(ref PrintMessage.numberPrinted);
            Console.WriteLine("Enter the information for the first thread");
            Console.WriteLine("Enter the message");
            string s1 = Console.ReadLine();
            Enter(ref n, ref p);
            PrintMessage a = new PrintMessage(s1, n, p);
            Console.WriteLine("Enter the information for the second thread");
            Console.WriteLine("Enter the message");
            string s2 = Console.ReadLine();
            Enter(ref n, ref p);
            PrintMessage b = new PrintMessage(s2, n, p);
            Console.WriteLine("Enter the information for the third thread");
            Console.WriteLine("Enter the message");
            string s3 = Console.ReadLine();
            Enter(ref n, ref p);
            PrintMessage c = new PrintMessage(s3, n, p);
            Thread t1 = new Thread(a.Print);
            t1.Start();
            Thread t2 = new Thread(b.Print);
            t2.Start();
            Thread t3 = new Thread(c.Print);
            t3.Start();
            t1.Join();
            t2.Join();
            t3.Join();
        }
    }
}
