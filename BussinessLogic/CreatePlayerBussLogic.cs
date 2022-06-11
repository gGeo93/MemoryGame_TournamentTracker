using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using ClassLibrary;
using Repository;

namespace BussinessLogic
{
    public class CreatePlayerBussLogic
    {
        private static List<Person> PeopleToSerelialize = new List<Person>();

        private static string[] playersInfo = new string[10];//Μπορεί να γίνει λίστα

        public static void Serializes(int NumberOfEntry,string FirstName, string LastName, string Email, string Cellphone)
        {
            Person p = new Person(NumberOfEntry, FirstName, LastName, Email, Cellphone);
            PeopleToSerelialize.Add(p);
        }

        public static void Serializes(string PlayerToRemove)
        {
            PlayersRepository.RemovePlayerFromTxt(PlayerToRemove);
        }

        public static void AddElementsToPlayersInfoTxt()
        {
            PlayersRepository.InputPlayersToTxt(PeopleToSerelialize);
            PeopleToSerelialize.Clear();
        }

        public static void AddElementsToPlayersInfoTxt(List<Person> People, string nulll)
        {

        }


        public static void DragElementsFromPlayersInfoTxt()//Πρόβλημα
        {
            playersInfo = PlayersRepository.OutputPlayersFromTxt();
        }

        public static void DragElementsFromPlayersInfoTxt(string nulll)//Πρόβλημα
        {
            playersInfo = PlayersRepository.OutputPlayersFromTxt(null);
        }

        public static List<Person> Deserialize()
        {
            List<Person> PeopleToDeserialize = new List<Person>();
            DragElementsFromPlayersInfoTxt(null);
            int counterForAutoIncrement = 0;
            foreach (var item in playersInfo)
            {
                counterForAutoIncrement++;
                if (item != "")
                {
                    string[] strSplit = item.Split(',');
                    Person p = new Person(counterForAutoIncrement, strSplit[1], strSplit[2], strSplit[3], strSplit[4]);
                    PeopleToDeserialize.Add(p);
                }
            }
            //playersInfo.Initialize();
            return PeopleToDeserialize;
        }
    }
}
