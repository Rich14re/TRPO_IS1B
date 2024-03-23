using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    internal class Position
    {
        /// <summary>
        /// https://docs.google.com/document/d/1yBWzXRuxmOQiPQs9TyNx8tNgq6nWF42Sjn-mgT_-5nY/edit?usp=drive_link 10 вариант
        /// </summary>
        private string title;
        private double salary;
        private Division division;

        public Position(string title, double salary, Division division)
        {
            this.title = title;
            this.salary = salary;
            this.division = division;
        }
    }
}
