using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Student
{
    public class StudentData
    {
        
        private int _age;
        private int _studentnumber;

        public string Name { get; set; }
        public string Family { get; set; }
        public string Uzername { get; set; }
        public int Age { get; set; }
        public int PhoneNumber { get; set; }
        public int StudentNumber
        {
            get
            {
                return _studentnumber;
            }
            set
            {
                if (value > 100000)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Cod vared shode bishtar az 5 ragham ast ! ! !");
                    Console.WriteLine("Lotfan dobare emtehan konid !");
                    Thread.Sleep(1800);
                    Console.ResetColor();

                    _studentnumber = 0;
                    Name = "Error";
                    Family = "Error";
                    Uzername = "Error";
                    PhoneNumber = 0;
                    Age = 0;

                }
                else
                {
                    _studentnumber = value;

                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Your SingUp is successful");
                    Console.ResetColor();
                    Thread.Sleep(1200);
                }
            }
        }

        public StudentData(string name, string family, string uzername, int age, int phonenumber, int studentnumber)
        {
            this.Name = name;
            this.Family = family;
            this.Uzername = uzername;
            this.Age = age;
            this.PhoneNumber = phonenumber;
            this.StudentNumber = studentnumber;
        }
    }
}
