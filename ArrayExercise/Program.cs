using System;

namespace ArrayExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = { 2, 6, 10, 14 };
            Console.WriteLine(values[2]);
            Console.WriteLine(++values[0]);
            Console.WriteLine(++values[0]);
            int x = 2;
            Console.WriteLine(values[++x]);
            Console.WriteLine(values[4]);
        }
    }
}
