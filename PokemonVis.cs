using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace PokemonVisualization
{
    public partial class PokemonVis : Form
    {
        internal Services services = new Services();
        List<Pokemon> currentResults = new List<Pokemon>();
        List<Type> types = new List<Type>();

        bool chartsReady = false;

        public PokemonVis()
        {
            InitializeComponent();
            ClearStatsChart();
            BindTypes();
            BindGenerations();
            Start();
        }

        /// <summary>
        /// Logic to ensure components are in correct state on start
        /// </summary>
        private void Start()
        {
            TypeDropdown.Enabled = checkBox1.Checked;
            GenDropdown.Enabled = checkBox2.Checked;

            textBox1.ReadOnly = true;

            panel2.Visible = false;
        }

        /// <summary>
        /// Fetch types and set as the datasource for TypeDropdown
        /// </summary>
        private void BindTypes()
        {
            try
            {
                types = services.GetTypes().Result;
                TypeDropdown.DataSource = types;
                TypeDropdown.DisplayMember = "Name";
            }
            catch (Exception e)
            {

                services.Errors.Add(new Error(e.Message, e.Source));
            }
        }

        /// <summary>
        /// Fetch generations and set as the datasource for GenDropdown
        /// </summary>
        private void BindGenerations()
        {
            try
            {
                var regions = services.GetGenerations().Result;
                GenDropdown.DataSource = regions;
                GenDropdown.DisplayMember = "Region_Name";
                GenDropdown.ValueMember = "Generation_Number";
            }
            catch (Exception e)
            {
                services.Errors.Add(new Error(e.Message, e.Source));
            }
        }

        /// <summary>
        /// Fetch pokemon filtered off dropdowns, display results in PokemonList
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GetResults_Click(object sender, EventArgs e)
        {
            string type = checkBox1.Checked ? TypeDropdown.Text : "null";
            int genNum = checkBox2.Checked ? (int)GenDropdown.SelectedValue : 0; 
            try
            {
                currentResults = services.GetFilteredPokemon(type, genNum).Result;
                PokemonList.DisplayMember = "Name";
                PokemonList.DataSource = currentResults;
                
            }
            catch (Exception ex)
            {
                services.Errors.Add(new Error(ex.Message, ex.Source));
            }
        }

        /// <summary>
        /// Clear chart components
        /// </summary>
        void ClearStatsChart()
        {
            StatsChart.Series.Clear();
            StatsChart.ChartAreas.Clear();
            StatsChart.Titles.Clear();
        }

        /// <summary>
        /// Update charts, text and colors on the selection of a new pokemon
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            HandleChartOne();
            HandleText();

            panel1.BackColor = ColorTranslator.FromHtml(GetHexCode(currentResults[PokemonList.SelectedIndex].Type_1));
            textBox1.BackColor = ColorTranslator.FromHtml(GetHexCode(currentResults[PokemonList.SelectedIndex].Type_2) ?? GetHexCode(currentResults[PokemonList.SelectedIndex].Type_1));
        }

        /// <summary>
        /// Map current pokemon to labels
        /// </summary>
        private void HandleText()
        {
            textBox1.Text = currentResults[PokemonList.SelectedIndex].Name;
            label8.Text = currentResults[PokemonList.SelectedIndex].Pokedex_Number.ToString();
            label9.Text = currentResults[PokemonList.SelectedIndex].Type_1;
            label10.Text = currentResults[PokemonList.SelectedIndex].Type_2;
            label11.Text = currentResults[PokemonList.SelectedIndex].BaseStatTotal.ToString();
            label12.Text = currentResults[PokemonList.SelectedIndex].Region_Name;
        }

        /// <summary>
        /// Assign correct data for stats chart
        /// </summary>
        private void HandleChartOne()
        {
            ClearStatsChart();

            StatsChart.Titles.Add("Base Stat Totals");
            StatsChart.BackColor = Color.Transparent;

            var Area1 = StatsChart.ChartAreas.Add("Area1");
            Area1.AxisY.Maximum = 255;
            Area1.AxisX.Interval = 1;

            var chartSeries = StatsChart.Series.Add("Series1");
            chartSeries.ChartType = SeriesChartType.Radar;
            chartSeries.IsValueShownAsLabel = true;
            chartSeries.LabelBackColor = ColorTranslator.FromHtml(GetHexCode(currentResults[PokemonList.SelectedIndex].Type_1));
            chartSeries.Palette = ChartColorPalette.Grayscale;
            chartSeries.ShadowColor = ColorTranslator.FromHtml(GetHexCode(currentResults[PokemonList.SelectedIndex].Type_1));
            chartSeries.ShadowOffset = 1;
            chartSeries.IsVisibleInLegend = false;

            chartSeries.Points.AddXY("HP", currentResults[PokemonList.SelectedIndex].HP);
            chartSeries.Points.AddXY("Attack", currentResults[PokemonList.SelectedIndex].Attack);
            chartSeries.Points.AddXY("Defense", currentResults[PokemonList.SelectedIndex].Defense);
            chartSeries.Points.AddXY("Speed", currentResults[PokemonList.SelectedIndex].Speed);
            chartSeries.Points.AddXY("Sp.Def", currentResults[PokemonList.SelectedIndex].Sp_Def);
            chartSeries.Points.AddXY("Sp.Atk", currentResults[PokemonList.SelectedIndex].Sp_Atk);

        }
        
        /// <summary>
        /// Enable/Disable type dropdown on check/uncheck
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            TypeDropdown.Enabled = checkBox1.Checked;
        }

        /// <summary>
        /// Enable/Disable gen dropdown on check/uncheck
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            GenDropdown.Enabled = checkBox2.Checked;
        }

        /// <summary>
        /// Look up hex code by type from type cache
        /// </summary>
        /// <param name="_type"></param>
        /// <returns></returns>
        private string GetHexCode(string _type)
        {
            foreach (var type in types)
            {
                if (_type == type.Name)
                {
                    return $"#{type.HexColor}";
                }
            }

            return null;
        }

        /// <summary>
        /// Enable/disable additional charts on button click, assign data if first viewing
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TypeChartButton_Click(object sender, EventArgs e)
        {
            panel2.Visible = !panel2.Visible;

            if (panel2.Visible && !chartsReady)
            {
                try
                {
                    HandleTypeChart();
                    HandleGenChart();
                    chartsReady = true;
                }
                catch (Exception ex)
                {

                    services.Errors.Add(new Error(ex.Message, ex.Source));
                }
            }

        }

        /// <summary>
        /// Assign correct data for type chart
        /// </summary>
        private void HandleTypeChart()
        {
            TypeChart.Series.Clear();
            TypeChart.ChartAreas.Clear();
            TypeChart.Titles.Clear();

            TypeChart.Titles.Add("Average BST By Type");

            var Area1 = TypeChart.ChartAreas.Add("Area1");
            Area1.AxisX.Interval = 1;


            var chartSeries = TypeChart.Series.Add("Average BST By Type");
            chartSeries.ChartType = SeriesChartType.Bar;
            chartSeries.IsValueShownAsLabel = true;
            chartSeries.IsVisibleInLegend = false;
            chartSeries.LabelBackColor = Color.AntiqueWhite;

            List<DataModel> results = services.GetChartRequest("get-type-chart").Result;
            var ordered = results.OrderBy(x => x.Y).ToList();


            for (int i = 0; i < ordered.Count; i++)
            {
                chartSeries.Points.AddXY(ordered[i].X, ordered[i].Y);
                chartSeries.Points[i].Color = ColorTranslator.FromHtml(GetHexCode(ordered[i].X));
            }
        }

        /// <summary>
        /// Assign correct data for gen chart
        /// </summary>
        private void HandleGenChart()
        {
            GenChart.Series.Clear();
            GenChart.ChartAreas.Clear();
            GenChart.Titles.Clear();

            GenChart.Titles.Add("Pokemon Introduced By Region");

            var Area1 = GenChart.ChartAreas.Add("Area1");
            Area1.AxisX.Title = "Region";
            Area1.AxisY.Title = "Pokemon Introduced";
            Area1.AxisX.TitleAlignment = StringAlignment.Center;
            Area1.AxisY.TitleAlignment = StringAlignment.Center;
            Area1.AxisY.Minimum = 400;
            Area1.AxisY.Maximum = 500;


            var chartSeries = GenChart.Series.Add("Pokemon Introduced By Region");
            chartSeries.ChartType = SeriesChartType.Funnel;
            chartSeries.IsValueShownAsLabel = true;
            chartSeries.IsVisibleInLegend = true;


            List<DataModel> results = services.GetChartRequest("get-generation-chart").Result;

            for (int i = results.Count - 1; i >= 0; i--)
            {
                chartSeries.Points.AddXY(results[i].X, results[i].Y);
            }
        }
    }
}
