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
        public static void PrintLessons()
        {
            foreach (var lesson in DB.lessons)
            {
                Printer.PrintLesson(lesson);
                Console.WriteLine();
            }
        }

        public static void PrintClassrooms()
        {
            foreach (var classroom in DB.classrooms)
            {
                Printer.PrintClassroom(classroom);
                Console.WriteLine();
            }
        }

        public static void PrintDisciplines()
        {
            foreach (var discipline in DB.disciplines)
            {
                Printer.PrintDiscipline(discipline);
                Console.WriteLine();
            }
        }

        public static void PrintGroups()
        {
            foreach (var group in DB.groups)
            {
                Printer.PrintGroup(group);
                Console.WriteLine();
            }
        }

        public static void PrintStudents()
        {
            foreach (var student in DB.students)
            {
                Console.WriteLine("Студент:");
                Console.WriteLine($"ФИО: {student.Name}");
                Console.WriteLine($"Группа: {student.Group.Name}");
                Console.WriteLine($"Дата рождения: {student.Birth}");
                Console.WriteLine();
            }
        }

        public static void PrintTypeOfActivities()
        {
            foreach (var typeOfActivity in DB.typeOfActivities)
            {
                Printer.PrintTypeOfActivity(typeOfActivity);
                Console.WriteLine();
            }
        }
        public static void PrintSpecialities()
        {
            foreach (var speciality in DB.specialties)
            {
                Printer.PrintSpeciality(speciality);
                Console.WriteLine();
            }
        }

        public static void PrintPairs()
        {
            foreach (var pair in DB.pairs)
            {
                Printer.PrintPair(pair);
                Console.WriteLine();
            }
        }

        public static void PrintShifts()
        {
            foreach (var shift in DB.shifts)
            {
                Console.WriteLine("Смена:");
                Console.WriteLine($"Название: {shift.Name}");
                Console.WriteLine();
            }
        }

        public static void PrintEmployees()
        {
            foreach (var employee in DB.employees)
            {
                Printer.PrintEmployee(employee);
                Console.WriteLine();
            }
        }

        public static void PrintPositions()
        {
            foreach (var position in DB.positions)
            {
                Printer.PrintPosition(position);
                Console.WriteLine();
            }
        }

        public static void PrintDivisions()
        {
            foreach (var division in DB.divisions)
            {
                Printer.PrintDivision(division);
                Console.WriteLine();
            }
        }

        public static void PrintOrganisations()
        {
            foreach (var organisation in DB.organisations)
            {
                Printer.PrintOrganisation(organisation);
                Console.WriteLine();
            }
        }

        public static void PrintBodies()
        {
            foreach (var body in DB.bodies)
            {
                Printer.PrintBody(body);
                Console.WriteLine();
            }
        }

        private static void PrintLesson(Lesson lesson)
        {
            Console.WriteLine("Урок:");
            Console.WriteLine($"Дата: {lesson.DateHeld}");
            Console.WriteLine($"Дисциплина: {lesson.Discipline.Name}");
            Console.WriteLine($"Преподаватель: {lesson.Employe.Name}");
            Console.WriteLine($"Аудитория: {lesson.Classroom.Number}");
            Console.WriteLine($"Группа: {lesson.Group.Name}");
            Console.WriteLine($"Пара: {lesson.Pair.Time_Pair_Start} - {lesson.Pair.Time_Break_End}");
            Console.WriteLine($"Вид деятельности: {lesson.TypeOfActivity.Letter}");
        }

        private static void PrintDiscipline(Discipline discipline)
        {
            Console.WriteLine("Дисциплина:");
            Console.WriteLine($"Название: {discipline.Name}");
            Console.WriteLine($"Сокращение: {discipline.Shortname}");
        }

        private static void PrintGroup(Group group)
        {
            Console.WriteLine("Группа:");
            Console.WriteLine($"Название: {group.Name}");
            Console.WriteLine($"Сокращение: {group.Shortname}");
            Console.WriteLine($"Количество студентов: {group.Quantity}");
            Console.WriteLine($"Год создания: {group.Year}");
            Console.WriteLine($"Специальность: {group.Speciality.Name}");
            Console.WriteLine($"Куратор: {group.Employee.Name}");
        }
        private static void PrintClassroom(Classroom classroom)
        {
            Console.WriteLine("Аудитория:");
            Console.WriteLine($"Номер: {classroom.Number}");
            Console.WriteLine($"Ответственный: {classroom.employee.Name}");
            Console.WriteLine($"Количество мест: {classroom.Places}");
            Console.WriteLine($"Количество окон: {classroom.Windows}");
            Console.WriteLine("Оборудование:");
            Console.WriteLine(string.Join<Equipment>(", ", classroom.Equipment));
        }

        private static void PrintEmployee(Employee employee)
        {
            Console.WriteLine("Сотрудник:");
            Console.WriteLine($"ФИО: {employee.Name}");
            Console.WriteLine($"Должность: {employee.Position.Title}");
        }

        private static void PrintPair(Pair pair)
        {
            Console.WriteLine("Пара:");
            Console.WriteLine($"Начало: {pair.Time_Pair_Start}");
            Console.WriteLine($"Окончание: {pair.Time_Pair_End}");
            Console.WriteLine($"Начало перерыва: {pair.Time_Break_Start}");
            Console.WriteLine($"Окончание перерыва: {pair.Time_Break_End}");
            Console.WriteLine($"Смена: {pair.shift.Name}");
        }

        private static void PrintSpeciality(Speciality speciality)
        {
            Console.WriteLine("Специальность:");
            Console.WriteLine($"Название: {speciality.Name}");
            Console.WriteLine($"Сокращение: {speciality.Abbreviation}");
        }

        private static void PrintTypeOfActivity(TypeOfActivity typeOfActivity)
        {
            Console.WriteLine("Вид деятельности:");
            Console.WriteLine($"Буква: {typeOfActivity.Letter}");
        }

        private static void PrintPosition(Position position)
        {
            Console.WriteLine("Должность:");
            Console.WriteLine($"Название: {position.Title}");
            Console.WriteLine($"Зарплата: {position.Salary}");
            Console.WriteLine($"Подразделение: {position.division.Name}");
        }

        private static void PrintDivision(Division division)
        {
            Console.WriteLine("Подразделение:");
            Console.WriteLine($"Название: {division.Name}");
            Console.WriteLine($"Директор: {division.director.Name}");
            Console.WriteLine($"Организация: {division.organization.Name}");
        }

        public static void PrintOrganisation(Organisation organisation)
        {
            Console.WriteLine("Организация:");
            Console.WriteLine($"Название: {organisation.Name}");
            Console.WriteLine($"Юридический адрес: {organisation.LegalAdress}");
            Console.WriteLine($"Фактический адрес: {organisation.ActualAdress}");
            Console.WriteLine($"Руководитель: {organisation.Employee.Name}");
        }

        private static void PrintBody(Body body)
        {
            Console.WriteLine("Корпус:");
            Console.WriteLine($"Название: {body.Name}");
            Console.WriteLine($"Адрес: {body.Address}");
            if (body.Comendante != null)
            {
                Console.WriteLine($"Комендант: {body.Comendante.Name} {body.Comendante.Surname} {body.Comendante.Patronymic}");
            }
            else
            {
                Console.WriteLine("Комендант не указан.");
            }
            Console.WriteLine($"Организация: {body.Organization.Name}");
        }
    }
}
