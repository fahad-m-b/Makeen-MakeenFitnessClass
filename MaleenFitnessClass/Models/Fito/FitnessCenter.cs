using MaleenFitnessClass.Models.Fito;
using MaleenFitnessClass.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakeenFitnessClass.Models.Fito
{
    public class FitnessCenter
    {
        public List<Member> Members { get; private set; }
        public List<Trainer> Trainers { get; private set; }
        public List<FitnessClass> Classes { get; private set; }

        public FitnessCenter()
        {
            Members = new List<Member>();
            Trainers = new List<Trainer>();
            Classes = new List<FitnessClass>();
        }

        public void AddMember(Member member)
        {
            Members.Add(member);
            Console.WriteLine($"Member {member.Name} added.");
        }

        public void AddTrainer(Trainer trainer)
        {
            Trainers.Add(trainer);
            Console.WriteLine($"Trainer {trainer.Name} added.");
        }

        public void CreateClass(FitnessClass fitnessClass)
        {
            Classes.Add(fitnessClass);
            Console.WriteLine($"Class {fitnessClass.ClassName} created.");
        }

        public void AssignTrainerToClass(int trainerId, int classIndex)
        {
            if (trainerId < 0 || trainerId >= Trainers.Count || classIndex < 0 || classIndex >= Classes.Count)
            {
                Console.WriteLine("Invalid trainer or class index.");
                return;
            }
            Trainers[trainerId].AssignToClass(Classes[classIndex]);
        }

        public void RegisterMemberToClass(int memberId, int classIndex)
        {
            if (memberId < 0 || memberId >= Members.Count || classIndex < 0 || classIndex >= Classes.Count)
            {
                Console.WriteLine("Invalid member or class index.");
                return;
            }
            Members[memberId].RegisterToClass(Classes[classIndex]);
        }

        public void ShowAllClasses()
        {
            Console.WriteLine("\n--- All Fitness Classes ---");
            foreach (var c in Classes)
                c.ShowClassDetails();
        }
    }
}
