using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

namespace TrackerLibrary
{
    public static class TournamentLogic
    {
        // Random shuffle the Team list
        // team list big enough?
        // create first round of matches
        // create every round after that
        public static void CreateRounds(TournamentModel model)
        {
            List<TeamModel> randomized = RandomShuffle(model.EnteredTeams);
            int rounds = FindRoundNumber(randomized.Count);
            int byes = FindByesNumber(rounds, randomized.Count);
            model.Rounds.Add(CreateFirstRound(randomized, byes));
            CreateOtherRounds(model, rounds);
        }
        public static void UpdateTournamentResult(TournamentModel t, MatchupModel m)
        {
            foreach (List<MatchupModel> round in t.Rounds)
            {
                foreach (MatchupModel item in round)
                {
                    foreach (MatchupEntryModel me in item.Entries)
                    {
                        if (me.ParentMatchup != null)
                        {
                            if (me.ParentMatchup.Id == m.Id)
                            {
                                me.TeamCompeting = m.Winner;
                                GlobalConfig.Connection.UpdataMatchup(item);
                            }
                        }
                    }
                }
            }
        }


        public static int CheckCurrentRound(TournamentModel t)
        {
            int output = 1;
            foreach (List<MatchupModel> round in t.Rounds)
            {
                if (round.All(x => x.Winner != null))
                {
                    ++output;
                }
                else
                {
                    return output;
                }
            }
            CompleteTournament(t);
            return -1;
        }
        private static void CompleteTournament(TournamentModel t)
        {
            GlobalConfig.Connection.CompleteTournament(t);
            TeamModel winners = t.Rounds.Last().First().Winner;
            TeamModel ruunerUp = t.Rounds.Last().First().Entries.Where(x => x.TeamCompeting != winners).First().TeamCompeting;

            decimal winnerPrize = 0;
            decimal runnerUpPrize = 0;


            if (t.Prizes.Count > 0)
            {
                decimal totalIncome = t.EnteredTeams.Count * t.EntryFee;

                PrizeModel fp = t.Prizes.Where(x => x.PlaceNumber == 1).FirstOrDefault();
                PrizeModel sp = t.Prizes.Where(x => x.PlaceNumber == 2).FirstOrDefault();
                if (fp != null)
                {
                    winnerPrize = fp.CalculatePrizePayOut(totalIncome);
                }
                if (sp != null)
                {
                    runnerUpPrize = sp.CalculatePrizePayOut(totalIncome);
                }
            }

            // email.
            string to;
            string subject;
            string body;
            StringBuilder sb = new StringBuilder();
            
            subject = $"Tournament {t.TournamentName} has finished.";
            sb.AppendLine($"<h1>Winner: {winners.TeamName}!</h1>");
            sb.AppendLine();
            if(winnerPrize > 0)
            {
                sb.AppendLine($"First place get prize amount: ${winnerPrize}");
            }
            sb.AppendLine();
            if (runnerUpPrize > 0)
            {
                sb.AppendLine($"Second place get prize amount: ${runnerUpPrize}");
            }
            sb.AppendLine();
            sb.AppendLine("From: Tournament Tracker Email Center");

            body = sb.ToString();
            foreach (TeamModel team in t.EnteredTeams)
            {
                foreach (PersonModel person in team.TeamMembers)
                {
                    to = person.EmailAddress;
                    EmailLogic.SendEmail(to, subject, body);
                }
            }
        }
        private static decimal CalculatePrizePayOut(this PrizeModel p, decimal TotalIncome)
        {
            decimal ret = 0;
            if (p.PrizeAmount > 0)
            {
                ret = p.PrizeAmount;
            }
            else
            {
                ret = TotalIncome * (decimal)p.PrizePercentage;
            }
            return ret;
        }
        private static void CreateOtherRounds(TournamentModel model, int rounds)
        {
            int round = 2;
            List<MatchupModel> previousRound = model.Rounds[0];
            List<MatchupModel> currentRound = new List<MatchupModel>();
            MatchupModel currentMatchup = new MatchupModel();
            while (round <= rounds)
            {
                foreach (MatchupModel match in previousRound)
                {
                    currentMatchup.Entries.Add(new MatchupEntryModel { ParentMatchup = match });
                    currentMatchup.MatchupRound = round;
                    if (currentMatchup.Entries.Count > 1)
                    {
                        currentRound.Add(currentMatchup);
                        currentMatchup = new MatchupModel();
                    }
                }
                model.Rounds.Add(currentRound);
                previousRound = model.Rounds.Last();
                currentRound = new List<MatchupModel>();
                ++round;
            }
        }
        private static List<MatchupModel> CreateFirstRound(List<TeamModel> teams, int byes)
        {
            List<MatchupModel> output = new List<MatchupModel>();
            MatchupModel cur = new MatchupModel();
            foreach (TeamModel team in teams)
            {
                cur.Entries.Add(new MatchupEntryModel { TeamCompeting = team });
                if (byes > 0 || cur.Entries.Count > 1)
                {
                    cur.MatchupRound = 1;
                    output.Add(cur);
                    cur = new MatchupModel();

                    if (byes > 0)
                    {
                        --byes;
                    }
                }
            }
            return output;
        }
        private static int FindByesNumber(int round, int teamNumber)
        {
            return (int)Math.Pow(2, round) - teamNumber;
        }
        private static int FindRoundNumber(int count)
        {
            return (int)Math.Ceiling(Math.Log(count, 2));
        }
        private static List<TeamModel> RandomShuffle(List<TeamModel> teams)
        {
            List<TeamModel> output = new List<TeamModel>(teams);
            Random rng = new Random();
            output.OrderBy((x) => { return rng.Next(); }).ToList();
            return output;
        }
    }
}
