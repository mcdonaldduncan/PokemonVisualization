﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokemonVisualization
{
    internal class Error
    {
        public string ErrorMessage { get; set; }
        public string Source { get; set; }

        public Error(string message, string source)
        {
            ErrorMessage = message;
            Source = source;
        }

        public override string ToString()
        {
            return $"Error: {ErrorMessage} Source: {Source}";
        }
    }
}
