using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    /// <summary>
    /// https://docs.google.com/document/d/1KZXfKJussGflgWnWylGbFrwmdcn3liYKIsgmtxB1mN0/edit 1 вариант
    /// </summary>
    public class Lesson
    {
        private string dateHeld;
        private Discipline disciplineLink;
        private Employee employeeLink;
        private Classroom classroomLink;
        private Group groupLink;
        private Pair pairLink;
        private Lesson lessonTypeLink;

        public Lesson(string dateHeld, Discipline disciplineLink, Employee employeeLink, Classroom classroomLink, Group groupLink, Pair pairLink, Lesson lessonTypeLink)
        {
            this.dateHeld = dateHeld != default ? dateHeld : DateTime.Now.ToString();
            this.disciplineLink = disciplineLink;
            this.employeeLink = employeeLink;
            this.classroomLink = classroomLink;
            this.groupLink = groupLink;
            this.pairLink = pairLink;
            this.lessonTypeLink = lessonTypeLink;
        }
    }
}

