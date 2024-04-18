namespace exercicio_windows_forms
{
    partial class Form8
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
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint1 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 10D);
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint2 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2D, 10D);
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint3 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(5D, 10D);
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint4 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(10D, 9D);
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint5 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(10D, 8D);
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint6 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 10D);
            System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint7 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2D, 10D);
            System.Windows.Forms.DataVisualization.Charting.Series series9 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint8 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(5D, 10D);
            System.Windows.Forms.DataVisualization.Charting.Series series10 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint9 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(10D, 9D);
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint10 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(10D, 8D);
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form8));
            this.chart3 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart4 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            this.SuspendLayout();
            // 
            // chart3
            // 
            this.chart3.BackColor = System.Drawing.Color.LightGreen;
            this.chart3.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            this.chart3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chart3.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Weave;
            this.chart3.BackSecondaryColor = System.Drawing.Color.LimeGreen;
            this.chart3.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.BackColor = System.Drawing.Color.PaleGreen;
            chartArea1.Name = "ChartArea1";
            chartArea1.ShadowColor = System.Drawing.Color.Black;
            this.chart3.ChartAreas.Add(chartArea1);
            this.chart3.Location = new System.Drawing.Point(674, 95);
            this.chart3.Name = "chart3";
            this.chart3.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "ChartArea1";
            series1.IsXValueIndexed = true;
            series1.Name = "Series1";
            series1.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            this.chart3.Series.Add(series1);
            this.chart3.Size = new System.Drawing.Size(521, 299);
            this.chart3.TabIndex = 5;
            this.chart3.Text = "chart3";
            // 
            // chart4
            // 
            this.chart4.BackColor = System.Drawing.Color.LightGreen;
            this.chart4.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            this.chart4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chart4.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Weave;
            this.chart4.BackSecondaryColor = System.Drawing.Color.LimeGreen;
            this.chart4.BorderlineColor = System.Drawing.Color.Black;
            chartArea2.BackColor = System.Drawing.Color.PaleGreen;
            chartArea2.Name = "ChartArea1";
            chartArea2.ShadowColor = System.Drawing.Color.Black;
            this.chart4.ChartAreas.Add(chartArea2);
            legend1.Name = "Legend1";
            this.chart4.Legends.Add(legend1);
            this.chart4.Location = new System.Drawing.Point(107, 431);
            this.chart4.Name = "chart4";
            this.chart4.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series2.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series2.ChartArea = "ChartArea1";
            series2.LabelBorderColor = System.Drawing.Color.White;
            series2.Legend = "Legend1";
            series2.MarkerBorderColor = System.Drawing.Color.White;
            series2.Name = "Baco Exu do Blues";
            series2.Points.Add(dataPoint1);
            series2.ShadowColor = System.Drawing.Color.Red;
            series2.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series2.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series3.ChartArea = "ChartArea1";
            series3.Legend = "Legend1";
            series3.Name = "Ana Castela";
            series3.Points.Add(dataPoint2);
            series3.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Luisa Sonsa";
            series4.Points.Add(dataPoint3);
            series4.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "AC/DC";
            series5.Points.Add(dataPoint4);
            series5.ShadowColor = System.Drawing.Color.Red;
            series6.ChartArea = "ChartArea1";
            series6.Legend = "Legend1";
            series6.Name = "Jorge Ben Jor";
            series6.Points.Add(dataPoint5);
            series6.ShadowColor = System.Drawing.Color.Red;
            this.chart4.Series.Add(series2);
            this.chart4.Series.Add(series3);
            this.chart4.Series.Add(series4);
            this.chart4.Series.Add(series5);
            this.chart4.Series.Add(series6);
            this.chart4.Size = new System.Drawing.Size(521, 238);
            this.chart4.TabIndex = 6;
            this.chart4.Text = "chart4";
            title1.Name = "Title1";
            title1.Text = "Artistas Mais Escutados";
            this.chart4.Titles.Add(title1);
            // 
            // chart2
            // 
            this.chart2.BackColor = System.Drawing.Color.LightGreen;
            this.chart2.BackGradientStyle = System.Windows.Forms.DataVisualization.Charting.GradientStyle.LeftRight;
            this.chart2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.chart2.BackHatchStyle = System.Windows.Forms.DataVisualization.Charting.ChartHatchStyle.Weave;
            this.chart2.BackSecondaryColor = System.Drawing.Color.LimeGreen;
            this.chart2.BorderlineColor = System.Drawing.Color.Black;
            chartArea3.BackColor = System.Drawing.Color.PaleGreen;
            chartArea3.Name = "ChartArea1";
            chartArea3.ShadowColor = System.Drawing.Color.Black;
            this.chart2.ChartAreas.Add(chartArea3);
            legend2.BackColor = System.Drawing.Color.Honeydew;
            legend2.Name = "Legend1";
            this.chart2.Legends.Add(legend2);
            this.chart2.Location = new System.Drawing.Point(107, 95);
            this.chart2.Name = "chart2";
            this.chart2.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series7.BorderDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dot;
            series7.ChartArea = "ChartArea1";
            series7.LabelBorderColor = System.Drawing.Color.White;
            series7.Legend = "Legend1";
            series7.MarkerBorderColor = System.Drawing.Color.White;
            series7.Name = "Baco Exu do Blues";
            dataPoint6.LabelBorderColor = System.Drawing.Color.White;
            series7.Points.Add(dataPoint6);
            series7.ShadowColor = System.Drawing.Color.Red;
            series7.XAxisType = System.Windows.Forms.DataVisualization.Charting.AxisType.Secondary;
            series7.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            series8.ChartArea = "ChartArea1";
            series8.Legend = "Legend1";
            series8.Name = "Ana Castela";
            series8.Points.Add(dataPoint7);
            series8.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series9.ChartArea = "ChartArea1";
            series9.Legend = "Legend1";
            series9.Name = "Luisa Sonsa";
            series9.Points.Add(dataPoint8);
            series9.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
            series10.ChartArea = "ChartArea1";
            series10.Legend = "Legend1";
            series10.Name = "AC/DC";
            series10.Points.Add(dataPoint9);
            series10.ShadowColor = System.Drawing.Color.Red;
            series11.ChartArea = "ChartArea1";
            series11.Legend = "Legend1";
            series11.Name = "Jorge Ben Jor";
            series11.Points.Add(dataPoint10);
            series11.ShadowColor = System.Drawing.Color.Red;
            this.chart2.Series.Add(series7);
            this.chart2.Series.Add(series8);
            this.chart2.Series.Add(series9);
            this.chart2.Series.Add(series10);
            this.chart2.Series.Add(series11);
            this.chart2.Size = new System.Drawing.Size(521, 299);
            this.chart2.TabIndex = 7;
            this.chart2.Text = "chart2";
            title2.BackColor = System.Drawing.Color.MediumSeaGreen;
            title2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            title2.Name = "Title1";
            title2.Text = "Artistas Mais Escutados";
            this.chart2.Titles.Add(title2);
            // 
            // Form8
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1350, 693);
            this.Controls.Add(this.chart2);
            this.Controls.Add(this.chart4);
            this.Controls.Add(this.chart3);
            this.Name = "Form8";
            this.Text = "Form8";
            ((System.ComponentModel.ISupportInitialize)(this.chart3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart3;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
    }
}