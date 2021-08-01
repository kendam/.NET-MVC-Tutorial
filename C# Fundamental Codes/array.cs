using System;
using ExtendedTungaCSharpIntro;
using System.Linq;




namespace TungaCSharpIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            //syntax: Type[] varName = {}
            string[] names = { "Kenny", "Daniel", "Alex", "Bart", "Carlton" };
            string[] Country = new string[5];
            string[] choiceOfLanguage = new string[4] { "Java", "PHP", "C#", "JavaScript"};
            string[] Lang = new string[5];
            int[] wages = { 1000, 4000, 3000, 6000, 2000, 9000, 7000 };

            
            Country[0] = "Nigeria";
            Country[1] = "Ghana";
            Country[2] = "Uganda";
            Country[3] = "Zambia";

            Console.WriteLine(Country[2]);

            choiceOfLanguage.CopyTo(Lang, 0);
            Console.WriteLine(Lang[2]);



            //sort
            Array.Sort(names);
            Console.WriteLine(names[0]);

            // Length : 
            Console.WriteLine(names.Length);

            // Loop

            for(int i =0; i< choiceOfLanguage.Length; i++)
            {
                Console.WriteLine(choiceOfLanguage[i]);
            }
            Console.WriteLine("***********************************************");
            foreach (string name  in names)
            {
                Console.WriteLine(name);

            }

           


        }
    }

   
}
