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

            //3. Relational operators
            // ==, !=, > , < , >= , <=

            int a = 200, b = 400;

            //2. Logical Operators
            // AND = &&, OR = || , NOT = !
            bool d = a > b && a != b;
            bool e = a > b || a == b;


            Console.WriteLine( $" Relational ex: {a != b}");
            Console.WriteLine( $"Logical && ex:  {d}");
            Console.WriteLine($"LOgical Or  ex:  {e}");



        }
    }

   
}
