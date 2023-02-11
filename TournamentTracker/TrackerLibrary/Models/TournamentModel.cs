using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class TournamentModel
    {
        public int Id { get; set; }
        /// <summary>
        /// Tournament name.
        /// </summary>
        public string TournamentName { get; set; } = "";

        /// <summary>
        /// Entry fee.
        /// </summary>
        public decimal EntryFee { get; set; } = 0;

        /// <summary>
        /// Teams in the tournament.
        /// </summary>
        public List<TeamModel> EnteredTeams { get; set; } = new List<TeamModel>();

        /// <summary>
        /// Prizes in the tournament.
        /// </summary>
        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        /// <summary>
        /// Schedule of the tournament.
        /// </summary>
        public List<List<MatchupModel>> Rounds { get; set; } = new List<List<MatchupModel>>();
    }
}
