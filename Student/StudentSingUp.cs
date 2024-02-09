using Color;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Student
{
    public class StudentSingUp
    {
        public static StudentData SingUp()
        {
            TextColor.Cyan("***************** SingUp Student *****************");
            Console.WriteLine();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("enter your Name : ");
            string name = Console.ReadLine();

            Console.WriteLine("enter your Family : ");
            string family = Console.ReadLine();

            Console.WriteLine("enter your UzerName : ");
            string uzername = Console.ReadLine();

            Console.WriteLine("enter your Age : ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter your PhoneNumber : ");
            int phonenumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter your StudentNumber (Hatman Cod 5 Raghami Vared Konid): ");
            int studentnumber = Convert.ToInt32(Console.ReadLine());
            Console.ResetColor();

            return new StudentData(name, family, uzername, age, phonenumber, studentnumber);
        }
    }
}
