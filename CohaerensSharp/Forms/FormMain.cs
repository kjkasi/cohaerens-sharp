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

namespace CohaerensSharp
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void miPlace_Click(object sender, EventArgs e)
        {
            FormPlace form = new FormPlace();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void miSystem_Click(object sender, EventArgs e)
        {
            FormSystem form = new FormSystem();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void miReceiver_Click(object sender, EventArgs e)
        {
            FormReceiver form = new FormReceiver();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void miTEC_Click(object sender, EventArgs e)
        {
            FormTecList form = new FormTecList();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void miTecv_Click(object sender, EventArgs e)
        {
            FormTecvList form = new FormTecvList();
            form.MdiParent = this;
            form.WindowState = FormWindowState.Maximized;
            form.Show();
        }

        private void miTecImport_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string text = System.IO.File.ReadAllText(openFileDialog.FileName);
                string[] arr = text.Split('#');
                string created = arr[1].Replace("Created on", "").Trim();
                string sources = arr[2].Replace("Sources:", "").Trim();
                string satellite = arr[3].Replace("Satellite:", "").Trim();
                string interval = arr[4].Replace("Interval:", "").Trim();
                string site = arr[5].Replace("Site:", "").Trim();
                string position = arr[7].Replace("Position (X, Y, Z):", "").Trim();
                string[] data = arr[10].Split('\n');

                DataSet.TecListRow listRow;
                listRow = this.dataSet.TecList.NewTecListRow();
                listRow.Created = created;
                listRow.Sources = sources;
                listRow.Satellite = satellite;
                listRow.Interval = interval;
                listRow.Site = site;
                listRow.Position = position;

                this.dataSet.TecList.Rows.Add(listRow);
                this.tecListTableAdapter.Update(this.dataSet);


                for (int i = 1; i < data.Length - 1; i++)
                {
                    string tsn = data[i].Substring(0, 10).Trim();
                    string hour = data[i].Substring(12, 14).Trim();
                    string el = data[i].Substring(27, 10).Trim();
                    string az = data[i].Substring(38, 11).Trim();
                    string l1l2 = data[i].Substring(51, 21).Trim();
                    string p1p2 = data[i].Substring(73, 10).Trim();
                    string validity = data[i].Substring(83, 7).Trim();

                    DataSet.TecContentRow contentRow;
                    contentRow = this.dataSet.TecContent.NewTecContentRow();
                    contentRow.Id = listRow.Id;
                    contentRow.tsn = tsn;
                    contentRow.hour = hour;
                    contentRow.el = el;
                    contentRow.az = az;
                    contentRow.l1l2 = l1l2;
                    contentRow.p1p2 = p1p2;
                    contentRow.validity = validity;
                    this.dataSet.TecContent.Rows.Add(contentRow);
                }

                this.tecContentTableAdapter.Update(this.dataSet);
                MessageBox.Show("Файл " + openFileDialog.FileName + " импортирован!");
            }
        }

        private void miTecvImport_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string text = System.IO.File.ReadAllText(openFileDialog.FileName);
                string[] data = text.Split('\n');

                int height = int.Parse(data[0].Replace("- height of F2-layer maximum", "").Trim());
                int low = int.Parse(data[1].Replace("- low filtering period, minutes", "").Trim());
                int high = int.Parse(data[2].Replace("- high filtering period, minutes", "").Trim());

                DataSet.TecvListRow tecvList;
                tecvList = this.dataSet.TecvList.NewTecvListRow();
                tecvList.Name = openFileDialog.SafeFileName;
                tecvList.Height = height;
                tecvList.Low = low;
                tecvList.High = high;

                this.dataSet.TecvList.Rows.Add(tecvList);
                this.tecvListTableAdapter.Update(this.dataSet);

                for (int i = 8; i < data.Length - 1; i++)
                {
                    double time_ut = double.Parse(data[i].Replace(".", ",").Substring(0, 9).Trim());
                    double tec_filt_aver = double.Parse(data[i].Replace(".", ",").Substring(10, 8).Trim());
                    double rms = double.Parse(data[i].Replace(".", ",").Substring(18, 8).Trim());
                    double Xaver = double.Parse(data[i].Replace(".", ",").Substring(26, 9).Trim());
                    double Yaver = double.Parse(data[i].Replace(".", ",").Substring(35, 9).Trim());
                    double Hmax = double.Parse(data[i].Replace(".", ",").Substring(44, 9).Trim());
                    double DHmax = double.Parse(data[i].Replace(".", ",").Substring(53, 9).Trim());
                    double I0 = double.Parse(data[i].Replace(".", ",").Substring(62, 8).Trim());
                    double DI0 = double.Parse(data[i].Replace(".", ",").Substring(70, 8).Trim());
                    int N_of_Sats = int.Parse(data[i].Substring(78, 3).Trim());

                    DataSet.TecvContentRow tecvContentRow;
                    tecvContentRow = this.dataSet.TecvContent.NewTecvContentRow();
                    tecvContentRow.Id = tecvList.Id;
                    tecvContentRow.time_ut = time_ut;
                    tecvContentRow.tec_filt_aver = tec_filt_aver;
                    tecvContentRow.rms = rms;
                    tecvContentRow.Xaver = Xaver;
                    tecvContentRow.Yaver = Yaver;
                    tecvContentRow.Hmax = Hmax;
                    tecvContentRow.DHmax = DHmax;
                    tecvContentRow.I0 = I0;
                    tecvContentRow.DI0 = DI0;
                    tecvContentRow.N_of_Sats = N_of_Sats;

                    this.dataSet.TecvContent.Rows.Add(tecvContentRow);
                    this.tecvContentTableAdapter.Update(this.dataSet);

                }

                MessageBox.Show("Файл " + openFileDialog.FileName + " импортирован!");
            }
        }

        
    }
}
