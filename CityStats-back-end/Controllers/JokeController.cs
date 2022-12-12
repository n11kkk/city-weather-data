using Microsoft.AspNetCore.Mvc;

namespace CityStats_back_end.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class JokeController:ControllerBase
    {
        HttpClient _client;
        //readonly string WeatherAPI = "https://api.open-meteo.com/v1/forecast?latitude=37.69&longitude=-97.34&hourly=temperature_2m,relativehumidity_2m,precipitation,surface_pressure,visibility";
        readonly string JokeAPI = "https://official-joke-api.appspot.com/random_joke";

        public JokeController()
        {
            _client = new HttpClient();
        }

        [HttpGet(Name = "GetJoke")]
        public async Task<JokeModel> GetJoke()
        {
            HttpResponseMessage res = await _client.GetAsync(JokeAPI);
            System.Diagnostics.Debug.WriteLine(await res.Content.ReadAsStringAsync());
            var jsonRes = await res.Content.ReadFromJsonAsync<JokeModel>();
            string t = jsonRes.Type;
            string before = jsonRes.Setup;
            string after = jsonRes.Punchline;


            return new JokeModel
            {
                Id = jsonRes.Id,
                Type = t,
                Setup = before,
                Punchline = after

            };

        }

    }
}
