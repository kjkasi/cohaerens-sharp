﻿namespace CohaerensSharp.Forms
{
    partial class FormTecvList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTecvList));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbContent = new System.Windows.Forms.ToolStripButton();
            this.tsbChart = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSet = new CohaerensSharp.DataSet();
            this.tecvListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tecvListTableAdapter = new CohaerensSharp.DataSetTableAdapters.TecvListTableAdapter();
            this.placeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.placeTableAdapter = new CohaerensSharp.DataSetTableAdapters.PlaceTableAdapter();
            this.systemBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.systemTableAdapter = new CohaerensSharp.DataSetTableAdapters.SystemTableAdapter();
            this.receiverBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.receiverTableAdapter = new CohaerensSharp.DataSetTableAdapters.ReceiverTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.placeIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.systemIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.receiverIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lowDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.highDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tecvListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiverBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSave,
            this.tsbContent,
            this.tsbChart,
            this.toolStripSeparator1,
            this.tsbClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
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
            // tsbChart
            // 
            this.tsbChart.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbChart.Image = ((System.Drawing.Image)(resources.GetObject("tsbChart.Image")));
            this.tsbChart.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbChart.Name = "tsbChart";
            this.tsbChart.Size = new System.Drawing.Size(52, 22);
            this.tsbChart.Text = "График";
            this.tsbChart.Click += new System.EventHandler(this.tsbChart_Click);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 425);
            this.panel1.TabIndex = 1;
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
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.placeIdDataGridViewTextBoxColumn,
            this.systemIdDataGridViewTextBoxColumn,
            this.receiverIdDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.heightDataGridViewTextBoxColumn,
            this.lowDataGridViewTextBoxColumn,
            this.highDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tecvListBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 425);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tecvListBindingSource
            // 
            this.tecvListBindingSource.DataMember = "TecvList";
            this.tecvListBindingSource.DataSource = this.dataSet;
            // 
            // tecvListTableAdapter
            // 
            this.tecvListTableAdapter.ClearBeforeFill = true;
            // 
            // placeBindingSource
            // 
            this.placeBindingSource.DataMember = "Place";
            this.placeBindingSource.DataSource = this.dataSet;
            // 
            // placeTableAdapter
            // 
            this.placeTableAdapter.ClearBeforeFill = true;
            // 
            // systemBindingSource
            // 
            this.systemBindingSource.DataMember = "System";
            this.systemBindingSource.DataSource = this.dataSet;
            // 
            // systemTableAdapter
            // 
            this.systemTableAdapter.ClearBeforeFill = true;
            // 
            // receiverBindingSource
            // 
            this.receiverBindingSource.DataMember = "Receiver";
            this.receiverBindingSource.DataSource = this.dataSet;
            // 
            // receiverTableAdapter
            // 
            this.receiverTableAdapter.ClearBeforeFill = true;
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
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // heightDataGridViewTextBoxColumn
            // 
            this.heightDataGridViewTextBoxColumn.DataPropertyName = "Height";
            this.heightDataGridViewTextBoxColumn.HeaderText = "Height";
            this.heightDataGridViewTextBoxColumn.Name = "heightDataGridViewTextBoxColumn";
            // 
            // lowDataGridViewTextBoxColumn
            // 
            this.lowDataGridViewTextBoxColumn.DataPropertyName = "Low";
            this.lowDataGridViewTextBoxColumn.HeaderText = "Low";
            this.lowDataGridViewTextBoxColumn.Name = "lowDataGridViewTextBoxColumn";
            // 
            // highDataGridViewTextBoxColumn
            // 
            this.highDataGridViewTextBoxColumn.DataPropertyName = "High";
            this.highDataGridViewTextBoxColumn.HeaderText = "High";
            this.highDataGridViewTextBoxColumn.Name = "highDataGridViewTextBoxColumn";
            // 
            // FormTecvList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormTecvList";
            this.Text = "Список вариации ПЭС";
            this.Load += new System.EventHandler(this.FormTecvList_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tecvListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.placeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.systemBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiverBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbContent;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripButton tsbChart;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource tecvListBindingSource;
        private DataSetTableAdapters.TecvListTableAdapter tecvListTableAdapter;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lowDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn highDataGridViewTextBoxColumn;
    }
}