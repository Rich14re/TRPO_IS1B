using System;

namespace ClassLibrary
{
    /// <summary>
    /// https://docs.google.com/document/d/1qZEaADy71rJCOuNSTpyhh-f-NhSL2a6DCm88EgFO20o/edit 4 вариант
    /// </summary>
    public class Group
    {
        private readonly string name;
        private readonly string shortname;
        private readonly int quantity;
        private readonly int year;
        private readonly Speciality speciality;
        public readonly Employee employee;
        //Изменения 1
        public Group(string name, string shortname, int quantity, Speciality speciality, Employee employee, int year = -1)
        {
            this.name = name;
            this.shortname = shortname;
            this.quantity = quantity;
            this.speciality = speciality;
            this.employee = employee;
            if (year == -1)
            {
                this.year = DateTime.Now.Year;
            }
            else
            {
                this.year = year;
            }
        }

        public string Name
        {
            get { return name; }
        }
        public string Shortname
        {
            get { return shortname; }
        }

        public int Quantity
        {
            get { return quantity; }
        }

        public int Year
        {
            get { return year; }
        }

        public Speciality Speciality
        {
            get { return speciality; }
        }

        public Employee Employee
        {
            get { return employee; }
        }
    }
}
