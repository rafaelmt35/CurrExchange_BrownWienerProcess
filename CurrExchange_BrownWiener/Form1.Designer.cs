namespace CurrExchange_BrownWiener
{
    partial class Form1
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btCalculate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.valueEUR = new System.Windows.Forms.NumericUpDown();
            this.valueUSD = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbEUR = new System.Windows.Forms.Label();
            this.lbUSD = new System.Windows.Forms.Label();
            this.lbDays = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.valueEUR)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueUSD)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 600;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick_1);
            // 
            // btCalculate
            // 
            this.btCalculate.Location = new System.Drawing.Point(825, 14);
            this.btCalculate.Margin = new System.Windows.Forms.Padding(2);
            this.btCalculate.Name = "btCalculate";
            this.btCalculate.Size = new System.Drawing.Size(99, 45);
            this.btCalculate.TabIndex = 5;
            this.btCalculate.Text = "START/STOP";
            this.btCalculate.UseVisualStyleBackColor = true;
            this.btCalculate.Click += new System.EventHandler(this.btCalculate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(259, 14);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "EUR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(134, 14);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "USD";
            // 
            // valueEUR
            // 
            this.valueEUR.DecimalPlaces = 2;
            this.valueEUR.Location = new System.Drawing.Point(232, 29);
            this.valueEUR.Margin = new System.Windows.Forms.Padding(2);
            this.valueEUR.Name = "valueEUR";
            this.valueEUR.Size = new System.Drawing.Size(90, 20);
            this.valueEUR.TabIndex = 2;
            this.valueEUR.Value = new decimal(new int[] {
            7928,
            0,
            0,
            131072});
            // 
            // valueUSD
            // 
            this.valueUSD.DecimalPlaces = 2;
            this.valueUSD.Location = new System.Drawing.Point(104, 29);
            this.valueUSD.Margin = new System.Windows.Forms.Padding(2);
            this.valueUSD.Name = "valueUSD";
            this.valueUSD.Size = new System.Drawing.Size(90, 20);
            this.valueUSD.TabIndex = 1;
            this.valueUSD.Value = new decimal(new int[] {
            742,
            0,
            0,
            65536});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Initial Price";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbEUR);
            this.panel1.Controls.Add(this.lbUSD);
            this.panel1.Controls.Add(this.lbDays);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.btCalculate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.valueEUR);
            this.panel1.Controls.Add(this.valueUSD);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(30, 26);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(949, 72);
            this.panel1.TabIndex = 1;
            // 
            // lbEUR
            // 
            this.lbEUR.AutoSize = true;
            this.lbEUR.Location = new System.Drawing.Point(601, 34);
            this.lbEUR.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbEUR.Name = "lbEUR";
            this.lbEUR.Size = new System.Drawing.Size(16, 13);
            this.lbEUR.TabIndex = 9;
            this.lbEUR.Text = "...";
            // 
            // lbUSD
            // 
            this.lbUSD.AutoSize = true;
            this.lbUSD.Location = new System.Drawing.Point(544, 34);
            this.lbUSD.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUSD.Name = "lbUSD";
            this.lbUSD.Size = new System.Drawing.Size(16, 13);
            this.lbUSD.TabIndex = 8;
            this.lbUSD.Text = "...";
            // 
            // lbDays
            // 
            this.lbDays.AutoSize = true;
            this.lbDays.Location = new System.Drawing.Point(485, 34);
            this.lbDays.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbDays.Name = "lbDays";
            this.lbDays.Size = new System.Drawing.Size(16, 13);
            this.lbDays.TabIndex = 7;
            this.lbDays.Text = "...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(441, 34);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Days";
            // 
            // chart1
            // 
            chartArea1.AxisX.Minimum = 0D;
            chartArea1.AxisX2.Minimum = 0D;
            chartArea1.AxisY.Minimum = 30D;
            chartArea1.AxisY2.Minimum = 30D;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(30, 118);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.BorderWidth = 3;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Red;
            series1.IsValueShownAsLabel = true;
            series1.Legend = "Legend1";
            series1.Name = "USD";
            series2.BorderWidth = 3;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Color = System.Drawing.Color.Lime;
            series2.IsValueShownAsLabel = true;
            series2.Legend = "Legend1";
            series2.Name = "EUR";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(949, 365);
            this.chart1.TabIndex = 3;
            this.chart1.Text = "chart1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 527);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.valueEUR)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.valueUSD)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btCalculate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown valueEUR;
        private System.Windows.Forms.NumericUpDown valueUSD;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbEUR;
        private System.Windows.Forms.Label lbUSD;
        private System.Windows.Forms.Label lbDays;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
    }
}

