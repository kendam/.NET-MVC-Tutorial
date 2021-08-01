using System;
using ExtendedTungaCSharpIntro;


namespace TungaCSharpIntro
{
    class Program
    {
        enum ProgLanguage
        {
            PHP,
            Java,
            JavaScript = 9,
            C,
            TypeScript

        }
    

        static void Main(string[] args)
        {
            int jsValue = (int)ProgLanguage.JavaScript;
            int cValue = (int)ProgLanguage.C;
           
            Console.WriteLine($"I am a {ProgLanguage.PHP} developer");
            Console.WriteLine($"The integer value of JavaScript is {jsValue}");
            Console.WriteLine($"The integer value of C is {cValue}");
            Console.WriteLine($"I am a {Role.SysArchitect}");
           
            

        }
    }

   
}
