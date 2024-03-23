using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /// <summary>
    /// https://docs.google.com/document/d/1QSQdwb3s6IOh4avDr_-vpiYnII_80yUAVL3H_JkLNXQ/edit 8 вариант
    /// </summary>
    public class Shift
    {
        private string name;
        private string date;

        public Shift(string name, string date)
        {
            this.name = name;
            this.date = date;
        }

        public Shift(string name) : this(name, DateTime.Now.ToString())
        {
        }

        public string Name
        {
            get { return name; }
        }

        public string Date
        {
            get { return date; }
        }
    }
}
