using System;
using System.Collections.Generic;
using System.Linq;

namespace PersonsInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            var persone = new List<Person>();

            for (int i = 0; i < lines; i++)
            {
                var commandArguments = Console.ReadLine().Split(' ');
                var person = new Person(commandArguments[0], commandArguments[1], int.Parse(commandArguments[2]));
                persone.Add(person);
            }

            persone.OrderBy(p => p.FirstName)
                .ThenBy(p => p.Age)
                .ToList()
                .ForEach(p => Console.WriteLine(p.ToString()));
        }
    }
}
