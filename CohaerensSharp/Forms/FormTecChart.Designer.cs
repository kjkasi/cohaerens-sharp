namespace CohaerensSharp.Forms
{
    partial class FormTecChart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTecChart));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chartBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new CohaerensSharp.DataSet();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.chartTableAdapter = new CohaerensSharp.DataSetTableAdapters.ChartTableAdapter();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSave,
            this.toolStripSeparator1,
            this.tsbClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbSave
            // 
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(113, 22);
            this.tsbSave.Text = "Сохранить график";
            this.tsbSave.ToolTipText = "Сохранить график";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // tsbClose
            // 
            this.tsbClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbClose.Image = ((System.Drawing.Image)(resources.GetObject("tsbClose.Image")));
            this.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(57, 22);
            this.tsbClose.Text = "Закрыть";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 425);
            this.panel1.TabIndex = 2;
            // 
            // chart1
            // 
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisX.Title = "Время наблюдения, ч";
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.Silver;
            chartArea1.AxisY.Title = "Полное электронное содержание,  TECU";
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.DataSource = this.chartBindingSource;
            this.chart1.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(0, 0);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Color = System.Drawing.Color.Black;
            series1.IsXValueIndexed = true;
            series1.Legend = "Legend1";
            series1.Name = "YOSH";
            series1.XValueMember = "hour";
            series1.YValueMembers = "l1l2";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series2.Enabled = false;
            series2.IsXValueIndexed = true;
            series2.Legend = "Legend1";
            series2.Name = "Среднее значение";
            series2.SmartLabelStyle.AllowOutsidePlotArea = System.Windows.Forms.DataVisualization.Charting.LabelOutsidePlotAreaStyle.No;
            series2.SmartLabelStyle.CalloutLineAnchorCapStyle = System.Windows.Forms.DataVisualization.Charting.LineAnchorCapStyle.None;
            series2.SmartLabelStyle.CalloutStyle = System.Windows.Forms.DataVisualization.Charting.LabelCalloutStyle.None;
            series2.SmartLabelStyle.IsMarkerOverlappingAllowed = true;
            series2.SmartLabelStyle.MaxMovingDistance = 5D;
            series2.XValueMember = "tsn";
            series2.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
            series2.YValueMembers = "l1l2_avg";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(800, 425);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            title1.Name = "Tec";
            title1.Text = "Полное электронное содержание";
            title1.Visible = false;
            this.chart1.Titles.Add(title1);
            // 
            // chartBindingSource
            // 
            this.chartBindingSource.DataMember = "Chart";
            this.chartBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "png";
            // 
            // chartTableAdapter
            // 
            this.chartTableAdapter.ClearBeforeFill = true;
            // 
            // FormTecChart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormTecChart";
            this.Text = "График ПЭС";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chartBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.BindingSource chartBindingSource;
        private DataSet dataSet;
        private DataSetTableAdapters.ChartTableAdapter chartTableAdapter;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}