using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sportsleague
{
    
    class CricketLeague
    {
        static void Main(string[] args)
        {
            string MoM;
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
            do {
                Console.WriteLine("1. To Know Winner\n" +
                    "2.Team1{0} HighestScorer\n" +
                    "3.Team2{1} HighestScorer\n" +
                    "4.Man Of The Match\n" +
                    "5.HighestScorer of Match\n", MatchSch.TeamScore1.Name, MatchSch.TeamScore2.Name);
                int Option= int.Parse(Console.ReadLine());
               
                switch (Option)
                {
                    case 1:
                        if (MatchSch.TeamScore1.TotalTeamScore > MatchSch.TeamScore2.TotalTeamScore)
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
                        Console.WriteLine("teAM 1 HIGHEST SCORER: " + MatchSch.TeamScore1.HighestScorer.PlayerDetails.Name);
                        break;
                    case 3:
                        Console.WriteLine("teAM 2 HIGHEST SCORER: " + MatchSch.TeamScore2.HighestScorer.PlayerDetails.Name);
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
            if (MatchSch.TeamScore1.TotalTeamScore > MatchSch.TeamScore2.TotalTeamScore)
            {
                MatchSch.TeamScore1.IsWinner = true;
                Console.WriteLine("WINNER IS : " + MatchSch.TeamScore1.Name);
            }
            else
            {
                MatchSch.TeamScore2.IsWinner = true;
                Console.WriteLine("WINNER IS : " + MatchSch.TeamScore2.Name);
            }
            Console.WriteLine("teAM 1 HIGHEST SCORER: " + MatchSch.TeamScore1.HighestScorer.PlayerDetails.Name);
            Console.WriteLine("teAM 2 HIGHEST SCORER: " + MatchSch.TeamScore2.HighestScorer.PlayerDetails.Name);

             MoM = MatchSch.TeamScore1.IsWinner ? MatchSch.TeamScore1.HighestScorer.PlayerDetails.Name : MatchSch.TeamScore2.HighestScorer.PlayerDetails.Name;
            Console.WriteLine(MoM);

            Console.WriteLine("-----------*****************-----------------\n\n\n");


            MatchSch.GetManOfMatch();
            MatchSch.GetHighestScorerOfMatch();
            //Console.WriteLine(MatchSch.HighestScorer.PlayerDetails.Name);
            //MatchSch.SetScores(Team1);
            //MatchSch.SetScores(Team2);

            //MatchSch.TeamScore1.SetScores(Team1);
            // MatchSch.TeamScore1.DisplayTeam();

            Console.ReadLine();
















            //for (int MatchCount = 0; MatchCount < LeagueStats.MaxMatches; MatchCount++) // set max matches to 1 for testing
            //{
            //    Console.WriteLine("enter the teams for the Match {0}\n1.{1}\n2.{2}", MatchCount + 1, Teams[0].Name,
            //        Teams[1].Name/* t[2].TeamName, t[3].TeamName*/);
            //    MatchSch[MatchCount] = new Match();
            //    MatchSch[MatchCount].Team1 = new TeamScore();
            //    MatchSch[MatchCount].Team2 = new TeamScore();
            //    int Team1Index = (int.Parse(Console.ReadLine()) - 1);
            //    int Team2Index = (int.Parse(Console.ReadLine()) - 1);
            //    MatchSch[MatchCount].Team1 = Teams[Team1Index];
            //    MatchSch[MatchCount].Team2 = Teams[Team2Index];
            //    //copy here

            //}

            //for (int PlayerNum = 0; PlayerNum < LeagueStats.MaxPlayersPerMatch; PlayerNum++)
            //{
            //    //MatchSch[0].Team1.TeamPlayers[PlayerNum] = new PlayerScore();
            //    Console.WriteLine("enter Score of {0} :", MatchSch[0].Team1.TeamPlayers[PlayerNum].Name);
            //    int A = int.Parse(Console.ReadLine());
            //    MatchSch[0].Team1.TeamPlayers[PlayerNum].Score = A;
            //    Console.WriteLine("enter balls played by {0} :", MatchSch[0].Team1.TeamPlayers[PlayerNum].Name);
            //    int B = int.Parse(Console.ReadLine());
            //    MatchSch[0].Team1.TeamPlayers[PlayerNum].PlayedBalls = B;
            //    //Console.WriteLine("exec");
            //   // MatchSch[0].Team1.TeamPlayers[PlayerNum].StrikeRate = ( A / B)*100;
            //    MatchSch[0].Team1.TeamPlayers[PlayerNum].StrikeRate = MatchSch[0].Team1.TeamPlayers[PlayerNum].Score *100/ MatchSch[0].Team1.TeamPlayers[PlayerNum].PlayedBalls;
            //    Console.WriteLine(" STRIKE RATE OF PREVIOUS PLAYER  "+MatchSch[0].Team1.TeamPlayers[PlayerNum].StrikeRate);
            //    //MatchSch[0].Team1.TeamPlayers[PlayerNum] = new PlayerScore();
            //    MatchSch[0].Team1.TotalTeamScore += MatchSch[0].Team1.TeamPlayers[PlayerNum].Score;
            //    MatchSch[0].Team1.HighestScorer = new PlayerScore();
            //    MatchSch[0].Team1.HighestScorer.Score = 0;
            //    if (MatchSch[0].Team1.HighestScorer.Score < MatchSch[0].Team1.TeamPlayers[PlayerNum].Score)
            //    {
            //        //MatchSch[0].HighScorer = new PlayerScore();
            //        //Console.WriteLine("entered HIghest SCore FOr team 1 LOOP");
            //        MatchSch[0].Team1.HighestScorer.Score = MatchSch[0].Team1.TeamPlayers[PlayerNum].Score;
            //        MatchSch[0].Team1.HighestScorer = MatchSch[0].Team1.TeamPlayers[PlayerNum];
            //    }
            //}
            //for (int PlayerNum = 0; PlayerNum < LeagueStats.MaxPlayersPerMatch; PlayerNum++)
            //{
            //    Console.WriteLine("enter Score of {0} :", MatchSch[0].Team2.TeamPlayers[PlayerNum].Name);
            //    MatchSch[0].Team2.TeamPlayers[PlayerNum].Score = int.Parse(Console.ReadLine());
            //    Console.WriteLine("enter balls played by {0} :", MatchSch[0].Team2.TeamPlayers[PlayerNum].Name);
            //    MatchSch[0].Team2.TeamPlayers[PlayerNum].PlayedBalls = int.Parse(Console.ReadLine());
            //    //Console.WriteLine("exec");
            //    MatchSch[0].Team2.TeamPlayers[PlayerNum].StrikeRate = MatchSch[0].Team2.TeamPlayers[PlayerNum].Score*100 / MatchSch[0].Team2.TeamPlayers[PlayerNum].PlayedBalls;
            //    //MatchSch[0].Team2.TeamPlayers[PlayerNum] = new PlayerScore();
            //    MatchSch[0].Team2.TotalTeamScore += MatchSch[0].Team2.TeamPlayers[PlayerNum].Score;
            //   MatchSch[0].Team2.HighestScorer = new PlayerScore();
            //    MatchSch[0].Team2.HighestScorer.Score = 0;
            //    if (MatchSch[0].Team2.HighestScorer.Score < MatchSch[0].Team2.TeamPlayers[PlayerNum].Score)
            //    {
            //        //MatchSch[0].HighScorer = new PlayerScore();
            //        //Console.WriteLine("entered HIghest SCore FOr team 2 LOOP");
            //        MatchSch[0].Team2.HighestScorer.Score = MatchSch[0].Team2.TeamPlayers[PlayerNum].Score;
            //        MatchSch[0].Team2.HighestScorer = MatchSch[0].Team2.TeamPlayers[PlayerNum];
            //    }

            //}
            ////MatchSch[0].ManOfTheMatch = new Player();
            //if (MatchSch[0].Team1.TotalTeamScore> MatchSch[0].Team2.TotalTeamScore)
            //{
            //    MatchSch[0].Team1.IsWinner = true;
            //    MatchSch[0].ManOfTheMatch = MatchSch[0].Team1.HighestScorer;
            //}
            //else if (MatchSch[0].Team1.TotalTeamScore < MatchSch[0].Team2.TotalTeamScore)
            //{
            //    MatchSch[0].Team2.IsWinner = true;
            //    MatchSch[0].ManOfTheMatch = MatchSch[0].Team2.HighestScorer;
            //}
            //else
            //{
            //    Console.WriteLine("Both Teams scores leveled. Hence No Man Of Match");
            //}

            //int ExitFlag = 1;
            //do
            //{
            //    Console.WriteLine("enter\n 1. Winner\n2. Man Of The Match\n3." + MatchSch[0].Team1.Name + " Highest Scorer \n4. " + MatchSch[0].Team2.Name+ " Highest Scorer \n0. Exit");
            //    int DispOption = int.Parse(Console.ReadLine());
            //    switch (DispOption)
            //    {
            //        case 1:
            //            string Winner= MatchSch[0].Team1.IsWinner ? MatchSch[0].Team1.Name : MatchSch[0].Team2.Name;
            //            Console.WriteLine("The WINNER is "+Winner);
            //            break;
            //        case 2:
            //            Console.WriteLine("Man Of The Match is : "+MatchSch[0].ManOfTheMatch.Name);
            //            break;
            //        case 3:
            //            Console.WriteLine("Highest Scorer of "+MatchSch[0].Team1.Name+" is "+ MatchSch[0].Team1.HighestScorer.Name);
            //            break;
            //        case 4:
            //            Console.WriteLine("Highest Scorer of " + MatchSch[0].Team2.Name + " is " + MatchSch[0].Team2.HighestScorer.Name);
            //            break;
            //        case 0:
            //            ExitFlag = 0;
            //            break;

            //    }
            //} while (ExitFlag != 0);
            //    //for (int i = 0; i < 2; i++)
            //    //{
            //    //    Console.WriteLine(" choose players for the match from the team");
            //    //    for (int j = 0; j < LeagueStats.MaxPlayersPerMatch; j++)
            //    //    {

            //    //        Console.WriteLine((j+1)+"  "+MatchSch[i].Team1.TeamPlayers[i].PlayerName);

            //    //    }
            //    //}

            //    //Console.WriteLine("prog");
            //Console.ReadLine();
        }
    }
}
