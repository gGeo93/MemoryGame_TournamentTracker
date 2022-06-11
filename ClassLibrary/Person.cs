using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class Person
    {
        public int? TournamentId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Email { get; set; }

        public string CellPhone { get; set; }

        public int InstantScore { get; set; }

        public Person(int? id, string FirstName, string LastName, string Email, string CellPhone)
        {
            TournamentId = id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Email = Email;
            this.CellPhone = CellPhone;
        }

        public Person(int? id, string FirstName, string LastName,int InstantScore)
        {
            TournamentId = id;
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.InstantScore = InstantScore;
        }
        public Person()
        {

        }
    }
}
