using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TrackerLibrary.Models;

/*
    @PlaceNumber int,
    @PlaceName nvarchar(50),
    @PrizeAmount money,
    @PrizePercentage float,
    @id int = 0 output
*/

namespace TrackerLibrary.DataAccess
{

    public class SqlConnector : IDataConnection
    {
        private const string db = "Tournament";
        public void CreatePerson(PersonModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@FirstName", model.FirstName);
                p.Add("@LastName", model.LastName);
                p.Add("@EmailAddress", model.EmailAddress);
                p.Add("@CellphoneNumber", model.CellphoneNumber);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPeople_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");
            }
        }
        public void CreatePrize(PrizeModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@PlaceNumber", model.PlaceNumber);
                p.Add("@PlaceName", model.PlaceName);
                p.Add("@PrizeAmount", model.PrizeAmount);
                p.Add("@PrizePercentage", model.PrizePercentage);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spPrizes_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");
            }
        }
        public void CreateTeam(TeamModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@TeamName", model.TeamName);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);

                connection.Execute("dbo.spTeams_Insert", p, commandType: CommandType.StoredProcedure);

                model.Id = p.Get<int>("@id");

                foreach (PersonModel member in model.TeamMembers)
                {
                    p = new DynamicParameters();
                    p.Add("@TeamId", model.Id);
                    p.Add("@PersonId", member.Id);

                    connection.Execute("dbo.spTeamMembers_Insert", p, commandType: CommandType.StoredProcedure);
                }
            }
        }
        public void CreateTournament(TournamentModel model)
        {
            //dbo.spTournament_Insert
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(db)))
            {
                SaveTournament(connection, model);
                SavePrizes(connection, model);
                SaveEntries(connection, model);
                SaveRounds(connection, model);
            }
        }
        private void SaveTournament(IDbConnection connection, TournamentModel model)
        {
            var p = new DynamicParameters();
            p.Add("@TournamentName", model.TournamentName);
            p.Add("@EntryFee", model.EntryFee);
            p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
            connection.Execute("dbo.spTournament_Insert", p, commandType: CommandType.StoredProcedure);
            model.Id = p.Get<int>("@id");
        }
        private void SavePrizes(IDbConnection connection, TournamentModel model)
        {
            foreach (PrizeModel pz in model.Prizes)
            {
                var p = new DynamicParameters();
                p.Add("TournamentId", model.Id);
                p.Add("PrizeId", pz.Id);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("dbo.spTournamentPrizes_Insert", p, commandType: CommandType.StoredProcedure);
            }
        }
        private void SaveEntries(IDbConnection connection, TournamentModel model)
        {
            foreach (TeamModel team in model.EnteredTeams)
            {
                var p = new DynamicParameters();
                p.Add("TournamentId", model.Id);
                p.Add("TeamId", team.Id);
                p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                connection.Execute("dbo.spTournamentEntries_Insert", p, commandType: CommandType.StoredProcedure);
            }
        }
        private void SaveRounds(IDbConnection connection, TournamentModel model)
        {
            // List<List<MatchupModel>> Rounds;
            // List<MatchupEntries> Entries;

            // Loop through the rounds
            // foreach round, loop through the matchups
            // foreach matchup, loop through matchup entries, and save them
            foreach (List<MatchupModel> round in model.Rounds)
            {
                foreach (MatchupModel matchup in round)
                {
                    var p = new DynamicParameters();
                    p.Add("TournamentId", model.Id);
                    p.Add("MatchupRound", matchup.MatchupRound);
                    p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                    connection.Execute("dbo.spMatchups_Insert", p, commandType: CommandType.StoredProcedure);
                    matchup.Id = p.Get<int>("@id");
                    foreach (MatchupEntryModel entry in matchup.Entries)
                    {
                        p = new DynamicParameters();
                        p.Add("MatchupId", matchup.Id);

                        if (entry.ParentMatchup != null)
                            p.Add("ParentMatchupId", entry.ParentMatchup.Id);
                        else
                            p.Add("ParentMatchupId", null);

                        if (entry.TeamCompeting != null)
                            p.Add("TeamCompetingId", entry.TeamCompeting.Id);
                        else
                            p.Add("TeamCompetingId", null);

                        p.Add("@id", 0, dbType: DbType.Int32, direction: ParameterDirection.Output);
                        connection.Execute("dbo.spMatchupEntries_Insert", p, commandType: CommandType.StoredProcedure);
                        entry.Id = p.Get<int>("@id");
                    }
                }
            }
        }
        public List<PersonModel> GetPerson_All()
        {
            List<PersonModel> output = new List<PersonModel>();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(db)))
            {
                output = connection.Query<PersonModel>("dbo.spPeople_GetAll").ToList();
            }
            return output;
        }
        public List<TeamModel> GetTeam_All()
        {
            List<TeamModel> output = new List<TeamModel>();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(db)))
            {
                output = connection.Query<TeamModel>("dbo.spTeam_GetAll").ToList();
                foreach (TeamModel team in output)
                {
                    var p = new DynamicParameters();
                    p.Add("@TeamId", team.Id);
                    team.TeamMembers = connection.Query<PersonModel>("dbo.spTeamMembers_GetByTeam", p, commandType: CommandType.StoredProcedure).ToList();
                }
            }
            return output;
        }
        public List<TournamentModel> GetTournament_All()
        {
            List<TournamentModel> output = new List<TournamentModel>();
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(db)))
            {
                output = connection.Query<TournamentModel>("dbo.spTournaments_GetAll").ToList();

                foreach (TournamentModel t in output)
                {
                    // populate prizes
                    var p_prize = new DynamicParameters();
                    p_prize.Add("@TournamentId", t.Id);
                    t.Prizes = connection.Query<PrizeModel>("dbo.spPrizes_GetByTournament", p_prize, commandType: CommandType.StoredProcedure).ToList();
                    // populate teams
                    var p_team = new DynamicParameters();
                    p_team.Add("@TournamentId", t.Id);
                    t.EnteredTeams = connection.Query<TeamModel>("dbo.spTeam_GetByTournament", p_team, commandType: CommandType.StoredProcedure).ToList();
                    foreach (TeamModel team in t.EnteredTeams)
                    {
                        var loacal_p = new DynamicParameters();
                        loacal_p.Add("@TeamId", team.Id);
                        team.TeamMembers = connection.Query<PersonModel>("dbo.spTeamMembers_GetByTeam", loacal_p, commandType: CommandType.StoredProcedure).ToList();
                    }
                    // populate rounds
                    var p = new DynamicParameters();
                    p.Add("@TournamentId", t.Id);
                    List<MatchupModel> matchups = connection.Query<MatchupModel>("dbo.spMatchups_GetByTournament", p, commandType: CommandType.StoredProcedure).ToList();
                    foreach (MatchupModel m in matchups)
                    {
                        p = new DynamicParameters();
                        p.Add("@MatchupId", m.Id);
                        m.Entries = connection.Query<MatchupEntryModel>("dbo.spMatchupEntries_GetByMatchup", p, commandType: CommandType.StoredProcedure).ToList();
                        // poplate entry to model
                        var allTeams = GetTeam_All();
                        if (m.WinnerId > 0)
                        {
                            m.Winner = allTeams.Where(x => x.Id == m.WinnerId).First();
                        }
                        foreach (MatchupEntryModel entry in m.Entries)
                        {
                            if (entry.TeamCompetingId > 0)
                            {
                                entry.TeamCompeting = allTeams.Where(x => x.Id == entry.TeamCompetingId).First();
                            }
                            if (entry.ParentMatchupId > 0)
                            {
                                entry.ParentMatchup = matchups.Where(x => x.Id == entry.ParentMatchupId).First();
                            }
                        }
                    }
                    List<MatchupModel> round = new List<MatchupModel>();
                    int roundNum = 1;
                    foreach (MatchupModel m in matchups)
                    {
                        if (m.MatchupRound > roundNum)
                        {
                            t.Rounds.Add(round);
                            round = new List<MatchupModel>();
                            ++roundNum;
                        }
                        round.Add(m);
                    }
                    t.Rounds.Add(round);
                }
            }
            return output;
        }
        public void UpdataMatchup(MatchupModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(db)))
            {
                // dbo.spMatchups_Update @id @WinnerId
                var p = new DynamicParameters();
                if (model.Winner != null)
                {
                    p.Add("@id", model.Id);
                    p.Add("@WinnerId", model.Winner.Id);
                    connection.Execute("dbo.spMatchups_Update", p, commandType: CommandType.StoredProcedure);
                }
                // dbo.spMatchupEntries_Update @id, @TeamCompetingId, @Score
                foreach (MatchupEntryModel me in model.Entries)
                {
                    if (me.TeamCompeting != null)
                    {
                        p = new DynamicParameters();
                        p.Add("@id", me.Id);
                        p.Add("@TeamCompetingId", me.TeamCompeting.Id);
                        p.Add("@Score", me.Score);
                        connection.Execute("dbo.spMatchupEntries_Update", p, commandType: CommandType.StoredProcedure);
                    }
                }
            }
        }
        public void CompleteTournament(TournamentModel model)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(GlobalConfig.ConnectionString(db)))
            {
                var p = new DynamicParameters();
                p.Add("@id", model.Id);
                connection.Execute("dbo.spTounament_Complete", p, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
