using System;

namespace TungaCSharpIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            /*OPERATORS
             * 1. Arithmetic Operators
             * 2. Logical Operators
             * 3. Relational operators
             * 4. Assignment operators
             * 5. Bitwise Operators
             * 6. Misc Operators
             */

            // 1. Arithmetic Operators
            // + , - , * , / , % , ++ , --

            int a = 400, b = 500, c = 900;
            int d = (a + b) * c + 200 - 100;
            a++;
            b--;
           

            // BODMAS :  Bracket (), off () * a, D,M,A,S


            Console.WriteLine($"The answer is {d}");
            Console.WriteLine($"A is now {a}");
            Console.WriteLine($"B is now {b}");
            Console.WriteLine($"The modulus of A & B is {b % a} ");

          


        }
    }

   
}
