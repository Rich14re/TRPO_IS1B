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

                            break;
                        case 2:

                            break;
                        case 3:

                            break;
                        case 4:

                            break;
                        case 5:

                            break;
                        case 6:

                            break;
                        case 7:

                            break;
                        case 8:

                            break;
                        case 9:

                            break;
                        case 10:

                            break;
                        case 11:

                            break;
                        case 12:

                            break;
                        case 13:

                            break;
                        case 14:
                            exit = true;
                            break;
                        default:
                            Console.WriteLine("Неверный выбор.");
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
