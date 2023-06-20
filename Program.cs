using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentDataTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float myFloatValue = 10;
            int myIntValue = (int) myFloatValue;
            Console.WriteLine("myIntValue is " + myIntValue);
            Console.ReadLine();
        }
    }
}
