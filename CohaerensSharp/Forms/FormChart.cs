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
    public partial class FormChart : Form
    {
        public FormChart()
        {
            InitializeComponent();
        }

        public FormChart(int index)
        {
            InitializeComponent();
            chart1.DataSource = chartTableAdapter.GetData(index);
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
