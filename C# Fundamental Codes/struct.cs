using System;
using ExtendedTungaCSharpIntro;

namespace TungaCSharpIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //StrucExample strucExample;

            StrucExample strucExample = new StrucExample();
            strucExample.age = 50;
            strucExample.frequency = 44;
            Console.WriteLine("I am keeping it cool with the struct at " + strucExample.frequency);
            Console.WriteLine($"Age sqaured is {strucExample.AgeSquared()} ");
           

        }
    }

   
}
