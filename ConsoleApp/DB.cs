using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class DB
    {
        public static readonly List<Lesson> lessons = new List<Lesson>();
        public static readonly List<Classroom> classrooms = new List<Classroom>();
        public static readonly List<Discipline> disciplines = new List<Discipline>();
        public static readonly List<Group> groups = new List<Group>();
        public static readonly List<Speciality> specialties = new List<Speciality>();
        public static readonly List<Pair> pairs = new List<Pair>();
        public static readonly List<Shift> shifts = new List<Shift>();
        public static readonly List<Employee> employees = new List<Employee>();
        public static readonly List<Position> positions = new List<Position>();
        public static readonly List<Body> bodies = new List<Body>();
        public static readonly List<TypeOfActivity> typeOfActivities = new List<TypeOfActivity>();
        public static readonly List<Organisation> organisations = new List<Organisation>();
        public static readonly List<Student> students = new List<Student>();
        public static readonly List<Division> divisions = new List<Division>();
    }
}
