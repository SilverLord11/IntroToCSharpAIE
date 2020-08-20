using System;

namespace ArrayExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] values = { 2, 6, 10, 14 };
            Console.WriteLine(values[2]); //write the second value: 10
            Console.WriteLine(++values[0]); //increase the zero value, so 2 -->, 3 and write it
            Console.WriteLine(++values[0]); //increase the zero value again: 3 --> 4, and write it out
            int x = 2;
            Console.WriteLine(values[++x]); //write the third value, which is 14
            Console.WriteLine(values[4]); //outside of boundry
        }
    }
}
