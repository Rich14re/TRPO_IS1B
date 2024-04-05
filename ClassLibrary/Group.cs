﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ClassLibrary
{
    internal class Group
    {
        private readonly string name;
        private readonly string shortname;
        private readonly int quantity;
        private readonly int year;
        private readonly Speciality speciality;
        private readonly Employee employee;
        //Изменения 1
        public Group(string name, string shortname, int quantity, Speciality speciality, Employee classroomteatcher, int year = -1)
        {
            this.name = name;
            this.shortname = shortname;
            this.quantity = quantity;
            this.speciality = speciality;
            this.employee = employee;
            if (year == -1)
            {
                this.year = DateTime.Now.Year;
            }
            else
            {
                this.year = year;
            }
        }
        public string Name
        {
            get { return name; }
        }

        public string Shortname
        {
            get { return shortname; }
        }

        public int Quantity
        {
            get { return quantity; }
        }

        public int Year
        {
            get { return year; }
        }

        public Speciality Speciality
        {
            get { return speciality; }
        }

        public Employee Employee
        {
            get { return employee; }
        }
    }
}
