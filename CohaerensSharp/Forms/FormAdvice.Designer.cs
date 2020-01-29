namespace CohaerensSharp.Forms
{
    partial class FormAdvice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAdvice));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.tsbSave = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsbClose = new System.Windows.Forms.ToolStripButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tecListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSet = new CohaerensSharp.DataSet();
            this.tecvListBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adviceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adviceTableAdapter = new CohaerensSharp.DataSetTableAdapters.AdviceTableAdapter();
            this.tecListTableAdapter = new CohaerensSharp.DataSetTableAdapters.TecListTableAdapter();
            this.tecvListTableAdapter = new CohaerensSharp.DataSetTableAdapters.TecvListTableAdapter();
            this.weatherBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.weatherTableAdapter = new CohaerensSharp.DataSetTableAdapters.WeatherTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tecIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tecvIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.WeatherId = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tecListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tecvListBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adviceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbSave,
            this.toolStripSeparator2,
            this.tsbClose});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
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
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 25);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(800, 425);
            this.dataGridView1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.tecIdDataGridViewTextBoxColumn,
            this.tecvIdDataGridViewTextBoxColumn,
            this.WeatherId,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.adviceBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 25);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(800, 425);
            this.dataGridView2.TabIndex = 2;
            // 
            // tecListBindingSource
            // 
            this.tecListBindingSource.DataMember = "TecList";
            this.tecListBindingSource.DataSource = this.dataSet;
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
            // adviceBindingSource
            // 
            this.adviceBindingSource.DataMember = "Advice";
            this.adviceBindingSource.DataSource = this.dataSet;
            // 
            // adviceTableAdapter
            // 
            this.adviceTableAdapter.ClearBeforeFill = true;
            // 
            // tecListTableAdapter
            // 
            this.tecListTableAdapter.ClearBeforeFill = true;
            // 
            // tecvListTableAdapter
            // 
            this.tecvListTableAdapter.ClearBeforeFill = true;
            // 
            // weatherBindingSource
            // 
            this.weatherBindingSource.DataMember = "Weather";
            this.weatherBindingSource.DataSource = this.dataSet;
            // 
            // weatherTableAdapter
            // 
            this.weatherTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Номер";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tecIdDataGridViewTextBoxColumn
            // 
            this.tecIdDataGridViewTextBoxColumn.DataPropertyName = "TecId";
            this.tecIdDataGridViewTextBoxColumn.DataSource = this.tecListBindingSource;
            this.tecIdDataGridViewTextBoxColumn.DisplayMember = "Sources";
            this.tecIdDataGridViewTextBoxColumn.HeaderText = "ПЭС";
            this.tecIdDataGridViewTextBoxColumn.Name = "tecIdDataGridViewTextBoxColumn";
            this.tecIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tecIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tecIdDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // tecvIdDataGridViewTextBoxColumn
            // 
            this.tecvIdDataGridViewTextBoxColumn.DataPropertyName = "TecvId";
            this.tecvIdDataGridViewTextBoxColumn.DataSource = this.tecvListBindingSource;
            this.tecvIdDataGridViewTextBoxColumn.DisplayMember = "Name";
            this.tecvIdDataGridViewTextBoxColumn.HeaderText = "Вариация ПЭС";
            this.tecvIdDataGridViewTextBoxColumn.Name = "tecvIdDataGridViewTextBoxColumn";
            this.tecvIdDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.tecvIdDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.tecvIdDataGridViewTextBoxColumn.ValueMember = "Id";
            // 
            // WeatherId
            // 
            this.WeatherId.DataPropertyName = "WeatherId";
            this.WeatherId.DataSource = this.weatherBindingSource;
            this.WeatherId.DisplayMember = "Id";
            this.WeatherId.HeaderText = "Погодные условия";
            this.WeatherId.Name = "WeatherId";
            this.WeatherId.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.WeatherId.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.WeatherId.ValueMember = "Id";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Рекомендация";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // FormAdvice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FormAdvice";
            this.Text = "Рекомендации";
            this.Load += new System.EventHandler(this.FormAdvice_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tecListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tecvListBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adviceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.weatherBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton tsbSave;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton tsbClose;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private DataSet dataSet;
        private System.Windows.Forms.BindingSource adviceBindingSource;
        private DataSetTableAdapters.AdviceTableAdapter adviceTableAdapter;
        private System.Windows.Forms.BindingSource tecListBindingSource;
        private DataSetTableAdapters.TecListTableAdapter tecListTableAdapter;
        private System.Windows.Forms.BindingSource tecvListBindingSource;
        private DataSetTableAdapters.TecvListTableAdapter tecvListTableAdapter;
        private System.Windows.Forms.BindingSource weatherBindingSource;
        private DataSetTableAdapters.WeatherTableAdapter weatherTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn tecIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn tecvIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn WeatherId;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
    }
}