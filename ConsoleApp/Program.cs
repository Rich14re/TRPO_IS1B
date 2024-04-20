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
                    Console.WriteLine("14 - выйти из программы");

                    int choice = Convert.ToInt32(Console.ReadLine());
                    switch (choice)
                    {
                        case 1:
                            Creator.CreateLesson();
                            break;
                        case 2:
                            Creator.CreateClassroom();
                            break;
                        case 3:
                            Creator.CreateDiscipline();
                            break;
                        case 4:
                            Creator.CreateGroup();
                            break;
                        case 5:
                            Creator.CreateStudent();
                            break;
                        case 6:
                            Creator.CreateSpeciality();
                            break;
                        case 7:
                            Creator.CreatePair();
                            break;
                        case 8:
                            Creator.CreateShift();
                            break;
                        case 9:
                            Creator.CreateEmployee();
                            break;
                        case 10:
                            Creator.CreateJobTitle();
                            break;
                        case 11:
                            Creator.CreateSubdivision();
                            break;
                        case 12:
                            Creator.CreateOrganization();
                            break;
                        case 13:
                            Creator.CreateBody();
                            break;
                        case 14:
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
