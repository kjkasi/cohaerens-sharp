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
    public partial class FormTecContent : Form
    {
        public FormTecContent()
        {
            InitializeComponent();
        }

        public FormTecContent(int index)
        {
            InitializeComponent();
        }

        private void FormTecContent_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.TecContent". При необходимости она может быть перемещена или удалена.
            this.tecContentTableAdapter.Fill(this.dataSet.TecContent);
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
