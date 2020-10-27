using System;

namespace Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            var answer = 4;

            var response = (answer < 9) ? $"{answer} is less than nine" : $"{answer} greater than nine";

            Console.WriteLine(response);
        }
    }
}
