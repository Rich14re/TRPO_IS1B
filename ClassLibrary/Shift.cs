using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    internal class Shift
    {
        private string name;
        private DateTime date;

        public Shift(string name, DateTime date)
        {
            this.name = name;
            this.date = date;
        }

        public Shift(string name) : this(name, DateTime.Now)
        {
        }
    }
}
