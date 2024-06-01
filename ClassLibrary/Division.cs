using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /// <summary>
    /// https://docs.google.com/document/d/1XUtn0QpVUQmailvo24lJ3XjJT5NP0SPjzi_vPOF1N9A/edit 11 âàðèàíò
    /// </summary>
    public class Division
    {
        private readonly string name;
        private readonly Employee director;
        private readonly Organisation organization;

        public Division(string name, Employee director, Organisation organization)
        {
            this.name = name;
            this.director = director;
            this.organization = organization;
        }

        public string Name => name;
        public Employee Employee => director;
        public Organisation Organization => organization;
    }
}
