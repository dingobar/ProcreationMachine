using System;
using System.Collections.Generic;
using ProcreationMachine.Utils;
using ProcreationMachine.Models.Exceptions;

namespace ProcreationMachine.Models
{
    class Person
    {
        private string name;
        private List<Person> children = new List<Person>();
        public Person(string name)
        {
            Name = name;
        }

        public string Name { get => name; set => name = value; }
        public List<Person> Children { get => children; set => children = value; }

        public static Person Procreate(Person p1, Person p2)
        {
            if (p1.Equals(p2))
            {
                throw new TryingToReproduceWithSelfException("Cannot procreate with self!!!");
            }
            var baby = new Person(
                RandomNameGenerator.GenerateName()
            );
            p1.Children.Add(baby);
            p2.Children.Add(baby);
            return baby;
        }

        public Person ProcreateWith(Person withPerson)
        {
            return Procreate(this, withPerson);
        }

        public override string ToString()
        {
            string message = $"This is {Name}, who has {Children.Count} children.";
            for (int i = 0; i <= Children.Count - 1; i++)
            {
                if (Children.Count == 1)
                {
                    message += $" Its name is {Children[i].Name}.";
                }
                else if (i == 0)
                {
                    message += $" Their names are {Children[i].Name}";
                }
                else if (i == Children.Count - 1)
                {
                    message += $", and {Children[i].Name}.";
                }
                else
                {
                    message += $", {Children[i].Name}";
                }
            }
            return message;
        }
    }
}