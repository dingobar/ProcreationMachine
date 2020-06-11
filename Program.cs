using System;
using System.Collections.Generic;
using System.Linq;
using ProcreationMachine.Models;

namespace ProcreationMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the hyper realistic reproduction simulator!");
            Console.WriteLine("This simulator implements a 1:1 implementation of evolutionary biology in C#.");
            var people = new List<Person>();
            people.Add(new Person("Nils"));
            people.Add(new Person("Arne"));

            Random r = new Random();
            for (int i = 0; i < 1000; i++)
            {
                var selectedPeople = people.OrderBy(x => r.Next()).Take(2).ToList();
                people.Add(selectedPeople[0].ProcreateWith(selectedPeople[1]));
            }

            foreach (Person person in people){
                Console.WriteLine(person);
            }
        }
    }
}
