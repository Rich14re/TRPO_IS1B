using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /// <summary>
    /// https://docs.google.com/document/d/1FrtPd2tz85cDVhZCYXqL0wrByPjNbd6kUbjXzOzfLPc/edit 5 вариант
    /// </summary>
    public class Student
    {
        private readonly string surname;
        private readonly string name;
        private readonly string patronymic;
        private readonly Group group;
        private readonly DateTime birth;

        public Student(string surname, string name, string patronymic, Group group, DateTime birth)
        {
            this.surname = surname;
            this.name = name;
            this.patronymic = patronymic;
            this.group = group;
            if (birth != null)
            {
                this.birth = birth;
            }
            else
            {
                this.birth = DateTime.Today;
            }
        }

        public string Surname
        {
            get { return surname; }
        }
        public string Name
        {
            get { return name; }
        }
        public string Patronymic
        {
            get { return patronymic; }
        }
        public Group Group
        {
            get { return group; }
        }
        public DateTime Birth
        {
            get { return birth; }
        }
    }
}
