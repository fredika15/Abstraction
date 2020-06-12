using System;

using Abstraction;
namespace Abstraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Pakaian pakaian;

            pakaian = new kemeja();
            pakaian.atasan();

            Console.WriteLine();
            pakaian = new kaos();
            pakaian.atasan();

            Console.ReadKey();
        }
    }
}