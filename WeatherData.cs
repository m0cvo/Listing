using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listing
{
    public class WeatherData
    {
        private int tempC;
        private string d;
        private int id;
               
        public int idNumber
        {
            get; set;
        }
        public string date
        { get; set; }

        public int temperatureC
        { get; set; }

        public WeatherData()
        {
            tempC = temperatureC;
            d = date;
            id = idNumber;

        }
    }
}
