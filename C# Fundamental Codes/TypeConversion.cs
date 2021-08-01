using System;

namespace TungaCSharpIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
             1. Implicit conversion
             2. Explicit  conversion
             */

            // 1. Implicit conversion
            //char,int,long, float,double 
            //char < int <long <float < double

            int age = 54;
            double newAge = age;
            float length = 55.56f;
            double newLength = length;


           // 2.Explicit  conversion
            int extraLength = (int) newLength; // casting 
            float sampleLength = (float) newLength;

           
            
            // Inbuit Type Conversion
            string amount = "5000";
            int newAmount = Convert.ToInt32(amount);

            string sampleAge = age.ToString();

            Console.WriteLine("***********************************************");
            Console.WriteLine("Please tell your rate");
            int rate = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"Your rate is {rate * 1000}");

            Console.WriteLine("***********************************************");
            Console.WriteLine("***********************************************");
            Console.WriteLine("The real age is " + age);
            Console.WriteLine("The new age is " + newAge);
            Console.WriteLine("The real length is " + length);
            Console.WriteLine("The new length is " + newLength);
            Console.WriteLine($"The extra length is {extraLength}");
            Console.WriteLine($"The sample length is {sampleLength}");

        }
    }

   
}
