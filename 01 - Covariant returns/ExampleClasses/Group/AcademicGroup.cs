using CovariantReturns.People;
using System.Collections.Generic;

namespace CovariantReturns.Group
{
    abstract class AcademicGroup
    {
        public string Description { get; set; }
        public abstract IEnumerable<Person> ListMembersClassic();
        public abstract IEnumerable<Person> ListMembersCovariant();
    }
}
