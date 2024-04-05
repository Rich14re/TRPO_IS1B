using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    //https://docs.google.com/document/d/1dhWsZqo-d1x4uk0y45lDVnu4H91wRvpRWKJ0lfCizxY/edit
    public class Employee
    {
        private readonly string name;
        private readonly string surname;
        private readonly string patronymic;
        private readonly Position position;

        public Employee(string name, string surname, string patronymic, Position position)
        {
            this.name = name;
            this.surname = surname;
            this.patronymic = patronymic; 
            this.position = position;
        }
        public string Name { get { return name; } }
        public string Surname { get {  return surname; } }
        public string Patronymic { get {  return patronymic; } }

    }
}
