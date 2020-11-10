using CovariantReturns.Group;
using CovariantReturns.People;
using System;

namespace CovariantReturns
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentGroup intMembers = new StudentGroup(new Student[]
            {
                new Student() { Name = "Daniel Carvalho", StudentID = 100 },
                new Student() { Name = "Reihaneh Sadeghi", StudentID = 101 },
                new Student() { Name = "Mat Motaharan ", StudentID = 103 },
                new Student() { Name = "Wallacce Correa", StudentID = 104 }
            })
            { Description = "Innovators in Technology" };

            ListMembersClassic(intMembers);
            ListMembersCovariant(intMembers);

            Console.ReadLine();
        }

        static void ListMembersClassic(StudentGroup members)
        {
            Console.WriteLine($"* CLASSIC APPROACH");
            Console.WriteLine($"* {members.Description} members");

            foreach (var member in members.ListMembersClassic())
            {
                Console.WriteLine($"{((Student)member).StudentID} - {member.Name}");
            }

            Console.WriteLine("");
        }

        static void ListMembersCovariant(StudentGroup members)
        {
            Console.WriteLine($"* COVARIANT RETURN APPROACH");
            Console.WriteLine($"* {members.Description} members");

            foreach (var member in members.ListMembersCovariant())
            {
                Console.WriteLine($"{member.StudentID} - {member.Name}");
            }

            Console.WriteLine("");
        }
    }
}
