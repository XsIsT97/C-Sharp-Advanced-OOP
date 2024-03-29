﻿using System;
using System.Collections.Generic;
using PersonsInfo;

namespace PersonsInfo
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int numberOfLines = int.Parse(Console.ReadLine());

            List<Person> persons = new List<Person>();

            for (int i = 0; i < numberOfLines; i++)
            {
                string[] input = Console.ReadLine().Split();
                try
                {
                    Person person = new Person(input[0], input[1], int.Parse(input[2]), decimal.Parse(input[3]));
                    persons.Add(person);
                }
                catch (ArgumentException e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Team team = new Team("SoftUni");

            foreach (var person in persons)
            {
                team.AddPlayer(person);
            }

            Console.WriteLine($"First team has {team.FirstTeam.Count} players.");
            Console.WriteLine($"Reserve team has {team.ReserveTeam.Count} players.");
        }
    }
}
