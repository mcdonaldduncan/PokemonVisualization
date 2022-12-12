using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PokemonVisualization
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            PokemonVis pokemonVis = new PokemonVis();
            Application.Run(pokemonVis);

            pokemonVis.services.GenerateLogFile();
            pokemonVis.services.ReportErrors();
            pokemonVis.services.ReportFinalErrors();

            pokemonVis.Dispose();
        }
    }
}
