using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class PrizeModel
    {
        public int PlaceNumber { get; set; }

        public string PlaceName { get; set; }

        public decimal PrizeAmount { get; set; }

        public double PrizePercentage { get; set; }

        public PrizeModel(string placeNumber, string placeName, string prizeAmount, string prizePercentage)
        {
            PlaceNumber = Convert.ToInt32(placeNumber);
            PlaceName = placeName;
            PrizeAmount = Convert.ToDecimal(prizeAmount);
            PrizePercentage = Convert.ToDouble(prizePercentage);
        }
    }
}