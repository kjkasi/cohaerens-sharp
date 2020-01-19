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
    public partial class FormTecvContent : Form
    {
        public FormTecvContent()
        {
            InitializeComponent();
        }

        public FormTecvContent(int index)
        {
            InitializeComponent();
        }

        private void FormTecvContent_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet.TecvContent". При необходимости она может быть перемещена или удалена.
            this.tecvContentTableAdapter.Fill(this.dataSet.TecvContent);

        }

        private void tsbClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
