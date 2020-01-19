using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using CohaerensSharp.Forms;

namespace CohaerensSharp.Forms
{
    public partial class FormTecList : Form
    {
        public FormTecList()
        {
            InitializeComponent();
        }

        private void FormTecList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.TecList". При необходимости она может быть перемещена или удалена.
            this.tecListTableAdapter.Fill(this.dataSet.TecList);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.TecList". При необходимости она может быть перемещена или удалена.
            this.tecListTableAdapter.Fill(this.dataSet.TecList);

        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbContent_Click(object sender, EventArgs e)
        {
            //int index = (int)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
            int index = (int)dataGridView1.SelectedCells[0].Value;
            FormTecContent form = new FormTecContent(index);
            form.MdiParent = this.MdiParent;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void tsbGraph_Click(object sender, EventArgs e)
        {
            int index = (int)dataGridView1.SelectedCells[0].Value;
            FormChart form = new FormChart(index);
            form.MdiParent = this.MdiParent;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }
    }
}
