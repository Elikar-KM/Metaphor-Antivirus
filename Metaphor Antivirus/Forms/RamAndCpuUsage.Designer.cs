
namespace Metaphor_Antivirus
{
    partial class RamAndCpuUsage
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RamAndCpuUsage));
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.ProgressBarCpu = new ns1.BunifuCircleProgressbar();
            this.ProgressBarRam = new ns1.BunifuCircleProgressbar();
            this.CpuLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.pCPU = new System.Diagnostics.PerformanceCounter();
            this.pRAM = new System.Diagnostics.PerformanceCounter();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BackSecondaryColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.chart1.BorderlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.chart1.BorderSkin.BackColor = System.Drawing.Color.Transparent;
            this.chart1.BorderSkin.BorderColor = System.Drawing.Color.Transparent;
            this.chart1.BorderSkin.PageColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisX2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY2.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(155, 13);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Excel;
            series1.BackImageTransparentColor = System.Drawing.Color.Transparent;
            series1.BackSecondaryColor = System.Drawing.Color.Transparent;
            series1.BorderColor = System.Drawing.Color.Transparent;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Cyan;
            series1.EmptyPointStyle.Color = System.Drawing.Color.Transparent;
            series1.EmptyPointStyle.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            series1.EmptyPointStyle.LabelBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            series1.EmptyPointStyle.LabelForeColor = System.Drawing.Color.Transparent;
            series1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            series1.LabelBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            series1.LabelBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            series1.Legend = "Legend1";
            series1.Name = "CPU";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Red;
            series2.Legend = "Legend1";
            series2.Name = "RAM";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(427, 319);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // ProgressBarCpu
            // 
            this.ProgressBarCpu.animated = false;
            this.ProgressBarCpu.animationIterval = 5;
            this.ProgressBarCpu.animationSpeed = 300;
            this.ProgressBarCpu.BackColor = System.Drawing.Color.Transparent;
            this.ProgressBarCpu.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ProgressBarCpu.BackgroundImage")));
            this.ProgressBarCpu.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.ProgressBarCpu.ForeColor = System.Drawing.Color.White;
            this.ProgressBarCpu.LabelVisible = true;
            this.ProgressBarCpu.LineProgressThickness = 8;
            this.ProgressBarCpu.LineThickness = 5;
            this.ProgressBarCpu.Location = new System.Drawing.Point(19, 13);
            this.ProgressBarCpu.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.ProgressBarCpu.MaxValue = 100;
            this.ProgressBarCpu.Name = "ProgressBarCpu";
            this.ProgressBarCpu.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.ProgressBarCpu.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.ProgressBarCpu.Size = new System.Drawing.Size(123, 123);
            this.ProgressBarCpu.TabIndex = 1;
            this.ProgressBarCpu.Value = 0;
            // 
            // ProgressBarRam
            // 
            this.ProgressBarRam.animated = false;
            this.ProgressBarRam.animationIterval = 5;
            this.ProgressBarRam.animationSpeed = 300;
            this.ProgressBarRam.BackColor = System.Drawing.Color.Transparent;
            this.ProgressBarRam.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ProgressBarRam.BackgroundImage")));
            this.ProgressBarRam.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.ProgressBarRam.ForeColor = System.Drawing.Color.White;
            this.ProgressBarRam.LabelVisible = true;
            this.ProgressBarRam.LineProgressThickness = 8;
            this.ProgressBarRam.LineThickness = 5;
            this.ProgressBarRam.Location = new System.Drawing.Point(19, 186);
            this.ProgressBarRam.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.ProgressBarRam.MaxValue = 100;
            this.ProgressBarRam.Name = "ProgressBarRam";
            this.ProgressBarRam.ProgressBackColor = System.Drawing.Color.Gainsboro;
            this.ProgressBarRam.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.ProgressBarRam.Size = new System.Drawing.Size(123, 123);
            this.ProgressBarRam.TabIndex = 2;
            this.ProgressBarRam.Value = 0;
            // 
            // CpuLbl
            // 
            this.CpuLbl.AutoSize = true;
            this.CpuLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.CpuLbl.ForeColor = System.Drawing.Color.White;
            this.CpuLbl.Location = new System.Drawing.Point(61, 137);
            this.CpuLbl.Name = "CpuLbl";
            this.CpuLbl.Size = new System.Drawing.Size(42, 20);
            this.CpuLbl.TabIndex = 3;
            this.CpuLbl.Text = "CPU";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(61, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "RAM";
            // 
            // timer
            // 
            this.timer.Interval = 1000;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // pCPU
            // 
            this.pCPU.CategoryName = "Processor";
            this.pCPU.CounterName = "% Processor Time";
            this.pCPU.InstanceName = "_Total";
            // 
            // pRAM
            // 
            this.pRAM.CategoryName = "Memory";
            this.pRAM.CounterName = "% Committed Bytes In Use";
            // 
            // RamAndCpuUsage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.ClientSize = new System.Drawing.Size(583, 344);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CpuLbl);
            this.Controls.Add(this.ProgressBarRam);
            this.Controls.Add(this.ProgressBarCpu);
            this.Controls.Add(this.chart1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "RamAndCpuUsage";
            this.ShowIcon = false;
            this.Text = "Ram & Cpu Usage";
            this.Load += new System.EventHandler(this.RamAndCpuUsage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pCPU)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pRAM)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private ns1.BunifuCircleProgressbar ProgressBarCpu;
        private ns1.BunifuCircleProgressbar ProgressBarRam;
        private System.Windows.Forms.Label CpuLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer;
        private System.Diagnostics.PerformanceCounter pCPU;
        private System.Diagnostics.PerformanceCounter pRAM;
    }
}