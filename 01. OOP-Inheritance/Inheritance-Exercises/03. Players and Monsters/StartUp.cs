﻿using System;

namespace PlayersAndMonsters
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string username = Console.ReadLine();
            int level = int.Parse(Console.ReadLine());
            DarkKnight darkKinght = new DarkKnight(username, level);

            Console.WriteLine(darkKinght);
        }
    }
}
