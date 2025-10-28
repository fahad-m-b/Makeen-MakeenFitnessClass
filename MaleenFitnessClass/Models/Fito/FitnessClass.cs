using MaleenFitnessClass.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaleenFitnessClass.Models.Fito
{
    public class FitnessClass
    {
        public string ClassName { get; set; }
        public string Schedule { get; set; }
        public Trainer Trainer { get; set; }
        public List<Member> EnrolledMembers { get; private set; }

        public FitnessClass(string className, string schedule)
        {
            ClassName = className;
            Schedule = schedule;
            EnrolledMembers = new List<Member>();
        }

        public void AddMember(Member member)
        {
            if (!EnrolledMembers.Contains(member))
                EnrolledMembers.Add(member);
        }

        public void ShowClassDetails()
        {
            Console.WriteLine($"\nClass: {ClassName}");
            Console.WriteLine($"Schedule: {Schedule}");
            Console.WriteLine($"Trainer: {(Trainer != null ? Trainer.Name : "No trainer assigned")}");
            Console.WriteLine("Enrolled Members:");
            if (EnrolledMembers.Count == 0)
                Console.WriteLine("No members yet.");
            else
                foreach (var m in EnrolledMembers)
                    Console.WriteLine($"- {m.Name}");
        }
    }
}
