using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Part_4._5_intro_to_methods
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Give me a number.");
            num = Convert.ToInt32(Console.ReadLine());
            Joke(num);
        }
        public static void Joke(int numBugs)
        {
            Console.WriteLine(numBugs + " little bugs in the code");
            Thread.Sleep(1000);
            Console.WriteLine(numBugs + " little bugs.");
            Thread.Sleep(1000);
            Console.WriteLine("Fix a bug, run it again,");
            Thread.Sleep(1000);
            Console.WriteLine((++numBugs) + " little bugs in the code.");
        }
    }
}
