using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CityStats_front_end.Models
{
    public class JokeModel
    {

        public long Id { get; set; }
        public string? Type { get; set; }
        public string? Setup { get; set; }
        public string? Punchline { get; set; }

    }
}
