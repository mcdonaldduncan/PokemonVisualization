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

        public PokemonVis()
        {
            InitializeComponent();
            ClearChartOne();
            BindTypes();
            BindGenerations();
            Start();
        }

        private void Start()
        {
            comboBox1.Enabled = checkBox1.Checked;
            comboBox2.Enabled = checkBox2.Checked;

            textBox1.ReadOnly = true;

            panel2.Visible = false;
        }

        private void BindTypes()
        {
            try
            {
                types = services.GetTypes().Result;
                comboBox1.DataSource = types;
                comboBox1.DisplayMember = "Name";
            }
            catch (Exception e)
            {

                services.Errors.Add(new Error(e.Message, e.Source));
            }
        }

        private void BindGenerations()
        {
            try
            {
                var regions = services.GetGenerations().Result;
                comboBox2.DataSource = regions;
                comboBox2.DisplayMember = "Region_Name";
                comboBox2.ValueMember = "Generation_Number";
            }
            catch (Exception e)
            {

                services.Errors.Add(new Error(e.Message, e.Source));
            }
        }

        private void GetResults_Click(object sender, EventArgs e)
        {
            string type = checkBox1.Checked ? comboBox1.Text : "null";
            int genNum = checkBox2.Checked ? (int)comboBox2.SelectedValue : 0; 
            try
            {
                currentResults = services.GetFilteredPokemon(type, genNum).Result;
                listBox1.DisplayMember = "Name";
                listBox1.DataSource = currentResults;
                
            }
            catch (Exception ex)
            {

                services.Errors.Add(new Error(ex.Message, ex.Source));
            }
        }

        void ClearChartOne()
        {
            StatsChart.Series.Clear();
            StatsChart.ChartAreas.Clear();
            StatsChart.Titles.Clear();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            HandleChartOne();
            HandleText();

            panel1.BackColor = ColorTranslator.FromHtml(GetHexCode(currentResults[listBox1.SelectedIndex].Type_1));
            textBox1.BackColor = ColorTranslator.FromHtml(GetHexCode(currentResults[listBox1.SelectedIndex].Type_2) ?? GetHexCode(currentResults[listBox1.SelectedIndex].Type_1));
        }

        private void HandleText()
        {
            textBox1.Text = currentResults[listBox1.SelectedIndex].Name;
            label8.Text = currentResults[listBox1.SelectedIndex].Pokedex_Number.ToString();
            label9.Text = currentResults[listBox1.SelectedIndex].Type_1;
            label10.Text = currentResults[listBox1.SelectedIndex].Type_2;
            label11.Text = currentResults[listBox1.SelectedIndex].BaseStatTotal.ToString();
            label12.Text = currentResults[listBox1.SelectedIndex].Region_Name;
        }

        private void HandleChartOne()
        {
            ClearChartOne();

            StatsChart.Titles.Add("Base Stat Totals");
            StatsChart.BackColor = Color.Transparent;

            var Area1 = StatsChart.ChartAreas.Add("Area1");
            Area1.AxisY.Maximum = 255;
            Area1.AxisX.Interval = 1;

            var chartSeries = StatsChart.Series.Add("Series1");
            chartSeries.ChartType = SeriesChartType.Radar;
            chartSeries.IsValueShownAsLabel = true;
            chartSeries.LabelBackColor = ColorTranslator.FromHtml(GetHexCode(currentResults[listBox1.SelectedIndex].Type_1));
            chartSeries.Palette = ChartColorPalette.Grayscale;
            chartSeries.ShadowColor = ColorTranslator.FromHtml(GetHexCode(currentResults[listBox1.SelectedIndex].Type_1));
            chartSeries.ShadowOffset = 1;
            chartSeries.IsVisibleInLegend = false;

            chartSeries.Points.AddXY("HP", currentResults[listBox1.SelectedIndex].HP);
            chartSeries.Points.AddXY("Attack", currentResults[listBox1.SelectedIndex].Attack);
            chartSeries.Points.AddXY("Defense", currentResults[listBox1.SelectedIndex].Defense);
            chartSeries.Points.AddXY("Speed", currentResults[listBox1.SelectedIndex].Speed);
            chartSeries.Points.AddXY("Sp.Def", currentResults[listBox1.SelectedIndex].Sp_Def);
            chartSeries.Points.AddXY("Sp.Atk", currentResults[listBox1.SelectedIndex].Sp_Atk);

        }
        
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            comboBox1.Enabled = checkBox1.Checked;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            comboBox2.Enabled = checkBox2.Checked;
        }

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

        private void TypeChartButton_Click(object sender, EventArgs e)
        {
            panel2.Visible = !panel2.Visible;

            if (panel2.Visible)
            {
                try
                {
                    HandleTypeChart();
                    HandleGenChart();
                }
                catch (Exception ex)
                {

                    services.Errors.Add(new Error(ex.Message, ex.Source));
                }
            }

        }

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
