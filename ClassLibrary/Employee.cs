using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    internal class Employee
    {
        private string name;
        private string surname;
        private string patronymic;
        private Position position;

        public Employee(string name, string surname, string patronymic, Position position)
        {
            this.name = name;
            this.surname = surname;
            this.patronymic = patronymic; 
            this.position = position;
        }
    }
}
