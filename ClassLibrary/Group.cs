using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    internal class Group
    {
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
    }
}
