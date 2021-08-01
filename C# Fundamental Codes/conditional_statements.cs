using System;
using ExtendedTungaCSharpIntro;



namespace TungaCSharpIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            ConditionalStatement conditionalStatement = new ConditionalStatement();
            
            /*
             * if (condition)
             * {
             *    action
             * }
             
             */

            if (conditionalStatement.wage > 10000)
            {
                Console.WriteLine($" your pay of ${conditionalStatement.wage} is pretty inspiring");
            }
            else if (conditionalStatement.wage >=5000)
            {
                Console.WriteLine("You are a moderate earner");
            }
            else
            {
                Console.WriteLine("Keep working hard");

            }
           

            // Ternary operator 

            // variable  = (condition) ? expressionIfTrue : exprssionIfFalse

            string Msg = (conditionalStatement.wage > 10000) ? $" your pay of ${conditionalStatement.wage} is pretty inspiring" : "Keep working hard";
            Console.WriteLine(Msg);

            /* Switch Statement 
             * 
             * switch(expression)
             * {
             * case a:
             *       Code to be execute
             *       break;
             * case b : 
                      Code to be execute
             *       break
             *  case c : 
             *       Code to be execute
             *       break
             *  default :
             *       Code to be execute
             *       break
             *  }
             *  */

            switch(conditionalStatement.wage)
            {
                case 1000:
                    Console.WriteLine("The young shall grow");
                    break;
                case 5000:
                    Console.WriteLine("Not bad ");
                    break;
                case 10000:
                    Console.WriteLine("Pretty good");
                     break;
                default:
                    Console.WriteLine("out of scope");
                    break;
               
            }

        }
    }

   
}
