using System;
using ExtendedTungaCSharpIntro;



namespace TungaCSharpIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassExample classExample = new ClassExample(55,"Kenny","Problem Solver","Nigeria");

            //classExample.age = 100;
            Console.WriteLine(classExample.Name);
            Console.WriteLine(classExample.ProfessionEchoer("Doctor"));
           

        }
    }

   
}
