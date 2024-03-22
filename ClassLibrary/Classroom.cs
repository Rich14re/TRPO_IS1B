using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    internal class Classroom
    {
        private string date;
        private string name;
        private Employee employee;
        private string window;
        private Equipment equipment;
        private string seat;
        public Classroom(string date, string name, Employee employee, string window, Equipment equipment, string seat)
        {
            this.date = DateTime.Today.ToString();
            this.name = name;
            this.employee = employee;
            this.window = window;
            this.equipment = equipment;
            this.seat = seat;
        }

    }
    
}
