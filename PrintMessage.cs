using System;
using System.Runtime.CompilerServices;
using System.Threading;
namespace ClassPrintMessage
{
    public class PrintMessage
    {
        private string _message;
        private int _number;
        private int _pause;
        public static int numberPrinted;
        public PrintMessage(string message, int number, int pause)
        {
            _message = message;
            _number = number;
            _pause = pause;
        }
        
        public void Print()
        {
            int n = _number;
            int p = _pause;
            string s = _message;
            object lo = new object();
            for(int i = 0; i < n; i++)
            {
                if (PrintMessage.numberPrinted == 0)
                    break;
                lock (lo)
                    PrintMessage.numberPrinted--;
                Thread.Sleep(p);
                Console.WriteLine(s);
            }
        }

    }
}