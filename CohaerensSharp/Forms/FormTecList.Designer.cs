namespace CohaerensSharp.Forms
{
    partial class FormTecList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTecList));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.placeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new CohaerensSharp.DataSet();
            this.systemIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.systemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.receiverIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.receiverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.createdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourcesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.satelliteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.siteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.positionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tecListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tecListTableAdapter = new CohaerensSharp.DataSetTableAdapters.TecListTableAdapter();
            this.placeTableAdapter = new CohaerensSharp.DataSetTableAdapters.PlaceTableAdapter();
            this.systemTableAdapter = new CohaerensSharp.DataSetTableAdapters.SystemTableAdapter();
            this.receiverTableAdapter = new CohaerensSharp.DataSetTableAdapters.ReceiverTableAdapter();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.tsbContent = new System.Windows.Forms.ToolStripButton();
            this.tsbGraph = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiverBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tecListBindingSource)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 425);
            this.panel1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.placeIdDataGridViewTextBoxColumn,
            this.systemIdDataGridViewTextBoxColumn,
            this.receiverIdDataGridViewTextBoxColumn,
            this.createdDataGridViewTextBoxColumn,
            this.sourcesDataGridViewTextBoxColumn,
            this.satelliteDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn1,
            this.siteDataGridViewTextBoxColumn,
            this.positionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tecListBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 425);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // placeIdDataGridViewTextBoxColumn
            // 
            this.placeIdDataGridViewTextBoxColumn.DataPropertyName = "PlaceId";
            this.placeIdDataGridViewTextBoxColumn.DataSource = this.placeBindingSource;
            this.placeIdDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.placeIdDataGridViewTextBoxColumn.HeaderText = "Место";
            this.placeIdDataGridViewTextBoxColumn.Name = "placeIdDataGridViewTextBoxColumn";
            this.placeIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.placeIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.placeIdDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // placeBindingSource
            // 
            this.placeBindingSource.DataMember = "Place";
            this.placeBindingSource.DataSource = this.dataSet;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // systemIdDataGridViewTextBoxColumn
            // 
            this.systemIdDataGridViewTextBoxColumn.DataPropertyName = "SystemId";
            this.systemIdDataGridViewTextBoxColumn.DataSource = this.systemBindingSource;
            this.systemIdDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.systemIdDataGridViewTextBoxColumn.HeaderText = "Система связи";
            this.systemIdDataGridViewTextBoxColumn.Name = "systemIdDataGridViewTextBoxColumn";
            this.systemIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.systemIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.systemIdDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // systemBindingSource
            // 
            this.systemBindingSource.DataMember = "System";
            this.systemBindingSource.DataSource = this.dataSet;
            // 
            // receiverIdDataGridViewTextBoxColumn
            // 
            this.receiverIdDataGridViewTextBoxColumn.DataPropertyName = "ReceiverId";
            this.receiverIdDataGridViewTextBoxColumn.DataSource = this.receiverBindingSource;
            this.receiverIdDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.receiverIdDataGridViewTextBoxColumn.HeaderText = "Модель приемника";
            this.receiverIdDataGridViewTextBoxColumn.Name = "receiverIdDataGridViewTextBoxColumn";
            this.receiverIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.receiverIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.receiverIdDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // receiverBindingSource
            // 
            this.receiverBindingSource.DataMember = "Receiver";
            this.receiverBindingSource.DataSource = this.dataSet;
            // 
            // createdDataGridViewTextBoxColumn
            // 
            this.createdDataGridViewTextBoxColumn.DataPropertyName = "Created";
            this.createdDataGridViewTextBoxColumn.HeaderText = "Created";
            this.createdDataGridViewTextBoxColumn.Name = "createdDataGridViewTextBoxColumn";
            // 
            // sourcesDataGridViewTextBoxColumn
            // 
            this.sourcesDataGridViewTextBoxColumn.DataPropertyName = "Sources";
            this.sourcesDataGridViewTextBoxColumn.HeaderText = "Sources";
            this.sourcesDataGridViewTextBoxColumn.Name = "sourcesDataGridViewTextBoxColumn";
            // 
            // satelliteDataGridViewTextBoxColumn
            // 
            this.satelliteDataGridViewTextBoxColumn.DataPropertyName = "Satellite";
            this.satelliteDataGridViewTextBoxColumn.HeaderText = "Satellite";
            this.satelliteDataGridViewTextBoxColumn.Name = "satelliteDataGridViewTextBoxColumn";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Interval";
            this.dataGridViewTextBoxColumn1.HeaderText = "Interval";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // siteDataGridViewTextBoxColumn
            // 
            this.siteDataGridViewTextBoxColumn.DataPropertyName = "Site";
            this.siteDataGridViewTextBoxColumn.HeaderText = "Site";
            this.siteDataGridViewTextBoxColumn.Name = "siteDataGridViewTextBoxColumn";
            // 
            // positionDataGridViewTextBoxColumn
            // 
            this.positionDataGridViewTextBoxColumn.DataPropertyName = "Position";
            this.positionDataGridViewTextBoxColumn.HeaderText = "Position";
            this.positionDataGridViewTextBoxColumn.Name = "positionDataGridViewTextBoxColumn";
            // 
            // tecListBindingSource
            // 
            this.tecListBindingSource.DataMember = "TecList";
            this.tecListBindingSource.DataSource = this.dataSet;
            // 
            // tecListTableAdapter
            // 
            this.tecListTableAdapter.ClearBeforeFill = true;
            // 
            // placeTableAdapter
            // 
            this.placeTableAdapter.ClearBeforeFill = true;
            // 
            // systemTableAdapter
            // 
            this.systemTableAdapter.ClearBeforeFill = true;
            // 
            // receiverTableAdapter
            // 
            this.receiverTableAdapter.ClearBeforeFill = true;
            // 
            // tsbSave
            // 
            this.tsbSave.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbSave.Image = ((System.Drawing.Image)(resources.GetObject("tsbSave.Image")));
            this.tsbSave.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbSave.Name = "tsbSave";
            this.tsbSave.Size = new System.Drawing.Size(70, 22);
            this.tsbSave.Text = "Сохранить";
            this.tsbSave.Click += new System.EventHandler(this.tsbSave_Click);
            // 
            // tsbContent
            // 
            this.tsbContent.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbContent.Image = ((System.Drawing.Image)(resources.GetObject("tsbContent.Image")));
            this.tsbContent.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbContent.Name = "tsbContent";
            this.tsbContent.Size = new System.Drawing.Size(55, 22);
            this.tsbContent.Text = "Контент";
            this.tsbContent.Click += new System.EventHandler(this.tsbContent_Click);
            // 
            // tsbGraph
            // 
            this.tsbGraph.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbGraph.Image = ((System.Drawing.Image)(resources.GetObject("tsbGraph.Image")));
            this.tsbGraph.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGraph.Name = "tsbGraph";
            this.tsbGraph.Size = new System.Drawing.Size(52, 22);
            this.tsbGraph.Text = "График";
            this.tsbGraph.Click += new System.EventHandler(this.tsbGraph_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
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
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSave,
            this.tsbContent,
            this.tsbGraph,
            this.toolStripSeparator1,
            this.tsbClose});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(800, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "toolStrip1";
            // 
            // FormTecList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip);
            this.Name = "FormTecList";
            this.Text = "Список ПЭС";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FormTecList_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiverBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tecListBindingSource)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource tecListBindingSource;
        private DataSetTableAdapters.TecListTableAdapter tecListTableAdapter;
        private System.Windows.Forms.BindingSource placeBindingSource;
        private DataSetTableAdapters.PlaceTableAdapter placeTableAdapter;
        private System.Windows.Forms.BindingSource systemBindingSource;
        private DataSetTableAdapters.SystemTableAdapter systemTableAdapter;
        private System.Windows.Forms.BindingSource receiverBindingSource;
        private DataSetTableAdapters.ReceiverTableAdapter receiverTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn placeIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn systemIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn receiverIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn createdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sourcesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn satelliteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn siteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn positionDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripButton tsbContent;
        private System.Windows.Forms.ToolStripButton tsbGraph;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStrip toolStrip;
    }
}