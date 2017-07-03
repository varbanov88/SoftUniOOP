using System;
using System.Linq;


public class StartUp
{
    public static void Main()
    {
        var teamInfo = Console.ReadLine().Split(';');
        var team = new Team(teamInfo[1]);

        string inputLine;
        while ((inputLine = Console.ReadLine()) != "END")
        {
            var tokens = inputLine.Split(';');

            try
            {
                switch (tokens[0])
                {
                    case "Add":
                        var playerName = tokens[2];
                        var skills = tokens.Skip(3).Select(int.Parse).ToArray();
                        var player = new Player(playerName, skills[0], skills[1], skills[2], skills[3], skills[4]);
                        team.AddPlayer(tokens[1], player);
                        break;

                    case "Remove":
                        var plName = tokens[2];
                        var skils = tokens.Skip(3).Select(int.Parse).ToArray();
                        team.RemovePlayer(tokens[1], plName);
                        break;

                    case "Rating":
                        team.ShowTeamRating(tokens[1]);
                        break;
                }

            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}

