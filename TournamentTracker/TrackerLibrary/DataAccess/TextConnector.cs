using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;
using TrackerLibrary.DataAccess.TextHelpers;

namespace TrackerLibrary.DataAccess
{
    public class TextConnector : IDataConnection
    {
        public void CompleteTournament(TournamentModel model)
        {
            List<TournamentModel> Tournaments = GlobalConfig.TournamentFile
                .FullFilePath()
                .LoadFile()
                .ConvertToTournamentModels();

            Tournaments.Remove(model);
            Tournaments.SaveToTournamentFile();
        }
        public void CreatePerson(PersonModel model)
        {
            List<PersonModel> persons =GlobalConfig.PersonFile.FullFilePath().LoadFile().ConverToPersonModels();

            int currentId = 1;
            if (persons.Count > 0)
            {
                currentId = persons.OrderByDescending(p => p.Id).First().Id + 1;
            }
            model.Id = currentId;
            persons.Add(model);
            persons.SaveToPersonFile();
        }
        public void CreatePrize(PrizeModel model)
        {
            // Load TextFile
            // convert to a list<PrizeModel>
            List<PrizeModel> prizes = GlobalConfig.PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            // find ID(max id)
            // new prize with ID(max + 1)
            int currentId = 1;
            if (prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(p => p.Id).First().Id + 1;
            }
            model.Id = currentId;
            prizes.Add(model);

            // convert to list<string>
            // save to text file
            prizes.SaveToPrizeFile();
        }
        public void CreateTeam(TeamModel model)
        {
            List<TeamModel> teams = GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModels();

            int currentId = 1;
            if (teams.Count > 0)
            {
                currentId = teams.OrderByDescending(p => p.Id).First().Id + 1;
            }
            model.Id = currentId;
            teams.Add(model);
            teams.SaveToTeamFile();
        }
        public void CreateTournament(TournamentModel model)
        {
            List<TournamentModel> Tournaments = GlobalConfig.TournamentFile
                .FullFilePath()
                .LoadFile()
                .ConvertToTournamentModels();

            int currentId = 1;
            if (Tournaments.Count > 0)
            {
                currentId = Tournaments.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;
            model.SaveRoundsToFile();
            Tournaments.Add(model);
            Tournaments.SaveToTournamentFile();
        }
        public List<PersonModel> GetPerson_All()
        {
            return GlobalConfig.PersonFile.FullFilePath().LoadFile().ConverToPersonModels();
        }
        public List<TeamModel> GetTeam_All()
        {
            return GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModels();
        }
        public List<TournamentModel> GetTournament_All()
        {
            return GlobalConfig.TournamentFile
                .FullFilePath()
                .LoadFile()
                .ConvertToTournamentModels();
        }
        public void UpdataMatchup(MatchupModel model)
        {
            model.UpdateMatchupToFile();
        }
    }
}
