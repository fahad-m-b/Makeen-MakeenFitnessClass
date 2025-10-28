using MaleenFitnessClass.Models.Enums;
using MaleenFitnessClass.Models.Fito;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaleenFitnessClass.Models.Users
{
    public class Member : Person
    {
        public MemberType MembershipType { get; set; }
        public List<FitnessClass> RegisteredClasses { get; private set; }

        public Member(int id, string name, Gender gender, int age, MemberType membershipType)
            : base(id, name, gender, age)
        {
            MembershipType = membershipType;
            RegisteredClasses = new List<FitnessClass>();
        }

        public void RegisterToClass(FitnessClass fitnessClass)
        {
            if (!RegisteredClasses.Contains(fitnessClass))
            {
                RegisteredClasses.Add(fitnessClass);
                fitnessClass.AddMember(this);
                Console.WriteLine($"{Name} registered to class {fitnessClass.ClassName}");
            }
            else
            {
                Console.WriteLine($"{Name} is already registered in this class.");
            }

        }
        public void ShowRegisteredClasses()
        {
            Console.WriteLine($"--- Classes for {Name} ---");
            if (RegisteredClasses.Count == 0)
                Console.WriteLine("No classes registered.");
            else
                foreach (var c in RegisteredClasses)
                    Console.WriteLine($"{c.ClassName} - {c.Schedule}");
        }

        public double CalculateMembershipCost()
        {
            switch (MembershipType)
            {
                case MemberType.Monthly: return 20.0;
                case MemberType.Quarterly: return 50.0;
                case MemberType.Yearly: return 180.0;
                default: return 0.0;
            }
        }

        public override void DisplayInfo()
        {
            Console.WriteLine($"Membership: {MembershipType}, Cost: {CalculateMembershipCost()} OMR");
        }
    }

    }
