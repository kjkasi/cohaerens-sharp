﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CohaerensSharp.Forms
{
    public partial class FormTecvChart : Form
    {
        public FormTecvChart()
        {
            InitializeComponent();
        }

        public FormTecvChart(int index)
        {
            InitializeComponent();
            chart1.DataSource = chartvTableAdapter.GetData(index);
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                chart1.SaveImage(saveFileDialog1.FileName, System.Windows.Forms.DataVisualization.Charting.ChartImageFormat.Png);
            }
        }
    }
}
