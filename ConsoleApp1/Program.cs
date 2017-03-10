using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var brute = new Brute_numerator.BruteSequence(Brute_numerator.CharacterArrays.CommonSpecialArray);
            foreach(var str in brute)
            {
                if (brute.NumberGenerated % 100000 == 0 )
                {
                    Console.WriteLine(str);
                }               
            }
            Console.WriteLine("Hello World!");
        }
    }
}