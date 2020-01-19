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
    public partial class FormTecvList : Form
    {
        public FormTecvList()
        {
            InitializeComponent();
        }

        private void FormTecvList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.TecvList". При необходимости она может быть перемещена или удалена.
            this.tecvListTableAdapter.Fill(this.dataSet.TecvList);

        }

        private void tsbContent_Click(object sender, EventArgs e)
        {
            int index = (int)dataGridView1.SelectedCells[0].Value;
            FormTecvContent form = new FormTecvContent(index);
            form.MdiParent = this.MdiParent;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void tsbChart_Click(object sender, EventArgs e)
        {
            int index = (int)dataGridView1.SelectedCells[0].Value;
            FormTecvChart form = new FormTecvChart(index);
            form.MdiParent = this.MdiParent;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
