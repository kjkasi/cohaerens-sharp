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
    public partial class FormPlace : Form
    {
        public FormPlace()
        {
            InitializeComponent();
        }

        private void FormPlace_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.Place". При необходимости она может быть перемещена или удалена.
            this.placeTableAdapter.Fill(this.dataSet.Place);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.Place". При необходимости она может быть перемещена или удалена.
            this.placeTableAdapter.Fill(this.dataSet.Place);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
