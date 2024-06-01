using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Body
    {
       /// <summary>
       /// https://docs.google.com/document/d/13_TXjBoKn0TzKMcWP9A6jX2vyQEgcxBc4vY1CfJn9ps/edit?pli=1 13 вариант
       /// </summary>
        private readonly string name;
        private readonly string address;
        private readonly Employee comendante;
        private readonly Organisation organization;
        public Body(string name, string address, Employee comendante, Organisation organization)
        {
            this.name = name;
            this.address = address;
            this.comendante = comendante;
            this.organization = organization;
        }
        public string Name { get { return name; } }
        public string Address { get { return address; } }

        public Employee Comendante => comendante;

        public Organisation Organization => organization;
    }
}
