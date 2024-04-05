using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /// <summary>
    /// https://docs.google.com/document/d/10XwtkjNB6-lRehWP_7qbgWC1nn_oIpa28ezyPXX3B28/edit 2 вариант
    /// </summary>
    public class Classroom
    {
        private readonly string name;
        public readonly Employee employee;
        private readonly int places;
        private readonly int windows;
        public readonly Equipment equipment;
        public Classroom(string name, Employee employee, int count_places, int count_windows, Equipment equipment)
        {
            this.name = name;
            this.employee = employee;
            this.places = count_places;
            this.windows = count_windows;
            this.equipment = equipment;
        }

        public string Number
        {
            get { return name; }
        }


        public int Places
        {
            get { return places; }
        }

        public int Windows
        {
            get { return windows; }
        }
    }

}

