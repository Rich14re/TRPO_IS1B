using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibrary
{

    internal class Discipline
    {
        public string name;
        public string shortname;
        public Discipline(string name, string shortname)
        {
            this.name = name;
            this.shortname = shortname;
        }
        public string Name
        {
            get { return name; }
        }
    }
    
}
