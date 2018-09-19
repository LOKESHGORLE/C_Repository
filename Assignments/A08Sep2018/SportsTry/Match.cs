using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sportsleague1
{
    class Match
    {
        public PlayerScore HighestScorer { get; set; }
        public TeamScore TeamScore1 { get; set; }
        public TeamScore TeamScore2 { get; set; }
        public PlayerScore ManOfTheMatch { get; set; }

        public void GetManOfMatch()
        {
             
            if (TeamScore1.IsWinner)
            {
                ManOfTheMatch = TeamScore1.HighestScorer;
                Console.WriteLine("MAN OF MATCH : " + ManOfTheMatch.Name);
            }
            else
            {
                ManOfTheMatch = TeamScore2.HighestScorer;
                Console.WriteLine("MAN OF MATCH : " + ManOfTheMatch.Name);
            }
        }
            public void GetHighestScorerOfMatch()
            {
                if (TeamScore1.HighestScorer.Score > TeamScore2.HighestScorer.Score)
                {
                    HighestScorer= TeamScore1.HighestScorer;
                    Console.WriteLine("HIGHESTSCORER IS : " + HighestScorer.Name);
                }
                else
                {
                    HighestScorer = TeamScore2.HighestScorer;
                    Console.WriteLine("HIGHESTSCORER IS : " + HighestScorer.Name);
                }

            }
        
        //public void SetScores(Team pTeam)
        //{
        //    for (int Pc = 0; Pc < LeagueStats.MaxPlayersPerMatch; Pc++)
        //    {
               
        //        TeamScore1.PlayerScores[Pc] = new PlayerScore();
        //        TeamScore1.PlayerScores[Pc].Name = pTeam.TeamPlayers[Pc].Name;
        //        Console.WriteLine("enter score of {0} ", TeamScore1.PlayerScores[Pc].Name);
        //        TeamScore1.PlayerScores[Pc].Score = int.Parse(Console.ReadLine());
        //    }
        //}
    }
}
