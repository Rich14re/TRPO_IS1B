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
        public static void PrintDataDase()
        {
            foreach (Lesson lessons in DB.lessons)
            {
                PrintLesson(lessons);
            }
        }
        public static void PrintLesson(Lesson lesson)
        {
            Console.WriteLine(lesson);
            PrintDiscipline(lesson.Discipline);
        }

        public static void PrintDiscipline(Discipline discipline)
        {
            Console.WriteLine(discipline);
        }
        public static void PrintEmplpoyee( Employee employee )
        {
            Console.WriteLine(employee);
            Console.WriteLine(employee.Name);
            Console.WriteLine(employee.Surname);
            Console.WriteLine(employee.Patronymic);
        }
        public static void PrintPosition (Position position)
        {
            Console.WriteLine(position);
        }
    }
}
