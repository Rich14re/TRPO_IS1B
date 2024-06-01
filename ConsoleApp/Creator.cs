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
        public static Lesson GetOrCreateLesson()
        {
            Discipline discipline = GetOrCreateDiscipline();
            Classroom classroom = GetOrCreateClassroom();
            Pair pair = GetOrCreatePair();
            ClassLibrary.Group group = GetOrCreateGroup();
            TypeOfActivity typeOfActivity = GetOrCreateTypeOfActivity();
            Employee employee = GetOrCreateEmployee();

            Console.WriteLine("Введите дату:");
            string date = Console.ReadLine();
            DateTime dateHeld = DateTime.Parse(date);
            Lesson lesson = DB.lessons.FirstOrDefault(l =>
                l.DateHeld == dateHeld &&
                l.Discipline == discipline &&
                l.Pair == pair &&
                l.Group == group &&
                l.TypeOfActivity == typeOfActivity &&
                l.Employe == employee);
            if (lesson == null)
            {
                lesson = new Lesson(discipline, employee, classroom, group, pair, typeOfActivity, dateHeld);
                DB.lessons.Add(lesson);
            }
            return lesson;
        }

        public static Classroom GetOrCreateClassroom()
        {
            Console.WriteLine("Введите номер аудитории:");
            string classroomNumber = Console.ReadLine();
            Classroom classroom = DB.classrooms.FirstOrDefault(c => c.Number == classroomNumber);
            if (classroom == null)
            {

                Employee employee = GetOrCreateEmployee();

                Console.WriteLine("Введите количество мест в аудитории:");
                int places = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Введите количество окон в аудитории:");
                int windows = Convert.ToInt32(Console.ReadLine());

                classroom = new Classroom(classroomNumber, employee, places, windows);
                DB.classrooms.Add(classroom);
                
                Console.WriteLine("Введите список ссылок на оборудование: ");
                int n = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i < n; i++)
                {
                    classroom.Equipments.Add(GetOrCreateEquipment());
                }
            }
            return classroom;
        }

        private static Equipment GetOrCreateEquipment()
        {
            return null;
        }

        public static Discipline GetOrCreateDiscipline()
        {
            Console.WriteLine("Введите название дисциплины:");
            string disciplineName = Console.ReadLine();
            Discipline discipline = DB.disciplines.FirstOrDefault(d => d.Name.ToLower() == disciplineName.ToLower());
            if (discipline == null)
            {

                Console.WriteLine("Введите короткое название дисциплины:");
                string disciplineShortName = Console.ReadLine();

                discipline = new Discipline(disciplineName, disciplineShortName);
                DB.disciplines.Add(discipline);
            }
            return discipline;
        }

        public static ClassLibrary.Group GetOrCreateGroup()
        {
            Console.WriteLine("Введите название группы:");
            string groupName = Console.ReadLine();
            ClassLibrary.Group group = DB.groups.FirstOrDefault(g => g.Name.ToLower() == groupName.ToLower());
            if (group == null)
            {

                Console.WriteLine("Введите короткое название группы:");
                string groupShortName = Console.ReadLine();

                Console.WriteLine("Введите количество студентов в группе:");
                int groupQuantity = Convert.ToInt32(Console.ReadLine());

                Speciality speciality = GetOrCreateSpeciality();
                Employee employee = GetOrCreateEmployee();

                Console.WriteLine("Введите год создания группы (пустое значение означает текущий год):");
                string yearInput = Console.ReadLine();
                int year =  string.IsNullOrEmpty(yearInput) ? DateTime.Now.Year : Convert.ToInt32(yearInput);

                group = new ClassLibrary.Group(groupName, groupShortName, groupQuantity, speciality, employee, year);
                DB.groups.Add(group);
            }
            return group;
        }

        public static void GetOrCreateStudent()
        {
            Console.WriteLine("Введите фамилию студента:");
            string surname = Console.ReadLine();

            Console.WriteLine("Введите имя студента:");
            string name = Console.ReadLine();

            Console.WriteLine("Введите отчество студента:");
            string patronymic = Console.ReadLine();
            
            ClassLibrary.Group group = GetOrCreateGroup();
            
            Console.WriteLine("Введите дату рождения студента (пустое значение означает текущую дату):");
            string birth = Console.ReadLine();

            Student student = new Student(surname, name, patronymic, group, DateTime.Parse(birth));
            DB.students.Add(student);
            Console.WriteLine("Студент успешно создан.");
        }

        public static Speciality GetOrCreateSpeciality()
        {
            Console.WriteLine("Введите название специальности:");
            string name = Console.ReadLine();

            Speciality speciality = DB.specialties.FirstOrDefault(s => s.Name == name);
            if (speciality == null)
            {

                Console.WriteLine("Введите сокращенное название специальности:");
                string abbreviation = Console.ReadLine();

                speciality = new Speciality(name, abbreviation);
                DB.specialties.Add(speciality);
            }
            return speciality;
        }

        public static Pair GetOrCreatePair()
        {
            Console.WriteLine("Введите начало пары (в формате чч:мм):");
            string pairStart = Console.ReadLine();
            TimeSpan p_Start = TimeSpan.Parse(pairStart);

            Console.WriteLine("Введите конец пары (в формате чч:мм):");
            string pairEnd =  Console.ReadLine();
            TimeSpan p_End = TimeSpan.Parse(pairEnd);

            Pair pair = DB.pairs.FirstOrDefault(p => p.Time_Pair_Start == p_Start && p.Time_Pair_End == p_End);
            if (pair == null)
            {

                Console.WriteLine("Введите время начала перерыва (в формате чч:мм):");
                string timeBreakStart = Console.ReadLine();
                TimeSpan t_breakStart = TimeSpan.Parse(timeBreakStart);

                Console.WriteLine("Введите время окончания перерыва (в формате чч:мм):");
                string timeBreakEnd = Console.ReadLine();
                TimeSpan t_breakEnd = TimeSpan.Parse(timeBreakEnd);

                Shift shift = GetOrCreateShift();

                pair = new Pair(p_Start, p_End, t_breakStart, t_breakEnd, shift);
                DB.pairs.Add(pair);
            }
            return pair;
        }

        static public Shift GetOrCreateShift()
        {
            Console.WriteLine("Введите название смены:");
            string name = Console.ReadLine();

            Shift shift = DB.shifts.FirstOrDefault(s => s.Name == name);
            if (shift == null)
            {
                shift = new Shift(name);
                DB.shifts.Add(shift);
            }

            return shift;
        }


        static public Employee GetOrCreateEmployee()
        {
            Console.WriteLine("Введите ФИО преподавателя:");
            string employeeName = Console.ReadLine();
            Employee employee = DB.employees.FirstOrDefault(e => $"{e.Name} {e.Surname} {e.Patronymic}".ToLower() == employeeName.ToLower());
            if (employee == null)
            {

                Console.WriteLine("Введите имя сотрудника:");
                string name = Console.ReadLine();

                Console.WriteLine("Введите фамилию сотрудника:");
                string surname = Console.ReadLine();

                Console.WriteLine("Введите отчество сотрудника:");
                string patronymic = Console.ReadLine();

                Position position = GetOrCreatePosition();
                employee = new Employee(name, surname, patronymic, position);
                DB.employees.Add(employee);
            }
            return employee;
        }

        static public Position GetOrCreatePosition()
        {
            Console.WriteLine("Введите название должности:");
            string jobTitleName = Console.ReadLine();

            Position position = DB.positions.FirstOrDefault(j => j.Title.ToLower() == jobTitleName.ToLower());
            if (position == null)
            {
                
                Console.WriteLine("Введите название должности:");
                string name = Console.ReadLine();
    
                Console.WriteLine("Введите зарплату должности:");
                int.TryParse(Console.ReadLine(), out int salary);
    
                Console.WriteLine("Введите название подразделения:");
                string subdivisionName = Console.ReadLine();
                Division division = GetOrCreateDivision();
                Position speciality = new Position(name, salary, division);
                DB.positions.Add(speciality);
                Console.WriteLine("Должность успешно создана.");
            }


            return position;
        }


        static public Division GetOrCreateDivision()
        {
            Console.WriteLine("Введите имя подразделения");
            string name = Console.ReadLine();
            
            Division subdivision = DB.divisions.FirstOrDefault(el => el.Name == name);

            if (subdivision == null)
            {

                Employee employee = GetOrCreateEmployee();
                Organization organization = GetOrCreateOrganization();
                subdivision = new Division(name, employee, organization);
                DB.divisions.Add(subdivision);
                Console.WriteLine("подразделение успешно создано.");
            }
            
            return subdivision;

        }

        static public Organisation GetOrCreateOrganization()
        {
            return null; //Нет человека для выполнения варианта
        }

        static public Body GetOrCreateBody()
        {
            return null; //Нет человека для выполнения варианта
        }
        static public TypeOfActivity GetOrCreateTypeOfActivity()
        {
            return null;
        }
    }
}
