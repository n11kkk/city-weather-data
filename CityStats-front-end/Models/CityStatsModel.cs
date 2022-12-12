using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityStats_front_end.Models
{
    public partial class CityStats
    {
        public float latitude { get; set; }
        public float longitude { get; set; }
        public float generationtime_ms { get; set; }
        public int utc_offset_seconds { get; set; }
        public string timezone { get; set; }
        public string timezome_abbreviation { get; set; }
        public float elevation { get; set; }
        public DailyUnits daily_units { get; set; }
        public Daily daily { get; set; }
    }

    public partial class Daily
    {
        public List<DateTimeOffset> time { get; set; }
        public List<int> weathercode { get; set; }
        public List<float> temperature_2m_max { get; set; }
        public List<float> temperature_2m_min { get; set; }
        public List<string> sunrise { get; set; }
        public List<string> sunset { get; set; }
        public List<float> windspeed_10m_max { get; set; }
    }

    public partial class DailyUnits
    {
        public string time { get; set; }
        public string weathercode { get; set; }
        public string temperature_2m_max { get; set; }
        public string temperature_2m_min { get; set; }
        public string sunrise { get; set; }
        public string sunset { get; set; }
        public string windspeed_10m_max { get; set; }
    }
}
