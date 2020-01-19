namespace CohaerensSharp.Forms
{
    partial class FormTecContent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTecContent));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet = new CohaerensSharp.DataSet();
            this.tecContentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tecContentTableAdapter = new CohaerensSharp.DataSetTableAdapters.TecContentTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tsnDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hourDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.elDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.azDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l1l2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.p1p2DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.validityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tecContentBindingSource)).BeginInit();
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
            this.tsbClose.Image = ((System.Drawing.Image)(resources.GetObject("tsbClose.Image")));
            this.tsbClose.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbClose.Name = "tsbClose";
            this.tsbClose.Size = new System.Drawing.Size(73, 22);
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
            this.tsnDataGridViewTextBoxColumn,
            this.hourDataGridViewTextBoxColumn,
            this.elDataGridViewTextBoxColumn,
            this.azDataGridViewTextBoxColumn,
            this.l1l2DataGridViewTextBoxColumn,
            this.p1p2DataGridViewTextBoxColumn,
            this.validityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tecContentBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(800, 425);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tecContentBindingSource
            // 
            this.tecContentBindingSource.DataMember = "TecContent";
            this.tecContentBindingSource.DataSource = this.dataSet;
            // 
            // tecContentTableAdapter
            // 
            this.tecContentTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tsnDataGridViewTextBoxColumn
            // 
            this.tsnDataGridViewTextBoxColumn.DataPropertyName = "tsn";
            this.tsnDataGridViewTextBoxColumn.HeaderText = "tsn";
            this.tsnDataGridViewTextBoxColumn.Name = "tsnDataGridViewTextBoxColumn";
            this.tsnDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // hourDataGridViewTextBoxColumn
            // 
            this.hourDataGridViewTextBoxColumn.DataPropertyName = "hour";
            this.hourDataGridViewTextBoxColumn.HeaderText = "hour";
            this.hourDataGridViewTextBoxColumn.Name = "hourDataGridViewTextBoxColumn";
            this.hourDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // elDataGridViewTextBoxColumn
            // 
            this.elDataGridViewTextBoxColumn.DataPropertyName = "el";
            this.elDataGridViewTextBoxColumn.HeaderText = "el";
            this.elDataGridViewTextBoxColumn.Name = "elDataGridViewTextBoxColumn";
            this.elDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // azDataGridViewTextBoxColumn
            // 
            this.azDataGridViewTextBoxColumn.DataPropertyName = "az";
            this.azDataGridViewTextBoxColumn.HeaderText = "az";
            this.azDataGridViewTextBoxColumn.Name = "azDataGridViewTextBoxColumn";
            this.azDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // l1l2DataGridViewTextBoxColumn
            // 
            this.l1l2DataGridViewTextBoxColumn.DataPropertyName = "l1l2";
            this.l1l2DataGridViewTextBoxColumn.HeaderText = "l1l2";
            this.l1l2DataGridViewTextBoxColumn.Name = "l1l2DataGridViewTextBoxColumn";
            this.l1l2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // p1p2DataGridViewTextBoxColumn
            // 
            this.p1p2DataGridViewTextBoxColumn.DataPropertyName = "p1p2";
            this.p1p2DataGridViewTextBoxColumn.HeaderText = "p1p2";
            this.p1p2DataGridViewTextBoxColumn.Name = "p1p2DataGridViewTextBoxColumn";
            this.p1p2DataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // validityDataGridViewTextBoxColumn
            // 
            this.validityDataGridViewTextBoxColumn.DataPropertyName = "validity";
            this.validityDataGridViewTextBoxColumn.HeaderText = "validity";
            this.validityDataGridViewTextBoxColumn.Name = "validityDataGridViewTextBoxColumn";
            this.validityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // FormTecContent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormTecContent";
            this.Text = "FormTecContent";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormTecContent_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tecContentBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource tecContentBindingSource;
        private DataSetTableAdapters.TecContentTableAdapter tecContentTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tsnDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn hourDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn elDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn azDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn l1l2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn p1p2DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn validityDataGridViewTextBoxColumn;
    }
}