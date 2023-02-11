using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PrizeModel
    {
        /// <summary>
        /// unique id
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Ranking.
        /// </summary>
        public int PlaceNumber { get; set; } = 0;

        /// <summary>
        /// Place name, e.g. champion.
        /// </summary>
        public string PlaceName { get; set; } = "";

        /// <summary>
        /// Money amount of prize.
        /// </summary>
        public decimal PrizeAmount { get; set; } = 0;

        /// <summary>
        /// Percentage of prize distribution.
        /// </summary>
        public double PrizePercentage { get; set; } = 0.0;
    }
}
