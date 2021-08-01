using System;
using ExtendedTungaCSharpIntro;
using System.Linq;




namespace TungaCSharpIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            Person student = new Student(15,"Dayo","Nigeria","student");
            Person admin = new Admin(57, "Yusra", "Nigeria", "Admin");
            Person lecturer = new Lecturer(45, "Kenny", "Ghana", "Lecturer");

            student.SayHello();
            admin.SayHello();
            lecturer.SayHello();
           
        
        }
    }

   
}
