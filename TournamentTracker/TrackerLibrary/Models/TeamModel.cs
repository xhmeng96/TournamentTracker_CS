using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class TeamModel
    {
        public int Id { get; set; }

        /// <summary>
        /// Name of the team
        /// </summary>
        public string TeamName { get; set; } = "";

        /// <summary>
        /// Members in the team
        /// </summary>
        public List<PersonModel> TeamMembers { get; set; } = new List<PersonModel>();
    }
}
