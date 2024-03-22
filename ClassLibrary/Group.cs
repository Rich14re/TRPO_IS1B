using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /// <summary>
    /// https://docs.google.com/document/d/1qZEaADy71rJCOuNSTpyhh-f-NhSL2a6DCm88EgFO20o/edit 4 вариант
    /// </summary>
    public class Group
    {
        //Изменения 1
        private string name;
        private string shortname;
        private int quantity;
        private int year;
        private Speciality speciality;
        private Employee employee;
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
    }
}
