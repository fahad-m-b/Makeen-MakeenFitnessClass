using MaleenFitnessClass.Models.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaleenFitnessClass.Models.Users
{
    public abstract class Person
    {

        public int Id { get; set; }
        public string Name { get; set; }
        public Gender gender { get; set; }
        public int Age { get; set; }
        public Person(int id, string name, Gender gender, int age)
        {
            Id = id;
            Name = name;
            this.gender = gender;
            Age = age;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"ID:{Id}\nName:{this.Name}\nAge:{Age}");
        }
    }
}
