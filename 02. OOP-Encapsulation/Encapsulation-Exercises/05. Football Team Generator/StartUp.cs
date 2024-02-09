using System;
using System.Collections.Generic;
using System.Linq;

namespace FootballTeamGenerator
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            List<Team> teams = new List<Team>();
            string line = Console.ReadLine();

            while (line != "END")
            {
                string[] command = line.Split(' ');
                string action = command[0];
                string teamName = command[1];

                try
                {
                    if (action == "Team")
                    {
                        teams.Add(new Team(teamName));
                    }
                    else if (action == "Add")
                    {
                        Team targetTeam = ValidateTargetTeam(teams, teamName);

                        Player player = new Player(command[2],
                            int.Parse(command[3]),
                            int.Parse(command[4]),
                            int.Parse(command[5]),
                            int.Parse(command[6]),
                            int.Parse(command[7]));

                        targetTeam.AddPlayer(player);
                    }
                    else if (action == "Remove")
                    {
                        string playerName = command[2];

                        Team targetTeam = ValidateTargetTeam(teams, teamName);
                        targetTeam.RemovePlayer(playerName);
                    }
                    else if (action == "Ration")
                    {
                        Team targetTeam = ValidateTargetTeam(teams, teamName);
                        Console.WriteLine($"{teamName} - {targetTeam.Rating}");
                    }
                }
                catch(Exception exception) 
                {
                    Console.WriteLine(exception.Message);
                }
            }
        }

        private static Team ValidateTargetTeam(List<Team> teams, string teamName)
        {
            Team targetTeam = teams.FirstOrDefault(t => t.Name == teamName);

            if (targetTeam == null)
            {
                throw new Exception($"Team {teamName} does not exist.");
            }
            return targetTeam;
        }
    }
}
