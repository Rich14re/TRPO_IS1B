using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    internal class Lesson
    {
        private DateTime dateHeld;
        private Discipline disciplineLink;
        private Employee employeeLink;
        private Classroom classroomLink;
        private Group groupLink;
        private Pair pairLink;
        private Lesson lessonTypeLink;

        public Lesson(DateTime dateHeld, Discipline disciplineLink, Employee employeeLink, Classroom classroomLink, Group groupLink, Pair pairLink, Lesson lessonTypeLink)
        {
            this.dateHeld = dateHeld != default ? dateHeld : DateTime.Now;
            this.disciplineLink = disciplineLink;
            this.employeeLink = employeeLink;
            this.classroomLink = classroomLink;
            this.groupLink = groupLink;
            this.pairLink = pairLink;
            this.lessonTypeLink = lessonTypeLink;
        }
    }
}

