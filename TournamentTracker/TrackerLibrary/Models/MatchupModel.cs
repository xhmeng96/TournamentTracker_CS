using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    /// <summary>
    /// Represents one match in the tournament.
    /// </summary>
    public class MatchupModel
    {
        public int Id { get; set; }
        /// <summary>
        /// The set of teams that were involved in this match.
        /// </summary>
        public List<MatchupEntryModel> Entries { get; set; } = new List<MatchupEntryModel>();
        /// <summary>
        /// Used only in sql
        /// </summary>
        public int WinnerId { get; set; }
        /// <summary>
        /// The winner of this match.
        /// </summary>
        public TeamModel Winner { get; set; }
        /// <summary>
        /// Which round this match is a part of.
        /// </summary>
        public int MatchupRound { get; set; }

        public string DisplayName
        {
            get
            {
                StringBuilder sb = new StringBuilder();
                foreach (MatchupEntryModel me in Entries)
                {
                    if (sb.Length == 0)
                    {
                        if (me.TeamCompeting == null)
                        {
                            sb.Append("TBD");
                        }
                        else
                        {
                            sb.Append(me.TeamCompeting.TeamName);
                        }
                    }
                    else
                    {
                        sb.Append("  VS  ");
                        if (me.TeamCompeting == null)
                        {
                            sb.Append("TBD");
                        }
                        else
                        {
                            sb.Append(me.TeamCompeting.TeamName);
                        }
                    }
                }
                return sb.ToString();
            }
        }
    }
}
