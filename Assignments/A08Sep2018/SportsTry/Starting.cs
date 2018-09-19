using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sportsleague1
{
    class Starting
    {
        public static void Main(string[] ar)
        {
            Team Team1 = new Team();
            Team Team2 = new Team();

            Team1.setTeam();
            Team2.setTeam();

            

            Match match1 = new Match();
            //-----****** Assigning memory to Team1 & 2 ***-----------
            match1.TeamScore1 = new TeamScore();
            match1.TeamScore2 = new TeamScore();
            ///---** copying team names from team to match teams**-------
            match1.TeamScore1.Name = Team1.Name;
            match1.TeamScore1.TeamPlayers = Team1.TeamPlayers;
            match1.TeamScore2.Name = Team2.Name;
            match1.TeamScore2.TeamPlayers = Team2.TeamPlayers;

            match1.TeamScore1.SetScores(Team1);
            match1.TeamScore2.SetScores(Team2);

            match1.GetHighestScorerOfMatch();
            match1.GetManOfMatch();

            Console.WriteLine(match1.TeamScore1.IsWinner);
            Console.WriteLine(match1.TeamScore2.IsWinner);
           string a= match1.TeamScore1.HighestScorer.Name;
            Console.WriteLine(a);
             a = match1.TeamScore2.HighestScorer.Name;
            Console.WriteLine(a);

            Console.ReadLine();
        }
    }
}
