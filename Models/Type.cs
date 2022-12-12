using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokemonVisualization
{
    internal class Type
    {
        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("HexColor")]
        public string HexColor { get; set; }
    }
}
