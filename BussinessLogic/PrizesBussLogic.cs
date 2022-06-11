using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary;
using Repository;

namespace BussinessLogic
{
    public class PrizesBussLogic
    {
        public static List<PrizeModel> ListOfPrizes = new List<PrizeModel>();

        public static void Serialize(string PlaceNumber,string PlayceName,string PrizeAmount,string PrizePercentage)
        {
            PrizeModel p = new PrizeModel(PlaceNumber,PlayceName,PrizeAmount,PrizePercentage);
            ListOfPrizes.Add(p);
        }

        public static void Serialize(string PrizeToRemove)
        {
            PrizesRepository.RemovePrizeFromTxt(PrizeToRemove);
        }

        public static void AddElementsToPrizesinfoTxt(List<PrizeModel> ListOfPrizes)
        {
            PrizesRepository.InputPrizesToTxt(ListOfPrizes);
        }
        
        public static List<string> DragElementsFromPrizesInfoTxt()
        {
            List<string> OutputPrizes = new List<string>();
            OutputPrizes = PrizesRepository.OutputPrizesFromTxt();
            return OutputPrizes;
        }

        public static List<PrizeModel> Deserialize()
        {
            List<string> strList = DragElementsFromPrizesInfoTxt();
            List<PrizeModel> listOfPM = new List<PrizeModel>();
            string[] strSplit = new string[4];
            foreach (var item in strList)
            {
                if (item != "")
                {
                    strSplit = item.Split(',');
                    PrizeModel PM = new PrizeModel(strSplit[0], strSplit[1], strSplit[2], strSplit[3]);
                    listOfPM.Add(PM);
                }
            }
            return listOfPM;
        }
    }
}
