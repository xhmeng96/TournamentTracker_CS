using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;


namespace TrackerLibrary.DataAccess.TextHelpers
{
    public static class TextConnectorProcessor
    {
        public static string FullFilePath(this string FileName) // e.g. PrizeModels.csv
        {
            return $"{ConfigurationManager.AppSettings["FilePath"]}\\{FileName}";
        }
        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }
            else
            {
                return File.ReadAllLines(file).ToList();
            }
        }
        public static List<PrizeModel> ConvertToPrizeModels(this List<string> lines)
        {
            List<PrizeModel> output = new List<PrizeModel>();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                PrizeModel p = new PrizeModel
                {
                    Id = int.Parse(cols[0]),
                    PlaceNumber = int.Parse(cols[1]),
                    PlaceName = cols[2],
                    PrizeAmount = decimal.Parse(cols[3]),
                    PrizePercentage = double.Parse(cols[4])
                };

                output.Add(p);
            }
            return output;
        }
        public static void SaveToPrizeFile(this List<PrizeModel> models)
        {
            List<string> lines = new List<string>();

            foreach (PrizeModel p in models)
            {
                lines.Add($"{p.Id},{p.PlaceNumber},{p.PlaceName},{p.PrizeAmount},{p.PrizePercentage}");
            }

            File.WriteAllLines(GlobalConfig.PrizesFile.FullFilePath(), lines);
        }
        public static List<PersonModel> ConverToPersonModels(this List<string> lines)
        {
            List<PersonModel> output = new List<PersonModel>();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                PersonModel p = new PersonModel();
                p.Id = int.Parse(cols[0]);
                p.FirstName = cols[1];
                p.LastName = cols[2];
                p.EmailAddress = cols[3];
                p.CellphoneNumber = cols[4];

                output.Add(p);
            }
            return output;
        }
        public static void SaveToPersonFile(this List<PersonModel> models)
        {
            List<string> lines = new List<string>();

            foreach (PersonModel p in models)
            {
                lines.Add($"{p.Id},{p.FirstName},{p.LastName},{p.EmailAddress},{p.CellphoneNumber}");
            }

            File.WriteAllLines(GlobalConfig.PersonFile.FullFilePath(), lines);
        }
        public static List<TeamModel> ConvertToTeamModels(this List<string> lines)
        {
            List<TeamModel> output = new List<TeamModel>();
            List<PersonModel> persons = GlobalConfig.PersonFile.FullFilePath().LoadFile().ConverToPersonModels();
            foreach (string line in lines)
            {
                // e.g.  3, SekiroTeam, 1|2|5
                string[] cols = line.Split(',');

                TeamModel t = new TeamModel();
                t.Id = int.Parse(cols[0]);
                t.TeamName = cols[1];

                string[] PersonIds = cols[2].Split('|');
                foreach (string id in PersonIds)
                {
                    t.TeamMembers.Add(persons.Where(x => x.Id == int.Parse(id)).First());
                }

                output.Add(t);
            }
            return output;
        }
        public static void SaveToTeamFile(this List<TeamModel> models)
        {
            List<string> lines = new List<string>();

            foreach (TeamModel t in models)
            {
                lines.Add($"{t.Id},{t.TeamName},{ConvertPersonListToString(t.TeamMembers)}");
            }

            File.WriteAllLines(GlobalConfig.TeamFile.FullFilePath(), lines);
        }
        public static List<TournamentModel> ConvertToTournamentModels(this List<string> lines)
        {
            // 0 - id,
            // 1 - name,
            // 2 - entryFee,
            // 3 - (teams) id|id|id,
            // 4 - (prizes) id|id|id,
            // 5 - (rounds)id&id&id|id&id&id|id&id&id
            List<TournamentModel> output = new List<TournamentModel>();
            List<TeamModel> teams = GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModels();
            List<PrizeModel> prizes = GlobalConfig.PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();
            List<MatchupModel> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModels();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                TournamentModel tm = new TournamentModel();
                tm.Id = int.Parse(cols[0]);
                tm.TournamentName = cols[1];
                tm.EntryFee = decimal.Parse(cols[2]);

                // add teams
                string[] TeamIds = cols[3].Split('|');
                foreach (string id in TeamIds)
                {
                    tm.EnteredTeams.Add(teams.Where(x => x.Id == int.Parse(id)).First());
                }

                // add prizes
                if (cols[4] != "")
                {
                    string[] PrizeIds = cols[4].Split('|');
                    foreach (string id in PrizeIds)
                    {
                        tm.Prizes.Add(prizes.Where(x => x.Id == int.Parse(id)).First());
                    }
                }
                // Capture rounds information
                string[] rounds = cols[5].Split('|');

                foreach (string round in rounds)
                {
                    string[] matchupIds = round.Split('&');
                    List<MatchupModel> matchupList = new List<MatchupModel>();
                    foreach (string id in matchupIds)
                    {
                        matchupList.Add(matchups.Where(x => x.Id == int.Parse(id)).First());
                    }
                    tm.Rounds.Add(matchupList);
                }
                output.Add(tm);
            }
            return output;
        }
        public static void SaveRoundsToFile(this TournamentModel model)
        {
            // loop through each round
            // loop through each matchup
            // get id for new matchup, save
            // loop through each entry
            // get id for new entries, save
            foreach (List<MatchupModel> round in model.Rounds)
            {
                foreach (MatchupModel matchup in round)
                {
                    matchup.SaveMatchupToFile();
                }
            }
        }
        public static List<MatchupEntryModel> ConvertToMatchupEntryModels(this List<string> lines)
        {
            // 0 - id
            // 1 - TeamCompeting
            // 2 - Score
            // 3 - ParentMatchup
            List<MatchupEntryModel> output = new List<MatchupEntryModel>();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                MatchupEntryModel m = new MatchupEntryModel
                {
                    Id = int.Parse(cols[0]),
                    Score = double.Parse(cols[2])
                };

                if (int.TryParse(cols[1], out int TeamCompetingId))
                    m.TeamCompeting = LookupTeamById(TeamCompetingId);
                else
                    m.TeamCompeting = null;

                if (int.TryParse(cols[3], out int parentId))
                    m.ParentMatchup = LookupMatchupById(parentId);
                else
                    m.ParentMatchup = null;

                output.Add(m);
            }
            return output;
        }
        private static List<MatchupEntryModel> ConvertStringToMatchupEntryModels(string input)
        {
            string[] ids = input.Split('|');
            List<MatchupEntryModel> output = new List<MatchupEntryModel>();
            List<string> entries = GlobalConfig.MatchupEntryFile.FullFilePath().LoadFile();
            List<string> matchingEntries = new List<string>();

            foreach (string id in ids)
            {
                foreach (string entry in entries)
                {
                    string[] cols = entry.Split(',');
                    if (cols[0] == id)
                    {
                        matchingEntries.Add(entry);
                    }
                }
            }
            output = matchingEntries.ConvertToMatchupEntryModels();

            return output;
        }
        private static TeamModel LookupTeamById(int id)
        {
            List<string> teams = GlobalConfig.TeamFile.FullFilePath().LoadFile();
            List<string> matchingTeam = new List<string>();
            foreach (string team in teams)
            {
                string[] cols = team.Split(',');
                if (cols[0] == id.ToString())
                {
                    matchingTeam.Add(team);
                    break;
                }
            }
            return matchingTeam.ConvertToTeamModels().First();
        }
        private static MatchupModel LookupMatchupById(int id)
        {
            List<string> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile();
            List<string> found = new List<string>();
            foreach (string matchup in matchups)
            {
                string[] cols = matchup.Split(',');
                if (cols[0] == id.ToString())
                {
                    found.Add(matchup);
                    break;
                }
            }
            return found.ConvertToMatchupModels().First();
        }
        public static List<MatchupModel> ConvertToMatchupModels(this List<string> lines)
        {
            // 0 - id
            // 1 - entries(id|id)
            // 2 - winner
            // 3 - matchup round
            List<MatchupModel> output = new List<MatchupModel>();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                MatchupModel m = new MatchupModel
                {
                    Id = int.Parse(cols[0]),
                    Entries = ConvertStringToMatchupEntryModels(cols[1]),
                    MatchupRound = int.Parse(cols[3])
                };
                if (cols[2] == "")
                {
                    m.Winner = null;
                }
                else
                {
                    m.Winner = LookupTeamById(int.Parse(cols[2]));
                }

                output.Add(m);
            }
            return output;
        }
        public static void SaveMatchupToFile(this MatchupModel matchup)
        {
            List<MatchupModel> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModels();
            int currentId = 1;
            if (matchups.Count > 0)
            {
                currentId = matchups.OrderByDescending(x => x.Id).First().Id + 1;
            }
            matchup.Id = currentId;
            matchups.Add(matchup);

            foreach (MatchupEntryModel entry in matchup.Entries)
            {
                entry.SaveEntryToFile();
            }
            // save to file
            List<string> lines = new List<string>();
            // id, entries, winner, round
            foreach (MatchupModel m in matchups)
            {
                string winner = "";
                if (m.Winner != null)
                {
                    winner = $"{m.Winner.Id}";
                }
                lines.Add($"{m.Id},{ConvertEntryListToString(m.Entries)},{winner},{m.MatchupRound}");
            }
            File.WriteAllLines(GlobalConfig.MatchupFile.FullFilePath(), lines);
        }
        public static void UpdateMatchupToFile(this MatchupModel matchup)
        {
            List<MatchupModel> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModels();
            MatchupModel old = new MatchupModel();
            foreach (MatchupModel m in matchups)
            {
                if (m.Id == matchup.Id)
                {
                    old = m;
                }
            }
            matchups.Remove(old);
            matchups.Add(matchup);

            foreach (MatchupEntryModel entry in matchup.Entries)
            {
                entry.UpdateEntryToFile();
            }
            // save to file
            List<string> lines = new List<string>();
            // id, entries, winner, round
            foreach (MatchupModel m in matchups)
            {
                string winner = "";
                if (m.Winner != null)
                {
                    winner = $"{m.Winner.Id}";
                }
                lines.Add($"{m.Id},{ConvertEntryListToString(m.Entries)},{winner},{m.MatchupRound}");
            }
            File.WriteAllLines(GlobalConfig.MatchupFile.FullFilePath(), lines);

        }
        public static void SaveEntryToFile(this MatchupEntryModel entry)
        {
            List<MatchupEntryModel> entries = GlobalConfig.MatchupEntryFile.FullFilePath().LoadFile().ConvertToMatchupEntryModels();
            int currentId = 1;
            if (entries.Count > 0)
            {
                currentId = entries.OrderByDescending(x => x.Id).First().Id + 1;
            }
            entry.Id = currentId;
            entries.Add(entry);

            // save to file
            List<string> lines = new List<string>();
            foreach (MatchupEntryModel me in entries)
            {
                string parent = "";
                if (me.ParentMatchup != null)
                {
                    parent = $"{me.ParentMatchup.Id}";
                }

                string teamCompeting = "";
                if (me.TeamCompeting != null)
                {
                    teamCompeting = me.TeamCompeting.Id.ToString();
                }

                lines.Add($"{me.Id},{teamCompeting},{me.Score},{parent}");
            }
            File.WriteAllLines(GlobalConfig.MatchupEntryFile.FullFilePath(), lines);
        }
        public static void UpdateEntryToFile(this MatchupEntryModel entry)
        {
            List<MatchupEntryModel> entries = GlobalConfig.MatchupEntryFile.FullFilePath().LoadFile().ConvertToMatchupEntryModels();
            MatchupEntryModel old = new MatchupEntryModel();
            foreach (var item in entries)
            {
                if (item.Id == entry.Id)
                {
                    old = item;
                }
            }
            entries.Remove(old);
            entries.Add(entry);

            // save to file
            List<string> lines = new List<string>();
            foreach (MatchupEntryModel me in entries)
            {
                string parent = "";
                if (me.ParentMatchup != null)
                {
                    parent = $"{me.ParentMatchup.Id}";
                }

                string teamCompeting = "";
                if (me.TeamCompeting != null)
                {
                    teamCompeting = me.TeamCompeting.Id.ToString();
                }

                lines.Add($"{me.Id},{teamCompeting},{me.Score},{parent}");
            }
            File.WriteAllLines(GlobalConfig.MatchupEntryFile.FullFilePath(), lines);
        }
        public static void SaveToTournamentFile(this List<TournamentModel> models)
        {
            List<string> lines = new List<string>();
            foreach (TournamentModel tm in models)
            {
                lines.Add($"{tm.Id},{tm.TournamentName},{tm.EntryFee}," +
                    $"{ConvertTeamListToString(tm.EnteredTeams)}," +
                    $"{ConvertPrizeListToString(tm.Prizes)}," +
                    $"{ConvertRoundListToString(tm.Rounds)}");
            }
            File.WriteAllLines(GlobalConfig.TournamentFile.FullFilePath(), lines);
        }
        private static string ConvertPersonListToString(List<PersonModel> persons)
        {
            if (persons.Count == 0) return "";
            string output = "";

            foreach (PersonModel p in persons)
            {
                output += $"{p.Id}|";
            }
            return output.Remove(output.Length - 1);
        }
        private static string ConvertTeamListToString(List<TeamModel> teams)
        {
            if (teams.Count == 0)
                return "";
            StringBuilder sb = new StringBuilder();
            foreach (TeamModel team in teams)
            {
                sb.Append($"{team.Id}|");
            }
            sb.Remove(sb.Length - 1, 1);
            return sb.ToString();
        }
        private static string ConvertPrizeListToString(List<PrizeModel> prizes)
        {
            if (prizes.Count == 0)
                return "";
            StringBuilder sb = new StringBuilder();
            foreach (PrizeModel prize in prizes)
            {
                sb.Append($"{prize.Id}|");
            }
            sb.Remove(sb.Length - 1, 1);
            return sb.ToString();
        }
        private static string ConvertRoundListToString(List<List<MatchupModel>> rounds)
        {
            if (rounds.Count == 0) return "";
            StringBuilder sb = new StringBuilder();
            /* Or use lambda expresion
            Func<List<MatchupModel>, string> f = (List<MatchupModel> round) =>
            {
                StringBuilder sub = new StringBuilder();
                foreach (MatchupModel matchup in round)
                {
                    sub.Append($"{matchup.Id}&");
                }
                sub.Remove(sub.Length - 1, 1);
                return sub.ToString();
            };
            */
            foreach (List<MatchupModel> round in rounds)
            {
                sb.Append($"{ConvertMatchUpListToString(round)}|");
            }
            sb.Remove(sb.Length - 1, 1);
            return sb.ToString();
        }
        private static string ConvertMatchUpListToString(List<MatchupModel> matchups)
        {
            if (matchups.Count == 0)
                return "";
            StringBuilder sb = new StringBuilder();
            foreach (MatchupModel matchup in matchups)
            {
                sb.Append($"{matchup.Id}&");
            }
            sb.Remove(sb.Length - 1, 1);
            return sb.ToString();
        }
        private static string ConvertEntryListToString(List<MatchupEntryModel> entries)
        {
            if (entries.Count == 0)
            {
                return "";
            }
            StringBuilder sb = new StringBuilder();
            foreach (MatchupEntryModel entry in entries)
            {
                sb.Append($"{entry.Id}|");
            }
            sb.Remove(sb.Length - 1, 1);
            return sb.ToString();
        }
    }
}
