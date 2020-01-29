namespace CohaerensSharp.Forms
{
    partial class FormTecvContent
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTecvContent));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tecvContentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new CohaerensSharp.DataSet();
            this.tecvContentTableAdapter = new CohaerensSharp.DataSetTableAdapters.TecvContentTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeutDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tecfiltaverDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rmsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xaverDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yaverDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hmaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dHmaxDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.i0DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dI0DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nofSatsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tecvContentBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // tsbClose
            // 
            this.tsbClose.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbClose.Image = ((System.Drawing.Image)(resources.GetObject("tsbClose.Image")));
            this.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(57, 22);
            this.tsbClose.Text = "Закрыть";
            this.tsbClose.Click += new System.EventHandler(this.tsbClose_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 425);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.timeutDataGridViewTextBoxColumn,
            this.tecfiltaverDataGridViewTextBoxColumn,
            this.rmsDataGridViewTextBoxColumn,
            this.xaverDataGridViewTextBoxColumn,
            this.yaverDataGridViewTextBoxColumn,
            this.hmaxDataGridViewTextBoxColumn,
            this.dHmaxDataGridViewTextBoxColumn,
            this.i0DataGridViewTextBoxColumn,
            this.dI0DataGridViewTextBoxColumn,
            this.nofSatsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tecvContentBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(800, 425);
            this.dataGridView1.TabIndex = 0;
            // 
            // tecvContentBindingSource
            // 
            this.tecvContentBindingSource.DataMember = "TecvContent";
            this.tecvContentBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tecvContentTableAdapter
            // 
            this.tecvContentTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // timeutDataGridViewTextBoxColumn
            // 
            this.timeutDataGridViewTextBoxColumn.DataPropertyName = "time_ut";
            this.timeutDataGridViewTextBoxColumn.HeaderText = "time_ut";
            this.timeutDataGridViewTextBoxColumn.Name = "timeutDataGridViewTextBoxColumn";
            this.timeutDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tecfiltaverDataGridViewTextBoxColumn
            // 
            this.tecfiltaverDataGridViewTextBoxColumn.DataPropertyName = "tec_filt_aver";
            this.tecfiltaverDataGridViewTextBoxColumn.HeaderText = "tec_filt_aver";
            this.tecfiltaverDataGridViewTextBoxColumn.Name = "tecfiltaverDataGridViewTextBoxColumn";
            this.tecfiltaverDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rmsDataGridViewTextBoxColumn
            // 
            this.rmsDataGridViewTextBoxColumn.DataPropertyName = "rms";
            this.rmsDataGridViewTextBoxColumn.HeaderText = "rms";
            this.rmsDataGridViewTextBoxColumn.Name = "rmsDataGridViewTextBoxColumn";
            this.rmsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // xaverDataGridViewTextBoxColumn
            // 
            this.xaverDataGridViewTextBoxColumn.DataPropertyName = "Xaver";
            this.xaverDataGridViewTextBoxColumn.HeaderText = "Xaver";
            this.xaverDataGridViewTextBoxColumn.Name = "xaverDataGridViewTextBoxColumn";
            this.xaverDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // yaverDataGridViewTextBoxColumn
            // 
            this.yaverDataGridViewTextBoxColumn.DataPropertyName = "Yaver";
            this.yaverDataGridViewTextBoxColumn.HeaderText = "Yaver";
            this.yaverDataGridViewTextBoxColumn.Name = "yaverDataGridViewTextBoxColumn";
            this.yaverDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hmaxDataGridViewTextBoxColumn
            // 
            this.hmaxDataGridViewTextBoxColumn.DataPropertyName = "Hmax";
            this.hmaxDataGridViewTextBoxColumn.HeaderText = "Hmax";
            this.hmaxDataGridViewTextBoxColumn.Name = "hmaxDataGridViewTextBoxColumn";
            this.hmaxDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dHmaxDataGridViewTextBoxColumn
            // 
            this.dHmaxDataGridViewTextBoxColumn.DataPropertyName = "DHmax";
            this.dHmaxDataGridViewTextBoxColumn.HeaderText = "DHmax";
            this.dHmaxDataGridViewTextBoxColumn.Name = "dHmaxDataGridViewTextBoxColumn";
            this.dHmaxDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // i0DataGridViewTextBoxColumn
            // 
            this.i0DataGridViewTextBoxColumn.DataPropertyName = "I0";
            this.i0DataGridViewTextBoxColumn.HeaderText = "I0";
            this.i0DataGridViewTextBoxColumn.Name = "i0DataGridViewTextBoxColumn";
            this.i0DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dI0DataGridViewTextBoxColumn
            // 
            this.dI0DataGridViewTextBoxColumn.DataPropertyName = "DI0";
            this.dI0DataGridViewTextBoxColumn.HeaderText = "DI0";
            this.dI0DataGridViewTextBoxColumn.Name = "dI0DataGridViewTextBoxColumn";
            this.dI0DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nofSatsDataGridViewTextBoxColumn
            // 
            this.nofSatsDataGridViewTextBoxColumn.DataPropertyName = "N_of_Sats";
            this.nofSatsDataGridViewTextBoxColumn.HeaderText = "N_of_Sats";
            this.nofSatsDataGridViewTextBoxColumn.Name = "nofSatsDataGridViewTextBoxColumn";
            this.nofSatsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormTecvContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormTecvContent";
            this.Text = "Контент вариации ПЭС";
            this.Load += new System.EventHandler(this.FormTecvContent_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tecvContentBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource tecvContentBindingSource;
        private DataSetTableAdapters.TecvContentTableAdapter tecvContentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeutDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tecfiltaverDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rmsDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn xaverDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yaverDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hmaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dHmaxDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn i0DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dI0DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nofSatsDataGridViewTextBoxColumn;
    }
}