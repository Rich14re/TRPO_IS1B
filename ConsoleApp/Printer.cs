using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal static class Printer
    {
        public static void PrintLesson(Lesson lesson)
        {
            Console.WriteLine(lesson);
            PrintDiscipline(lesson.Discipline);
        }

        public static void PrintDiscipline(Discipline discipline)
        {
            Console.WriteLine(discipline);
        }
        public static void PrintGroup(Group group) 
        {
            Console.WriteLine(group.Name);
            Console.WriteLine(group.Shortname);
            Console.WriteLine(group.Quantity);
            Console.WriteLine(group.Year);
            Console.WriteLine(group.Speciality);
            Console.WriteLine(group.Employee);
        }
    }
}
