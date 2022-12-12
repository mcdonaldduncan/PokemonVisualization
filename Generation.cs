using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PokemonVisualization
{
    internal class Generation
    {
        [JsonPropertyName("Generation_Number")]
        public int Generation_Number { get; set; }

        [JsonPropertyName("Region_Name")]
        public string Region_Name { get; set; }
    }
}
