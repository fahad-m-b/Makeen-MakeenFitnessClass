using MakeenFitnessClass.Models.Fito;
using MaleenFitnessClass.Models.Enums;
using MaleenFitnessClass.Models.Fito;
using MaleenFitnessClass.Models.Users;

namespace MaleenFitnessClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FitnessCenter center = new FitnessCenter();

            Trainer t1 = new Trainer(0, "Ali", Gender.Male, 30, "Cardio");
            Trainer t2 = new Trainer(1, "Sara", Gender.Female, 28, "Yoga");
            center.AddTrainer(t1);
            center.AddTrainer(t2);

            Member m1 = new Member(0, "Fahad", Gender.Male, 22, MemberType.Monthly);
            Member m2 = new Member(1, "Omar", Gender.Male, 25, MemberType.Yearly);
            center.AddMember(m1);
            center.AddMember(m2);

            FitnessClass c1 = new FitnessClass("Morning Yoga", "8 AM");
            FitnessClass c2 = new FitnessClass("Evening Cardio", "6 PM");
            center.CreateClass(c1);
            center.CreateClass(c2);

            center.AssignTrainerToClass(1, 0);
            center.AssignTrainerToClass(0, 1);

            center.RegisterMemberToClass(0, 0);
            center.RegisterMemberToClass(1, 1);
            center.RegisterMemberToClass(0, 1);

            center.ShowAllClasses();
        }
    }
}
