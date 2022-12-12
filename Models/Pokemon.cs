using System.Text.Json.Serialization;

namespace PokemonVisualization
{
    internal class Pokemon
    {
        [JsonPropertyName("ID")]
        public int ID { get; set; }

        [JsonPropertyName("Pokedex_Number")]
        public int Pokedex_Number { get; set; }

        [JsonPropertyName("Name")]
        public string Name { get; set; }

        [JsonPropertyName("Type_1")]
        public string Type_1 { get; set; }

        [JsonPropertyName("Type_2")]
        public string Type_2 { get; set; }

        [JsonPropertyName("HP")]
        public int HP { get; set; }

        [JsonPropertyName("Attack")]
        public int Attack { get; set; }

        [JsonPropertyName("Defense")]
        public int Defense { get; set; }

        [JsonPropertyName("Sp_Atk")]
        public int Sp_Atk { get; set; }

        [JsonPropertyName("Sp_Def")]
        public int Sp_Def { get; set; }

        [JsonPropertyName("Speed")]
        public int Speed { get; set; }

        [JsonPropertyName("Generation_Number")]
        public int Generation_Number { get; set; }

        [JsonPropertyName("Region_Name")]
        public string Region_Name { get; set; }


        public int BaseStatTotal => HP + Attack + Defense + Sp_Atk + Sp_Def + Speed;
    }
}
