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
    public partial class FormReceiver : Form
    {
        public FormReceiver()
        {
            InitializeComponent();
        }

        private void FormReceiver_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.Receiver". При необходимости она может быть перемещена или удалена.
            this.receiverTableAdapter.Fill(this.dataSet.Receiver);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.Receiver". При необходимости она может быть перемещена или удалена.
            this.receiverTableAdapter.Fill(this.dataSet.Receiver);

        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tsbSave_Click(object sender, EventArgs e)
        {
            this.receiverTableAdapter.Update(this.dataSet);
        }
    }
}
