using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal static class Creator
    {

        public static void CreateLesson()
        {
            Console.WriteLine("Введите название дисциплины:");
            string disciplineName = Console.ReadLine();
            Discipline discipline = DB.disciplines.FirstOrDefault(d => d.Name.ToLower() == disciplineName.ToLower());
            if (discipline == null)
            {
                Console.WriteLine("Дисциплина не найдена. Создайте дисциплину.");
                CreateDiscipline();
            }

            Console.WriteLine("Введите ФИО преподавателя:");
            string employeeName = Console.ReadLine();
            Employee employee = DB.employees.FirstOrDefault(e => $"{e.Name} {e.Surname} {e.Patronymic}".ToLower() == employeeName.ToLower());
            if (employee == null)
            {
                Console.WriteLine("Преподаватель не найден. Задайте преподавателя.");
                CreateEmployee();
            }

            Console.WriteLine("Введите номер аудитории:");
            string classroomNumber = Console.ReadLine();
            Classroom classroom = DB.classrooms.FirstOrDefault(c => c.Number == classroomNumber);
            if (classroom == null)
            {
                Console.WriteLine("Аудитория не найдена. Задайте номер аудитории.");
                CreateClassroom();
            }
            Console.WriteLine("Введите начало пары (в формате чч:мм):");
            string pairStart = Console.ReadLine();

            Console.WriteLine("Введите конец пары (в формате чч:мм):");
            string pairEnd = Console.ReadLine();

            Pair pair = DB.pairs.FirstOrDefault(p => p.Time_Pair_Start == pairStart && p.Time_Pair_End == pairEnd);
            if (pair == null)
            {
                Console.WriteLine("Пара не найдена. Создайте его.");
                CreatePair();
            }

            Console.WriteLine("Введите название группы:");
            string groupName = Console.ReadLine();
            ClassLibrary.Group group = DB.groups.FirstOrDefault(g => g.Name.ToLower() == groupName.ToLower());
            if (group == null)
            {
                Console.WriteLine("Группа не найдена. Задайте название группы.");
                CreateGroup();
            }

            Console.WriteLine("Введите букву корпуса:");
            string bodyLetter = Console.ReadLine().ToUpper();
            Body body = DB.bodies.FirstOrDefault(b => b.Name == bodyLetter);
            if (body == null)
            {
                Console.WriteLine("Корпус не найден. Задайте букву корпуса.");
                CreateBody();
            }

            Console.WriteLine("Введите дату:");
            string date = Console.ReadLine();

            Console.WriteLine("Введите вид деятельности:");
            char activityLetter = char.Parse(Console.ReadLine().ToUpper());

            TypeOfActivity typeofactivity = DB.typeOfActivities.FirstOrDefault(a => a.Letter == activityLetter);
            if (typeofactivity == null)
            {
                Console.WriteLine("Вид деятельности не найден. Создайте его.");
                CreateTypeOfActivity();
            }

            Lesson lesson = new Lesson(DateTime.Parse(date), discipline, employee, classroom, group, pair, typeofactivity);
            DB.lessons.Add(lesson);
            Console.WriteLine("Занятие успешно создано.");
        }

        public static void CreateClassroom()
        {
            Console.WriteLine("Введите номер аудитории:");
            string classroomNumber = Console.ReadLine();

            Console.WriteLine("Введите ФИО ответственного сотрудника:");
            string employeeName = Console.ReadLine();

            Employee employee = DB.employees.FirstOrDefault(e => $"{e.Name} {e.Surname} {e.Patronymic}".ToLower() == employeeName.ToLower());
            if (employee == null)
            {
                Console.WriteLine("Сотрудник не найден. Задайте сотрудника.");
                CreateEmployee();
            }

            Console.WriteLine("Введите количество мест в аудитории:");
            int places = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество окон в аудитории:");
            int windows = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите список ссылок на оборудование: ");

            int n = Convert.ToInt32(Console.ReadLine());

            Equipment[] equipment = new Equipment[n];
            Classroom classroom = new Classroom(classroomNumber, employee, places, windows, equipment);
            DB.classrooms.Add(classroom);

            Console.WriteLine("Аудитория успешно создана.");
        }

        public static void CreateDiscipline()
        {
            Console.WriteLine("Введите название дисциплины:");
            string disciplineName = Console.ReadLine();

            Console.WriteLine("Введите короткое название дисциплины:");
            string disciplineShortName = Console.ReadLine();

            Discipline discipline = new Discipline(disciplineName, disciplineShortName);
            DB.disciplines.Add(discipline);

            Console.WriteLine("Дисциплина успешно создана.");
        }

        public static void CreateGroup()
        {
            Console.WriteLine("Введите название группы:");
            string groupName = Console.ReadLine();

            Console.WriteLine("Введите короткое название группы:");
            string groupShortName = Console.ReadLine();

            Console.WriteLine("Введите количество студентов в группе:");
            int groupQuantity = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите название специальности:");
            string specialityName = Console.ReadLine();
            Speciality speciality = DB.specialties.FirstOrDefault(s => s.Name.ToLower() == specialityName.ToLower());
            if (speciality == null)
            {
                Console.WriteLine("Специальность не найдена. Задайте специальность.");
                CreateSpeciality();
            }

            Console.WriteLine("Введите ФИО куратора группы:");
            string employeeName = Console.ReadLine();
            Employee employee = DB.employees.FirstOrDefault(e => $"{e.Name} {e.Surname} {e.Patronymic}".ToLower() == employeeName.ToLower());
            if (employee == null)
            {
                Console.WriteLine("Куратор не найден. Задайте куратора группы.");
                CreateEmployee();
            }

            Console.WriteLine("Введите год создания группы (пустое значение означает текущий год):");
            string yearInput = Console.ReadLine();
            int year = yearInput == "" ? DateTime.Now.Year : Convert.ToInt32(yearInput);

            ClassLibrary.Group group = new ClassLibrary.Group(groupName, groupShortName, groupQuantity, speciality, employee, year);
            DB.groups.Add(group);
            Console.WriteLine("Группа успешно создана.");
        }

        public static void CreateStudent()
        {
            Console.WriteLine("Введите фамилию студента:");
            string surname = Console.ReadLine();

            Console.WriteLine("Введите имя студента:");
            string name = Console.ReadLine();

            Console.WriteLine("Введите отчество студента:");
            string patronymic = Console.ReadLine();

            Console.WriteLine("Введите название группы студента:");
            string groupName = Console.ReadLine();
            ClassLibrary.Group group = DB.groups.FirstOrDefault(g => g.Name.ToLower() == groupName.ToLower());
            if (group == null)
            {
                Console.WriteLine("Группа не найдена. Задайте группу.");
                CreateGroup();
            }

            Console.WriteLine("Введите дату рождения студента (пустое значение означает текущую дату):");
            string birth = Console.ReadLine();

            Student student = new Student(surname, name, patronymic, group, DateTime.Parse(birth));
            DB.students.Add(student);
            Console.WriteLine("Студент успешно создан.");
        }

        public static void CreateSpeciality()
        {
            Console.WriteLine("Введите название специальности:");
            string name = Console.ReadLine();

            Console.WriteLine("Введите сокращенное название специальности:");
            string abbreviation = Console.ReadLine();

            Speciality speciality = new Speciality(name, abbreviation);
            DB.specialties.Add(speciality);
            Console.WriteLine("Специальность успешно создана.");
        }

        public static void CreatePair()
        {
            Console.WriteLine("Введите время начала пары (в формате чч:мм):");
            string timePairStart = Console.ReadLine();

            Console.WriteLine("Введите время окончания пары (в формате чч:мм):");
            string timePairEnd = Console.ReadLine();

            Console.WriteLine("Введите время начала перерыва (в формате чч:мм):");
            string timeBreakStart = Console.ReadLine();

            Console.WriteLine("Введите время окончания перерыва (в формате чч:мм):");
            string timeBreakEnd = Console.ReadLine();

            Console.WriteLine("Введите название смены:");
            string shiftName = Console.ReadLine();
            Shift shift = DB.shifts.FirstOrDefault(s => s.Name.ToLower() == shiftName.ToLower());
            if (shift == null)
            {
                Console.WriteLine("Смена не найдена. Создайте пару.");
                CreateShift();
            }

            Pair pair = new Pair(timePairStart, timePairEnd, timeBreakStart, timeBreakEnd, shift);
            DB.pairs.Add(pair);
            Console.WriteLine("Пара успешно создана.");
        }

        static public void CreateShift()
        {
            Console.WriteLine("Введите название смены:");
            string name = Console.ReadLine();

            Shift shift = new Shift(name);
            DB.shifts.Add(shift);
            Console.WriteLine("Смена успешно создана.");
        }

        static public void CreateEmployee()
        {
            Console.WriteLine("Введите имя сотрудника:");
            string name = Console.ReadLine();

            Console.WriteLine("Введите фамилию сотрудника:");
            string surname = Console.ReadLine();

            Console.WriteLine("Введите отчество сотрудника:");
            string patronymic = Console.ReadLine();

            Console.WriteLine("Введите название должности:");
            string jobTitleName = Console.ReadLine();

            Position position = DB.positions.FirstOrDefault(j => j.Title.ToLower() == jobTitleName.ToLower());
            if (position == null)
            {
                Console.WriteLine("Должность не найдена. Создайте специальность.");
                CreateSpeciality();
            }

            Employee employee = new Employee(name, surname, patronymic, position);
            DB.employees.Add(employee);
            Console.WriteLine("Сотрудник успешно создан.");
        }

        static public void CreateJobTitle()
        {
            Console.WriteLine("Введите название должности:");
            string name = Console.ReadLine();

            Console.WriteLine("Введите зарплату должности:");
            int salary = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите название подразделения:");
            string subdivisionName = Console.ReadLine();
            Division subdivision = DB.divisions.FirstOrDefault(s => s.Name.ToLower() == subdivisionName.ToLower());
            if (subdivision == null)
            {
                Console.WriteLine("Подразделение не найдено. Создайте его");
                CreateSubdivision();
            }

            Position speciality = new Position(name, salary, subdivision);
            DB.positions.Add(speciality);
            Console.WriteLine("Должность успешно создана.");
        }

        static public void CreateSubdivision()
        {
            Console.WriteLine("Введите название подразделения:");
            string name = Console.ReadLine();

            Console.WriteLine("Введите фамилию, имя и отчество директора:");
            string directorFullName = Console.ReadLine();
            Employee director = DB.employees.FirstOrDefault(e => $"{e.Name} {e.Surname} {e.Patronymic}" == directorFullName);
            if (director == null)
            {
                Console.WriteLine("Директор не найден. Создайте его.");
                CreateEmployee();
            }

            Console.WriteLine("Введите название организации:");
            string organizationName = Console.ReadLine();
            Organisation organization = DB.organisations.FirstOrDefault(o => o.Name.ToLower() == organizationName.ToLower());
            if (organization == null)
            {
                Console.WriteLine("Организация не найдена. Создайте ее");
                CreateOrganization();
            }

            Division subdivision = new Division(name, director, organization);
            DB.divisions.Add(subdivision);
            Console.WriteLine("Подразделение успешно создано.");
        }

        static public void CreateOrganization()
        {
            Console.WriteLine("Введите название организации:");
            string name = Console.ReadLine();

            Console.WriteLine("Введите юридический адрес организации:");
            string legalAddress = Console.ReadLine();

            Console.WriteLine("Введите фактический адрес организации:");
            string actualAddress = Console.ReadLine();

            Console.WriteLine("Введите фамилию, имя и отчество руководителя организации:");
            string supervisorFullName = Console.ReadLine();
            Employee supervisor = DB.employees.FirstOrDefault(e => $"{e.Name} {e.Surname} {e.Patronymic}" == supervisorFullName);
            if (supervisor == null)
            {
                Console.WriteLine("Руководитель не найден. Задайте руководителя.");
                CreateEmployee();
            }

            Organisation organization = new Organisation(name, legalAddress, actualAddress, supervisor);
            DB.organisations.Add(organization);
            Console.WriteLine("Организация успешно создана.");
        }

        static public void CreateBody()
        {
            Console.WriteLine("Введите название корпуса:");
            string name = Console.ReadLine();

            Console.WriteLine("Введите адрес корпуса:");
            string address = Console.ReadLine();

            Console.WriteLine("Введите фамилию, имя и отчество коменданта корпуса:");
            string commandantFullName = Console.ReadLine();
            Employee commandant = DB.employees.FirstOrDefault(e => $"{e.Name} {e.Surname} {e.Patronymic}" == commandantFullName);
            if (commandant == null)
            {
                Console.WriteLine("Комендант не найден. Создайте его");
                CreateEmployee();
            }

            Console.WriteLine("Введите название организации, которой принадлежит корпус:");
            string organizationName = Console.ReadLine();
            Organisation organization = DB.organisations.FirstOrDefault(o => o.Name.ToLower() == organizationName.ToLower());
            if (organization == null)
            {
                Console.WriteLine("Организация не найдена. Создайте ее");
                CreateOrganization();
            }

            Body body = new Body(name, address, commandant, organization);
            DB.bodies.Add(body);
            Console.WriteLine("Корпус успешно создан.");
        }
        static public void CreateTypeOfActivity()
        {
            Console.WriteLine("Введите букву вида деятельности:");
            char activityLetter = char.Parse(Console.ReadLine().ToUpper());

            TypeOfActivity activity = new TypeOfActivity { Letter = activityLetter };
            DB.typeOfActivities.Add(activity);

            Console.WriteLine("Вид деятельности успешно создан.");
        }
    }
}
