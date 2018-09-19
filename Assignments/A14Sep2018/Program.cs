using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using sportsleague;

namespace A14Sep2018
{
    class CricketLeague
        {
            static void Main(string[] args)
            {

            PlayerScore score = new PlayerScore();
            










                Team Team1 = new Team();
                Team Team2 = new Team();

                Team1.setTeam();
                Team2.setTeam();
            

            //////_____________*****************************__________________///////
            //TeamScore[] Teams = new TeamScore[LeagueStats.MaxTeams];
             Match MatchSch = new Match();

                //MatchSch.TeamScore1.Name = Team1.Name;

                MatchSch.TeamScore1 = new TeamScore();
                MatchSch.TeamScore2 = new TeamScore();
                MatchSch.TeamScore1.Name = Team1.Name;
                MatchSch.TeamScore2.Name = Team2.Name;

                MatchSch.TeamScore1.SetScores(Team1);
                MatchSch.TeamScore2.SetScores(Team2);

                Console.WriteLine("-----------*****************-----------------\n\n\n");
                int ExitFlag = 1;
                do
                {
                    Console.WriteLine("1. To Know Winner\n" +
                        "2.Team1{0} HighestScorer\n" +
                        "3.Team2{1} HighestScorer\n" +
                        "4.Man Of The Match\n" +
                        "5.HighestScorer of Match\n", MatchSch.TeamScore1.Name, MatchSch.TeamScore2.Name);
                    int Option = int.Parse(Console.ReadLine());

                    switch (Option)
                    {
                        case 1:
                            if (MatchSch.TeamScore1.GetTeamTotalScores() > MatchSch.TeamScore2.GetTeamTotalScores())
                            {
                                MatchSch.TeamScore1.IsWinner = true;
                                Console.WriteLine("WINNER IS : " + MatchSch.TeamScore1.Name);
                            }
                            else
                            {
                                MatchSch.TeamScore2.IsWinner = true;
                                Console.WriteLine("WINNER IS : " + MatchSch.TeamScore2.Name);
                            }
                            break;
                        case 2:
                            Console.WriteLine("teAM 1 HIGHEST SCORER: " + MatchSch.TeamScore1.GetHighestScorer());
                            break;
                        case 3:
                            Console.WriteLine("teAM 2 HIGHEST SCORER: " + MatchSch.TeamScore2.GetHighestScorer());
                            break;
                        case 4:
                            MatchSch.GetManOfMatch();
                            //MoM = MatchSch.TeamScore1.IsWinner ? MatchSch.TeamScore1.HighestScorer.PlayerDetails.Name : MatchSch.TeamScore2.HighestScorer.PlayerDetails.Name;
                            //Console.WriteLine(MoM);
                            break;
                        case 5:
                            MatchSch.GetHighestScorerOfMatch();
                            break;



                    }
                } while (ExitFlag != 0);
                if (MatchSch.TeamScore1.GetTeamTotalScores() > MatchSch.TeamScore2.GetTeamTotalScores())
                {
                    MatchSch.TeamScore1.IsWinner = true;
                    Console.WriteLine("WINNER IS : " + MatchSch.TeamScore1.Name);
                }
                else
                {
                    MatchSch.TeamScore2.IsWinner = true;
                    Console.WriteLine("WINNER IS : " + MatchSch.TeamScore2.Name);
                }
                Console.WriteLine("teAM 1 HIGHEST SCORER: " + MatchSch.TeamScore1.GetHighestScorer());
                Console.WriteLine("teAM 2 HIGHEST SCORER: " + MatchSch.TeamScore2.GetHighestScorer());

               /// MoM = MatchSch.TeamScore1.IsWinner ? MatchSch.TeamScore1.HighestScorer.PlayerDetails.Name : MatchSch.TeamScore2.HighestScorer.PlayerDetails.Name;
                ///Console.WriteLine(MoM);

                Console.WriteLine("-----------*****************-----------------\n\n\n");


                MatchSch.GetManOfMatch();
                MatchSch.GetHighestScorerOfMatch();
            }
    }
}
