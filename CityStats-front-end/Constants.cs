using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityStats_front_end
{
    public static class Constants
    {

        public static Dictionary<int, string> weathercodeDict = new Dictionary<int, string>
        {
                { 0, "Clear Sky" },
                { 1, "Mainly Clear" },
                { 2, "Partly Cloudy" },
                { 3, "Overcast" },
                { 45, "Fog" },
                { 48, "Depositing" },
                { 51, "Rime Fog" },
                { 53, "Light Drizzle" },
                { 55, "Moderate Drizzle" },
                { 56, "Dense Drizzle" },
                { 57, "Freezing Drizzle" },
                { 61, "Slight Rain" },
                { 63, "Moderate Rain" },
                { 65, "Heavy Rain" },
                { 66, "Freezing Rain" },
                { 67, "Freezing Rain" },
                { 71, "Slight Snow" },
                { 73, "Moderate Snow" },
                { 75, "Heavy Snow" },
                { 77, "Snow grains" },
                { 80, "Rain Shower" },
                { 81, "Rain Shower" },
                { 82, "Rain Shower" },
                { 85, "Snow Shower" },
                { 86, "Snow Shower" },
                { 95, "Thunderstorm" },
                { 96, "Thunderstorm" },
                { 99, "Thunderstorm" },
            };
    }
}
