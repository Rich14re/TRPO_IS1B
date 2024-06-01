using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
        private readonly Employee employee;
        private readonly int places;
        private readonly int windows;
        private readonly List<Equipment> equipments;
        public Classroom(string name, Employee employee, int count_places, int count_windows)
        {
            this.name = name;
            this.employee = employee;
            this.places = count_places;
            this.windows = count_windows;
            this.equipments = new List<Equipment>();
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

        public List<Equipment> Equipment { get { return equipments; } }
        public Employee Employee { get { return employee; } }
    }
}
