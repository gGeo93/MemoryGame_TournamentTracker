using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class TournamentMode
    {
        public string TournamentName { get; set; }

        public decimal EntryFee { get; set; }

        public List<Person> EnteredPeople { get; set; } = new List<Person>();

        public List<PrizeModel> Prizes { get; set; } = new List<PrizeModel>();

        //public List<TournamentRound> Rounds { get; set; }
    }
}
