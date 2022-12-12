using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net.Http.Json;
using System.Text;
using System.Threading.Tasks;
using CityStats_front_end.Models;
using CommunityToolkit.Mvvm.ComponentModel;


namespace CityStats_front_end.ViewModels
{
    public partial class ParisViewModel:ObservableObject
    {
        HttpClient _client;
        public ParisViewModel()
        {
            //Stats = new ObservableCollection<Daily>();
            _client = new HttpClient();
            Time = new();
            Weathercode = new();
            Temperature_2m_max = new();
            Temperature_2m_min = new();
            Sunrise = new();
            Sunset = new();
            Windspeed_10m_max = new();

        }

        [ObservableProperty]
        public ObservableCollection<DayOfWeek> time;

        [ObservableProperty]
        public ObservableCollection<string> weathercode;

        [ObservableProperty]
        public ObservableCollection<float> temperature_2m_max;

        [ObservableProperty]
        public ObservableCollection<float> temperature_2m_min;

        [ObservableProperty]
        public ObservableCollection<string> sunrise;

        [ObservableProperty]
        public ObservableCollection<string> sunset;

        [ObservableProperty]
        public ObservableCollection<float> windspeed_10m_max;




        public async Task<CityStats> GetStats()
        {
            var W_API = "https://localhost:7151/WeatherForecast";

            var result = await _client.GetAsync(W_API);

            var jsonRes = await result.Content.ReadFromJsonAsync<CityStats>();

            System.Diagnostics.Debug.WriteLine(jsonRes);



            //Stats.Add(jsonRes.daily);
            Time.Clear();
            Weathercode.Clear();
            Temperature_2m_max.Clear();
            Temperature_2m_min.Clear();
            Sunrise.Clear();
            Sunset.Clear();
            Windspeed_10m_max.Clear();
            for (int i = 0; i < jsonRes.daily.time.Count; i++)
            {
                Time.Add(jsonRes.daily.time[i].DayOfWeek);
                var x = "Clear";
                Constants.weathercodeDict.TryGetValue(jsonRes.daily.weathercode[i], out x);
                Weathercode.Add(x);
                Temperature_2m_max.Add(jsonRes.daily.temperature_2m_max[i]);
                Temperature_2m_min.Add(jsonRes.daily.temperature_2m_min[i]);
                Sunrise.Add(jsonRes.daily.sunrise[i].Split("T")[1]);
                Sunset.Add(jsonRes.daily.sunset[i].Split("T")[1]);
                Windspeed_10m_max.Add(jsonRes.daily.windspeed_10m_max[i]);
            }
            //Time.Add(jsonRes.daily.time);
            //Weathercode = jsonRes.daily.weathercode;
            //Temperature_2m_max = jsonRes.daily.temperature_2m_max;
            //Temperature_2m_min = jsonRes.daily.temperature_2m_min;
            //Sunrise = jsonRes.daily.sunrise;
            //Sunset = jsonRes.daily.sunset;
            //Windspeed_10m_max = jsonRes.daily.windspeed_10m_max;

            System.Diagnostics.Debug.WriteLine(jsonRes);
            System.Diagnostics.Debug.WriteLine(Sunrise);

            return jsonRes;
        }




        //[ObservableProperty]
        //public ObservableCollection<Daily> stats;

    }
}

