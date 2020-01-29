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
    public partial class FormWeather : Form
    {
        public FormWeather()
        {
            InitializeComponent();
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            this.weatherTableAdapter.Update(this.dataSet);
        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormWeather_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.Weather". При необходимости она может быть перемещена или удалена.
            this.weatherTableAdapter.Fill(this.dataSet.Weather);

        }
    }
}
