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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.Receiver". При необходимости она может быть перемещена или удалена.
            this.receiverTableAdapter.Fill(this.dataSet.Receiver);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.System". При необходимости она может быть перемещена или удалена.
            this.systemTableAdapter.Fill(this.dataSet.System);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.Place". При необходимости она может быть перемещена или удалена.
            this.placeTableAdapter.Fill(this.dataSet.Place);
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
            //int index = (int)dataGridView1.SelectedCells[0].Value;
            FormTecContent form = new FormTecContent(getIndex());
            form.MdiParent = this.MdiParent;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void tsbGraph_Click(object sender, EventArgs e)
        {
            //int index = (int)dataGridView1.SelectedCells[0].Value;
            //int index = int.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
            FormTecChart form = new FormTecChart(getIndex());
            form.MdiParent = this.MdiParent;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            this.tecListTableAdapter.Update(this.dataSet);
        }

        private int getIndex()
        {
            int index = int.Parse(dataGridView1.Rows[dataGridView1.CurrentCell.RowIndex].Cells[0].Value.ToString());
            return index;
        }
    }
}
