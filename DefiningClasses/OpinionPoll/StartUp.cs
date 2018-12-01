using System;
using System.Linq;

namespace _04OpinionPoll
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            People people = new People();

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split();

                string name = input[0];
                int age = int.Parse(input[1]);

                Person person = new Person(name, age);

                people.AddMember(person);
            }

            var olderPeople = people.Get30sAndAbove();

            foreach (var person in olderPeople)
            {
                Console.WriteLine($"{person.Name} - {person.Age}");
            }

        }
    }
}
