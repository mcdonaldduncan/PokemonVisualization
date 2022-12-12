using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonVisualization
{
    internal class Log
    {
        public string RequestName { get; set; }
        public string StatusMessage { get; set; }
        public string StatusCode { get; set; }
        public DateTime LogTime { get; set; }

        public Log(string requestName, string statusMessage, string statusCode, DateTime logTime)
        {
            RequestName = requestName;
            StatusMessage = statusMessage;
            StatusCode = statusCode;
            LogTime = logTime;
        }

        public override string ToString()
        {
            return $"Request: {RequestName}\nStatus: {StatusMessage}\nCode: {StatusCode}\nTime: {LogTime}\n";
        }
    }
}
