using Color;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Security.Policy;
using System.Threading;

namespace Student
{
    public class SingIn
    {
        public static void Singin(List<StudentData> students)
        {
            try
            {
                TextColor.Cyan("***************** SingIn Student *****************");
                Console.WriteLine();

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("* enter your UzerName : ");
                string uzername = Console.ReadLine().ToLower();

                Console.WriteLine("* enter your StudentNumber : ");
                string number = Console.ReadLine();
                int studentnumber = Convert.ToInt32(number);

                if (uzername == "" || number == "")
                {
                    TextColor.Red("Eror : Plese Enter Your info ! ! !");
                    Console.WriteLine();
                    Thread.Sleep(2600);
                    Console.Clear();
                }
                else
                {
                    // مقایسه uzername با Name هر دانشجو در لیست
                    foreach (var S in students)
                    {
                        if (uzername == S.Uzername.ToLower() && studentnumber == S.StudentNumber)
                        {
                            // دانشجو یافت شد
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine($"Sign in successful for [{S.Name}]");
                            Thread.Sleep(1700);

                            Console.WriteLine($"Do you want to continue ? (Y/N)");
                            string InputUzer = Console.ReadLine();
                            Console.ResetColor();

                            switch (InputUzer.ToLower())
                            {
                                case "y":
                                    {
                                        Console.Clear();
                                        return;
                                        break;
                                    }
                                case "n":
                                    {
                                        Environment.Exit(0);
                                        break;
                                    }
                                default:
                                    {
                                        Console.ForegroundColor = ConsoleColor.Red;
                                        Console.Clear();
                                        Console.WriteLine("Just (Y/N) ! ! ! ");
                                        Thread.Sleep(2500);
                                        Console.Clear();
                                        Console.ResetColor();
                                        break;
                                    }
                            }
                            // انجام دیگر عملیات مورد نیاز
                            break; // می‌توانید از حلقه خارج شوید چون دانشجو یافت شده است
                        }
                        else
                        {
                            // اگر به اینجا رسیدیم، دانشجو یافت نشده است
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Sign in failed. Student not found.");
                            Console.ResetColor();
                            Thread.Sleep(3500);
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
        }
    }
}