using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Color;

namespace Student
{
    public class ShowStudents
    {
        public static void DisplayStudents(List<StudentData> students)
        {
            int index = 1;

            TextColor.Cyan("**************** List of Students ****************");
            Console.WriteLine();

            foreach (var S in students)
            {
                TextColor.Red($"[{index}] ");
                TextColor.Blue($"*Name : {S.Name}  Family : {S.Family}  UzerName : {S.Uzername}  Age : {S.Age}  PhoneNumber : {S.PhoneNumber}  StudentNumber : {S.StudentNumber}");
                Console.WriteLine();
                index++;
            }

            TextColor.Cyan("**************************************************");
            Console.WriteLine();
        }
    }
}
