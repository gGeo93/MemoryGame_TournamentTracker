 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class TournamentRound
    {
        public int CurrentRound { get; set; }

        public string CurrentRoundName { get; set; }

        public Dictionary<int, string> CurrentRoundAndName = new Dictionary<int, string>()
        {{0, "Initial State" }, {1, "First" }, { 2, "Second" }, {3, "Third" } };

        public List<Person> Candidates { get; set; } = new List<Person>();

        public List<int> ScoresPerPlayer { get; set; } = new List<int>();
    }
}
