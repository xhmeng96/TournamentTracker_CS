using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class MatchupEntryModel
    {
        public int Id { get; set; }

        /// <summary>
        /// SQL ONLY
        /// </summary>
        public int TeamCompetingId { get; set; }
        public TeamModel TeamCompeting { get; set; }

        /// <summary>
        /// Represents the score for this paticular team.
        /// </summary>
        public double Score { get; set; } = 0.0;
        /// <summary>
        /// SQL only
        /// </summary>
        public int ParentMatchupId { get; set; }
        /// <summary>
        /// Represents the matchup that this team came 
        /// from as the winner
        /// </summary>
        public MatchupModel ParentMatchup { get; set; }
    }
}
