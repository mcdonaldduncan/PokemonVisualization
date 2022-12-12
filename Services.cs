using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.Http;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using static PokemonVisualization.Constant;

namespace PokemonVisualization
{
    internal class Services
    {
        public List<Error> errors = new List<Error>();
        List<Log> logs = new List<Log>();

        
        public async Task<List<DataModel>> GetChartRequest(string requestName)
        {
            List<DataModel> dataModels = new List<DataModel>();

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:7047/Pokemon/");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = client.GetAsync(requestName).Result;
                    dataModels = JsonConvert.DeserializeObject<List<DataModel>>(await response.Content.ReadAsStringAsync());

                    logs.Add(new Log(requestName, response.RequestMessage?.ToString(), response.StatusCode.ToString(), DateTime.Now));
                }

            }
            catch (Exception e)
            {
                errors.Add(new Error(e.Message, e.Source));
            }

            return dataModels;
        }

        
        public async Task<List<Pokemon>> GetFilteredPokemon(string Type, int GenNum)
        {
            List<Pokemon> pokemon = new List<Pokemon>();

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:7047/Pokemon/");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = client.GetAsync($"get-filtered/{Type}/{GenNum}").Result;
                    pokemon = JsonConvert.DeserializeObject<List<Pokemon>>(await response.Content.ReadAsStringAsync());

                    logs.Add(new Log("GetFilteredPokemon", response.RequestMessage?.ToString(), response.StatusCode.ToString(), DateTime.Now));
                }

            }
            catch (Exception e)
            {
                errors.Add(new Error(e.Message, e.Source));
            }

            return pokemon;
        }
    

        public async Task<List<Generation>> GetGenerations()
        {
            List<Generation> generations = new List<Generation>();

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:7047/Pokemon/");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = client.GetAsync("get-regions").Result;
                    generations = JsonConvert.DeserializeObject<List<Generation>>(await response.Content.ReadAsStringAsync());

                    logs.Add(new Log("GetGenerations", response.RequestMessage?.ToString(), response.StatusCode.ToString(), DateTime.Now));
                }

            }
            catch (Exception e)
            {
                errors.Add(new Error(e.Message, e.Source));
            }

            return generations;
        }
    
        
        public async Task<List<Type>> GetTypes()
        {
            List<Type> types = new List<Type>();

            try
            {
                using (HttpClient client = new HttpClient())
                {
                    client.BaseAddress = new Uri("https://localhost:7047/Pokemon/");
                    client.DefaultRequestHeaders.Accept.Clear();
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response = client.GetAsync("get-types").Result;
                    types = JsonConvert.DeserializeObject<List<Type>>(await response.Content.ReadAsStringAsync());

                    logs.Add(new Log("GetTypes", response.RequestMessage?.ToString(), response.StatusCode.ToString(), DateTime.Now));
                }

            }
            catch (Exception e)
            {
                errors.Add(new Error(e.Message, e.Source));
            }

            return types;
        }
    



        
        public void GenerateLogFile()
        {
            string writePath = Path.Combine(directoryPath, "logs.txt");

            try
            {
                if (File.Exists(writePath))
                {
                    File.Delete(writePath);
                }

                using (StreamWriter sw = new StreamWriter(writePath, true))
                {
                    sw.WriteLine($"Processed at: {DateTime.Now}");
                    sw.WriteLine();

                    foreach (var log in logs)
                    {
                        sw.WriteLine(log.ToString());
                    }
                }
            }
            catch (Exception e)
            {
                errors.Add(new Error(e.Message, e.Source));
            }
        }

        public void ReportErrors()
        {
            string writePath = Path.Combine(directoryPath, "errors.txt");

            try
            {
                if (File.Exists(writePath))
                {
                    File.Delete(writePath);
                }

                using (StreamWriter sw = new StreamWriter(writePath, true))
                {
                    sw.WriteLine($"Processed at: {DateTime.Now}");
                    sw.WriteLine();

                    foreach (var error in errors)
                    {
                        sw.WriteLine(error.ToString());
                    }
                }
            }
            catch (Exception e)
            {
                errors.Add(new Error(e.Message, e.Source));
            }
        }

        public void ReportFinalErrors()
        {
            foreach (var error in errors)
            {
                Console.WriteLine($"Error: {error.ErrorMessage} Source: {error.Source}");
            }
        }


    }
}
