using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sportsleague
{
    public class TeamScore : Team
    {
        public bool IsWinner = false;
        private int TotalTeamScore = 0;
        private PlayerScore[] PlayerScores = new PlayerScore[11];
        internal PlayerScore HighestScorer;

        public void SetScores(Team pTeam)
        {
           
            for( int Pc=0; Pc<LeagueStats.MaxPlayersPerMatch; Pc++)
            {
                PlayerScores[Pc] = new PlayerScore();
                PlayerScores[Pc].PlayerDetails = new Player();
                PlayerScores[Pc].PlayerDetails = pTeam.TeamPlayers[Pc];
                Console.WriteLine("enter score of {0} ", PlayerScores[Pc].PlayerDetails.Name);
                PlayerScores[Pc].Score = int.Parse(Console.ReadLine());
                TotalTeamScore += PlayerScores[Pc].Score;
                Console.WriteLine("team totle   "+TotalTeamScore);
                HighestScorer = new PlayerScore();
               if( HighestScorer.Score< PlayerScores[Pc].Score)
                {
                    HighestScorer = PlayerScores[Pc];
                }
            }
        }
        public int GetTeamTotalScores()
        {
            return TotalTeamScore;
        }
        public string GetHighestScorer()
        {
            return HighestScorer.PlayerDetails.Name;
        }

    }
}
