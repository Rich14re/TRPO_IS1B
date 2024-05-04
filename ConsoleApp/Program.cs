using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;

namespace ConsoleApp
{
    internal class Program
    {

        /// <summary>
        /// всего 11 вариантов в подгруппе.
        /// </summary>
        static void Main()
        {
            bool exit = false;
            try
            {
                while (!exit)
                {
                    
                    Console.WriteLine("Выберите действие:");
                    Console.WriteLine("1. Создать занятие");
                    Console.WriteLine("2. Создать аудиторию");
                    Console.WriteLine("3. Создать дисциплину");
                    Console.WriteLine("4. Создать группу");
                    Console.WriteLine("5. Создать студента");
                    Console.WriteLine("6. Создать специальность");
                    Console.WriteLine("7. Создать пару");
                    Console.WriteLine("8. Создать смену");
                    Console.WriteLine("9. Создать сотрудника");
                    Console.WriteLine("10. Создать должность");
                    Console.WriteLine("11. Создать подразделение");
                    Console.WriteLine("12. Создать организацию");
                    Console.WriteLine("12. Создать корпус");
                    Console.WriteLine("29. Создать активность");
                    Console.WriteLine("28 - выйти из программы");
                    Console.WriteLine("15 - вывести занятия");
                    Console.WriteLine("16 - вывести аудитории");
                    Console.WriteLine("17 - вывести дисциплины");
                    Console.WriteLine("18 - вывести группы");
                    Console.WriteLine("19 - вывести студентов");
                    Console.WriteLine("20 - вывести специальности");
                    Console.WriteLine("21 - вывести пары");
                    Console.WriteLine("22 - вывести сотрудников");
                    Console.WriteLine("23 - вывести должности");
                    Console.WriteLine("24 - вывести подразделения");
                    Console.WriteLine("25 - вывести организации");
                    Console.WriteLine("26 - вывести корпус");
                    Console.WriteLine("27 - вывести активность");

                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Creator.GetOrCreateLesson();
                            break;
                        case 2:
                            Creator.GetOrCreateClassroom();
                            break;
                        case 3:
                            Creator.GetOrCreateDiscipline();
                            break;
                        case 4:
                            Creator.GetOrCreateGroup();
                            break;
                        case 5:
                            Creator.GetOrCreateStudent();
                            break;
                        case 6:
                            Creator.GetOrCreateSpeciality();
                            break;
                        case 7:
                            Creator.GetOrCreatePair();
                            break;
                        case 8:
                            Creator.GetOrCreateShift();
                            break;
                        case 9:
                            Creator.GetOrCreateEmployee();
                            break;
                        case 10:
                            Creator.GetOrCreatePosition();
                            break;
                        case 11:
                            Creator.GetOrCreateSubdivision();
                            break;
                        case 12:
                            Creator.GetOrCreateOrganization();
                            break;
                        case 13:
                            Creator.GetOrCreateBody();
                            break;
                        case 14:
                            Printer.PrintShifts();
                            break;
                        case 15:
                            Printer.PrintLessons();
                            break;
                        case 16:
                            Printer.PrintClassrooms();
                            break;
                        case 17:
                            Printer.PrintDisciplines();
                            break;
                        case 18:
                            Printer.PrintGroups();
                            break;
                        case 19:
                            Printer.PrintStudents();
                            break;
                        case 20:
                            Printer.PrintSpecialities();
                            break;
                        case 21:
                            Printer.PrintPairs();
                            break;
                        case 22:
                            Printer.PrintEmployees();
                            break;
                        case 23:
                            Printer.PrintPositions();
                            break;
                        case 24:
                            Printer.PrintDivisions();
                            break;
                        case 25:
                            Printer.PrintOrganisations();
                            break;
                        case 26:
                            Printer.PrintBodies();
                            break;
                        case 27:
                            Printer.PrintTypeOfActivities();
                            break;
                        case 29:
                            Creator.GetOrCreateTypeOfActivity();
                            break;
                        case 28:
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Неверный выбор, попробуйте еще раз.");
                            break;
                    }
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
