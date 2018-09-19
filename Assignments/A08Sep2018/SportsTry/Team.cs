using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sportsleague1
{
    class Team
    {
        public string Name;
        public Player[] TeamPlayers = new Player[LeagueStats.MaxPlayersPerMatch];

        public  void setTeam()
        {
            //public Team[] Teams = new Team();
            Console.WriteLine("Enter the name of team");
            Name = Console.ReadLine();
            
            for (int PlayerCount=0; PlayerCount<LeagueStats.MaxPlayersPerMatch;PlayerCount++)
            {
                TeamPlayers[PlayerCount] = new Player();
                Console.WriteLine("enter the name of player {0} of {1}", PlayerCount, Name);
                TeamPlayers[PlayerCount].Name = Console.ReadLine();
            }
        }
        public void DisplayTeam()
        {
            for (int PlayerCount = 0; PlayerCount < 3; PlayerCount++)
            {
                Console.WriteLine(TeamPlayers[PlayerCount].Name);
            }
        }
    }
}
