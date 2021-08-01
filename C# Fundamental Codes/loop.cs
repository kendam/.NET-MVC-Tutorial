using System;
using ExtendedTungaCSharpIntro;



namespace TungaCSharpIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            /* while 
             * do while
             * for 
             * foreach
             */

            // 1. while 

            /* while(condition)
             {
                 action
             }
            */
            int number = 1;

            while(number < 10)
            {
                Console.WriteLine(number);
                number++;
            }

            // 2. do while

            /* do
             {
                 // action

             }
             while(condition)
            */
            Console.WriteLine("******************************************************");
            do
            {
                Console.WriteLine("in do while" + number);
                number++;
            }
            while (number > 20);

            // 3. For 

            Console.WriteLine("******************************************************");
            Console.WriteLine("FOR LOOOOOOOOP****************************************");
            /*  for (statement1; statement2; statement3)
              { 
                  // action
              }
            */
            for (int i = 1; i < 30; i++)
            {
                Console.WriteLine(i);
            }
        }
    }

   
}
