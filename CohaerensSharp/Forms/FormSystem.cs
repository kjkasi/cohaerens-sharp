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
    public partial class FormSystem : Form
    {
        public FormSystem()
        {
            InitializeComponent();
        }

        private void FormSystem_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.System". При необходимости она может быть перемещена или удалена.
            this.systemTableAdapter.Fill(this.dataSet.System);

        }
    }
}
