using System;

namespace Exercise_1___Teach_ME__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double side = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            // A * H /2
            double area = side * h / 2;


            Console.WriteLine($"Area: {area:f2}");


        }
    }
}
