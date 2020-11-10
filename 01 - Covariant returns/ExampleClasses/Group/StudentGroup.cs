using CovariantReturns.People;
using System.Collections.Generic;

namespace CovariantReturns.Group
{
    class StudentGroup : AcademicGroup
    {
        private Student[] students;

        public StudentGroup(Student[] students)
        {
            this.students = students;
        }

        public override IEnumerable<Person> ListMembersClassic()
        {
            return students;
        }

        public override IEnumerable<Student> ListMembersCovariant()
        {
            return students;
        }
    }
}
