using Microsoft.AspNetCore.Mvc;
using System.Text.Json;

namespace CityStats_back_end.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {

        

        HttpClient _client;
        public WeatherForecastController()
        {
            _client = new HttpClient();
        }

        readonly string WeatherAPI = "https://api.open-meteo.com/v1/forecast?latitude=48.85&longitude=2.35&daily=weathercode,temperature_2m_max,temperature_2m_min,sunrise,sunset,windspeed_10m_max&timezone=Europe%2FBerlin";

        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<CityStats> Get()
        {
            HttpResponseMessage res = await _client.GetAsync(WeatherAPI);
            System.Diagnostics.Debug.WriteLine(await res.Content.ReadAsStringAsync());
            string stringres = await res.Content.ReadAsStringAsync();
            //CityStats jsonRes = await res.Content.ReadFromJsonAsync<CityStats>();
            CityStats? jsonRes = JsonSerializer.Deserialize<CityStats>(stringres);


            System.Diagnostics.Debug.WriteLine("___________________JSON_______________ \n", jsonRes);

            DailyUnits du = new DailyUnits
            {
                time = jsonRes.daily_units.time,
                weathercode = jsonRes.daily_units.weathercode,
                temperature_2m_max = jsonRes.daily_units.temperature_2m_max,
                temperature_2m_min = jsonRes.daily_units.temperature_2m_min,
                sunrise = jsonRes.daily_units.sunrise,
                sunset = jsonRes.daily_units.sunset,
                windspeed_10m_max = jsonRes.daily_units.windspeed_10m_max
            };
            Daily dd = new Daily
            {
                time = jsonRes.daily.time,
                weathercode = jsonRes.daily.weathercode,
                temperature_2m_max = jsonRes.daily.temperature_2m_max,
                temperature_2m_min = jsonRes.daily.temperature_2m_min,
                sunrise = jsonRes.daily.sunrise,
                sunset = jsonRes.daily.sunset,
                windspeed_10m_max = jsonRes.daily.windspeed_10m_max
            };


            return new CityStats
            {
                latitude = jsonRes.latitude,
                longitude = jsonRes.longitude,
                generationtime_ms = jsonRes.generationtime_ms,
                utc_offset_seconds = jsonRes.utc_offset_seconds,
                timezone = jsonRes.timezone,
                timezome_abbreviation = jsonRes.timezome_abbreviation,
                elevation = jsonRes.elevation,
                daily_units = du,
                daily = dd

            };
        

    }
    }
}