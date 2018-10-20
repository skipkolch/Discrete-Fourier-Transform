namespace DPF
{
    partial class FormGrafic
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chartFunc = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chartSpectr = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartFurie = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chartFunc)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartSpectr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFurie)).BeginInit();
            this.SuspendLayout();
            // 
            // chartFunc
            // 
            chartArea1.Name = "ChartArea1";
            this.chartFunc.ChartAreas.Add(chartArea1);
            this.chartFunc.Dock = System.Windows.Forms.DockStyle.Top;
            legend1.Name = "Legend1";
            this.chartFunc.Legends.Add(legend1);
            this.chartFunc.Location = new System.Drawing.Point(0, 0);
            this.chartFunc.Name = "chartFunc";
            this.chartFunc.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            this.chartFunc.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Red};
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.Name = "Function";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Legend = "Legend1";
            series2.Name = "Alpha";
            this.chartFunc.Series.Add(series1);
            this.chartFunc.Series.Add(series2);
            this.chartFunc.Size = new System.Drawing.Size(808, 245);
            this.chartFunc.TabIndex = 0;
            this.chartFunc.Text = "chart1";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chartSpectr);
            this.panel1.Controls.Add(this.chartFurie);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 749);
            this.panel1.TabIndex = 1;
            // 
            // chartSpectr
            // 
            chartArea2.Name = "ChartArea1";
            this.chartSpectr.ChartAreas.Add(chartArea2);
            this.chartSpectr.Dock = System.Windows.Forms.DockStyle.Bottom;
            legend2.Name = "Legend1";
            this.chartSpectr.Legends.Add(legend2);
            this.chartSpectr.Location = new System.Drawing.Point(0, 587);
            this.chartSpectr.Name = "chartSpectr";
            this.chartSpectr.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series3.Legend = "Legend1";
            series3.Name = "Spectr";
            this.chartSpectr.Series.Add(series3);
            this.chartSpectr.Size = new System.Drawing.Size(808, 162);
            this.chartSpectr.TabIndex = 2;
            this.chartSpectr.Text = "chart3";
            // 
            // chartFurie
            // 
            chartArea3.Name = "ChartArea1";
            this.chartFurie.ChartAreas.Add(chartArea3);
            legend3.Name = "Legend1";
            this.chartFurie.Legends.Add(legend3);
            this.chartFurie.Location = new System.Drawing.Point(3, 251);
            this.chartFurie.Name = "chartFurie";
            this.chartFurie.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.chartFurie.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.Navy};
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series4.Legend = "Legend1";
            series4.Name = "Furie";
            this.chartFurie.Series.Add(series4);
            this.chartFurie.Size = new System.Drawing.Size(817, 233);
            this.chartFurie.TabIndex = 1;
            this.chartFurie.Text = "chart2";
            // 
            // FormGrafic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 749);
            this.Controls.Add(this.chartFunc);
            this.Controls.Add(this.panel1);
            this.Name = "FormGrafic";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGrafic";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormGrafic_FormClosing);
            this.Resize += new System.EventHandler(this.FormGrafic_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.chartFunc)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartSpectr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartFurie)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartSpectr;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFurie;
    }
}