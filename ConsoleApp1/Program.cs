using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var type = typeof(Program);

            Console.WriteLine(type.FullName);

            Console.WriteLine("Release v1.0.0");

            Console.ReadLine();
        }
    }
}
