using MaleenFitnessClass.Models.Enums;
using MaleenFitnessClass.Models.Fito;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaleenFitnessClass.Models.Users
{
    public class Trainer : Person
    {
        public string Specialization { get; set; }
        public List<FitnessClass> AssignedClasses { get; private set; }

        public Trainer(int id, string name, Gender gender, int age, string specialization)
            : base(id, name, gender, age)
        {
            Specialization = specialization;
            AssignedClasses = new List<FitnessClass>();
        }

        public void AssignToClass(FitnessClass fitnessClass)
        {
            if (!AssignedClasses.Contains(fitnessClass))
            {
                AssignedClasses.Add(fitnessClass);
                fitnessClass.Trainer = this;
                Console.WriteLine($"{Name} assigned to class {fitnessClass.ClassName}");
            }
            else
            {
                Console.WriteLine($"{Name} is already assigned to this class.");
            }
        }

        public void ShowAssignedClasses()
        {
            Console.WriteLine($"--- Classes assigned to {Name} ---");
            if (AssignedClasses.Count == 0)
                Console.WriteLine("No classes assigned.");
            else
                foreach (var c in AssignedClasses)
                    Console.WriteLine($"{c.ClassName} - {c.Schedule}");
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Specialization: {Specialization}");
        }
    }
}
