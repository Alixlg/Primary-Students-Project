using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Color;
using Student;

try
{
    List<StudentData> Students = new List<StudentData>();

    while (true)
    {
        TextColor.White("* Student SingUp ");
        TextColor.Red("[1]");
        Console.WriteLine();
        
        TextColor.White("* Show Students Stats ");
        TextColor.Red("[2]");
        Console.WriteLine();

        TextColor.White("* Student SingIn ");
        TextColor.Red("[3]");
        Console.WriteLine();

        TextColor.Red("* Exit ");
        TextColor.Red("[4]");
        Console.WriteLine();

        int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                {
                    Console.Clear(); //pak kardan safhe console
                    Students.Add(StudentSingUp.SingUp());
                    Thread.Sleep(4000);
                    Console.Clear();
                    break;
                }
            case 2:
                {
                    Console.Clear();
                    ShowStudents.DisplayStudents(Students);
                    break;
                }
            case 3:
                {
                    Console.Clear();
                    SingIn.Singin(Students);
                    break;
                }
            case 4:
                {
                    Console.Clear();
                    TextColor.Green("Yek dokme ra befesharid ");
                    Environment.Exit(0); //baste shodan console
                    break;
                }
            default:
                {
                    Console.Clear();
                    TextColor.Red("Adad Vared Shode Eshtebah Ast ! ! !");
                    Console.WriteLine();
                    Thread.Sleep(1800);
                    Console.Clear();
                    break;
                }
        }
    }
}
catch (FormatException)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Eror : Just Number ! ! ! !");
    Console.ResetColor();

    Thread.Sleep(2800); //delay dar console
    Console.Clear();
}