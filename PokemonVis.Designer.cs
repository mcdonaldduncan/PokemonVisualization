namespace PokemonVisualization
{
    partial class PokemonVis
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.TypeDropdown = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GenDropdown = new System.Windows.Forms.ComboBox();
            this.GetResults = new System.Windows.Forms.Button();
            this.PokemonList = new System.Windows.Forms.ListBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.GenChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TypeChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.StatsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.TypeChartButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GenChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TypeChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatsChart)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.TypeDropdown.FormattingEnabled = true;
            this.TypeDropdown.Location = new System.Drawing.Point(83, 7);
            this.TypeDropdown.Name = "comboBox1";
            this.TypeDropdown.Size = new System.Drawing.Size(121, 21);
            this.TypeDropdown.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(36, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Region";
            // 
            // comboBox2
            // 
            this.GenDropdown.FormattingEnabled = true;
            this.GenDropdown.Location = new System.Drawing.Point(83, 36);
            this.GenDropdown.Name = "comboBox2";
            this.GenDropdown.Size = new System.Drawing.Size(121, 21);
            this.GenDropdown.TabIndex = 3;
            // 
            // GetResults
            // 
            this.GetResults.Location = new System.Drawing.Point(15, 67);
            this.GetResults.Name = "GetResults";
            this.GetResults.Size = new System.Drawing.Size(189, 23);
            this.GetResults.TabIndex = 5;
            this.GetResults.Text = "Get Results";
            this.GetResults.UseVisualStyleBackColor = true;
            this.GetResults.Click += new System.EventHandler(this.GetResults_Click);
            // 
            // listBox1
            // 
            this.PokemonList.FormattingEnabled = true;
            this.PokemonList.Location = new System.Drawing.Point(15, 96);
            this.PokemonList.Name = "listBox1";
            this.PokemonList.Size = new System.Drawing.Size(189, 433);
            this.PokemonList.TabIndex = 6;
            this.PokemonList.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.StatsChart);
            this.panel1.Location = new System.Drawing.Point(216, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(836, 561);
            this.panel1.TabIndex = 7;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.GenChart);
            this.panel2.Controls.Add(this.TypeChart);
            this.panel2.Location = new System.Drawing.Point(0, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(836, 553);
            this.panel2.TabIndex = 12;
            // 
            // chart3
            // 
            chartArea4.Name = "ChartArea1";
            this.GenChart.ChartAreas.Add(chartArea4);
            legend4.Alignment = System.Drawing.StringAlignment.Center;
            legend4.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend4.Name = "Legend1";
            this.GenChart.Legends.Add(legend4);
            this.GenChart.Location = new System.Drawing.Point(7, 0);
            this.GenChart.Name = "chart3";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Series1";
            this.GenChart.Series.Add(series4);
            this.GenChart.Size = new System.Drawing.Size(406, 546);
            this.GenChart.TabIndex = 1;
            this.GenChart.Text = "chart3";
            // 
            // chart2
            // 
            chartArea5.Name = "ChartArea1";
            this.TypeChart.ChartAreas.Add(chartArea5);
            legend5.Alignment = System.Drawing.StringAlignment.Center;
            legend5.Docking = System.Windows.Forms.DataVisualization.Charting.Docking.Bottom;
            legend5.Name = "Legend1";
            this.TypeChart.Legends.Add(legend5);
            this.TypeChart.Location = new System.Drawing.Point(419, -1);
            this.TypeChart.Name = "chart2";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.TypeChart.Series.Add(series5);
            this.TypeChart.Size = new System.Drawing.Size(407, 546);
            this.TypeChart.TabIndex = 0;
            this.TypeChart.Text = "chart2";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(205, 181);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(0, 13);
            this.label12.TabIndex = 11;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(205, 158);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(0, 13);
            this.label11.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(205, 134);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(0, 13);
            this.label10.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(205, 111);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 13);
            this.label9.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(205, 89);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 181);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Region";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Base Stat Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 134);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Secondary Type";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 111);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Primary Type";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Pokedex #";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.textBox1.Font = new System.Drawing.Font("Poppins ExtraBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(3, 5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(830, 78);
            this.textBox1.TabIndex = 1;
            // 
            // chart1
            // 
            chartArea6.Name = "ChartArea1";
            this.StatsChart.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.StatsChart.Legends.Add(legend6);
            this.StatsChart.Location = new System.Drawing.Point(270, 89);
            this.StatsChart.Name = "chart1";
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.StatsChart.Series.Add(series6);
            this.StatsChart.Size = new System.Drawing.Size(563, 469);
            this.StatsChart.TabIndex = 0;
            this.StatsChart.Text = "chart1";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(15, 10);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(15, 14);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(15, 39);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(15, 14);
            this.checkBox2.TabIndex = 9;
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // TypeChartButton
            // 
            this.TypeChartButton.Location = new System.Drawing.Point(15, 535);
            this.TypeChartButton.Name = "TypeChartButton";
            this.TypeChartButton.Size = new System.Drawing.Size(189, 32);
            this.TypeChartButton.TabIndex = 10;
            this.TypeChartButton.Text = "Additional Charts";
            this.TypeChartButton.UseVisualStyleBackColor = true;
            this.TypeChartButton.Click += new System.EventHandler(this.TypeChartButton_Click);
            // 
            // PokemonVis
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 579);
            this.Controls.Add(this.TypeChartButton);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.PokemonList);
            this.Controls.Add(this.GetResults);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.GenDropdown);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TypeDropdown);
            this.Name = "PokemonVis";
            this.Text = "Pokemon Sidecar";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GenChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TypeChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StatsChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox TypeDropdown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox GenDropdown;
        private System.Windows.Forms.Button GetResults;
        private System.Windows.Forms.ListBox PokemonList;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.DataVisualization.Charting.Chart StatsChart;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button TypeChartButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart GenChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart TypeChart;
    }
}

