using System;
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
    public partial class FormAdvice : Form
    {
        public FormAdvice()
        {
            InitializeComponent();
        }

        private void FormAdvice_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.Weather". При необходимости она может быть перемещена или удалена.
            this.weatherTableAdapter.Fill(this.dataSet.Weather);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.TecvList". При необходимости она может быть перемещена или удалена.
            this.tecvListTableAdapter.Fill(this.dataSet.TecvList);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.TecList". При необходимости она может быть перемещена или удалена.
            this.tecListTableAdapter.Fill(this.dataSet.TecList);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.Advice". При необходимости она может быть перемещена или удалена.
            this.adviceTableAdapter.Fill(this.dataSet.Advice);

        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            this.adviceTableAdapter.Update(this.dataSet);
        }
    }
}
