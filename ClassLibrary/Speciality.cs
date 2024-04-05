using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    internal class Speciality
    {

        private string name;
        private string abbreviation;
        private string date;

        public Speciality(string name, string abbreviation, string date)
        {
            this.name = name;
            this.abbreviation = abbreviation;
            this.date = DateTime.Today.ToString();

        }
    }
}
