namespace CohaerensSharp
{
    partial class FormMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.miFile = new System.Windows.Forms.ToolStripMenuItem();
            this.miTecImport = new System.Windows.Forms.ToolStripMenuItem();
            this.miTecvImport = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.miOther = new System.Windows.Forms.ToolStripMenuItem();
            this.miPlace = new System.Windows.Forms.ToolStripMenuItem();
            this.miSystem = new System.Windows.Forms.ToolStripMenuItem();
            this.miReceiver = new System.Windows.Forms.ToolStripMenuItem();
            this.miTEC = new System.Windows.Forms.ToolStripMenuItem();
            this.miTecv = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.slCopy = new System.Windows.Forms.ToolStripStatusLabel();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.miAdvice = new System.Windows.Forms.ToolStripMenuItem();
            this.miWeather = new System.Windows.Forms.ToolStripMenuItem();
            this.dataSet = new CohaerensSharp.DataSet();
            this.tecListTableAdapter = new CohaerensSharp.DataSetTableAdapters.TecListTableAdapter();
            this.tecContentTableAdapter = new CohaerensSharp.DataSetTableAdapters.TecContentTableAdapter();
            this.tecvListTableAdapter = new CohaerensSharp.DataSetTableAdapters.TecvListTableAdapter();
            this.tecvContentTableAdapter = new CohaerensSharp.DataSetTableAdapters.TecvContentTableAdapter();
            this.menuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miFile,
            this.miOther,
            this.miAdvice});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // miFile
            // 
            this.miFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miTecImport,
            this.miTecvImport,
            this.toolStripSeparator1,
            this.miExit});
            this.miFile.Name = "miFile";
            this.miFile.Size = new System.Drawing.Size(48, 20);
            this.miFile.Text = "&Файл";
            // 
            // miTecImport
            // 
            this.miTecImport.Name = "miTecImport";
            this.miTecImport.Size = new System.Drawing.Size(201, 22);
            this.miTecImport.Text = "Импорт ПЭС";
            this.miTecImport.Click += new System.EventHandler(this.miTecImport_Click);
            // 
            // miTecvImport
            // 
            this.miTecvImport.Name = "miTecvImport";
            this.miTecvImport.Size = new System.Drawing.Size(201, 22);
            this.miTecvImport.Text = "Импорт вариации ПЭС";
            this.miTecvImport.Click += new System.EventHandler(this.miTecvImport_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(198, 6);
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(201, 22);
            this.miExit.Text = "&Выход";
            this.miExit.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // miOther
            // 
            this.miOther.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miPlace,
            this.miSystem,
            this.miReceiver,
            this.miTEC,
            this.miTecv,
            this.miWeather});
            this.miOther.Name = "miOther";
            this.miOther.Size = new System.Drawing.Size(94, 20);
            this.miOther.Text = "&Справочники";
            // 
            // miPlace
            // 
            this.miPlace.Name = "miPlace";
            this.miPlace.Size = new System.Drawing.Size(180, 22);
            this.miPlace.Text = "Места";
            this.miPlace.Click += new System.EventHandler(this.miPlace_Click);
            // 
            // miSystem
            // 
            this.miSystem.Name = "miSystem";
            this.miSystem.Size = new System.Drawing.Size(180, 22);
            this.miSystem.Text = "Системы связи";
            this.miSystem.Click += new System.EventHandler(this.miSystem_Click);
            // 
            // miReceiver
            // 
            this.miReceiver.Name = "miReceiver";
            this.miReceiver.Size = new System.Drawing.Size(180, 22);
            this.miReceiver.Text = "Приемники";
            this.miReceiver.Click += new System.EventHandler(this.miReceiver_Click);
            // 
            // miTEC
            // 
            this.miTEC.Name = "miTEC";
            this.miTEC.Size = new System.Drawing.Size(180, 22);
            this.miTEC.Text = "ПЭС";
            this.miTEC.Click += new System.EventHandler(this.miTEC_Click);
            // 
            // miTecv
            // 
            this.miTecv.Name = "miTecv";
            this.miTecv.Size = new System.Drawing.Size(180, 22);
            this.miTecv.Text = "Вариации ПЭС";
            this.miTecv.Click += new System.EventHandler(this.miTecv_Click);
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slCopy});
            this.statusStrip.Location = new System.Drawing.Point(0, 428);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(800, 22);
            this.statusStrip.TabIndex = 3;
            this.statusStrip.Text = "statusStrip1";
            // 
            // slCopy
            // 
            this.slCopy.Name = "slCopy";
            this.slCopy.Size = new System.Drawing.Size(236, 17);
            this.slCopy.Text = "https://github.com/kjkasi/cohaerens-sharp";
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog1";
            this.openFileDialog.Filter = "dat файлы|*.dat";
            // 
            // miAdvice
            // 
            this.miAdvice.Name = "miAdvice";
            this.miAdvice.Size = new System.Drawing.Size(100, 20);
            this.miAdvice.Text = "&Рекомендации";
            this.miAdvice.Click += new System.EventHandler(this.miAdvice_Click);
            // 
            // miWeather
            // 
            this.miWeather.Name = "miWeather";
            this.miWeather.Size = new System.Drawing.Size(180, 22);
            this.miWeather.Text = "Погодные условия";
            this.miWeather.Click += new System.EventHandler(this.miWeather_Click);
            // 
            // dataSet
            // 
            this.dataSet.DataSetName = "DataSet";
            this.dataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tecListTableAdapter
            // 
            this.tecListTableAdapter.ClearBeforeFill = true;
            // 
            // tecContentTableAdapter
            // 
            this.tecContentTableAdapter.ClearBeforeFill = true;
            // 
            // tecvListTableAdapter
            // 
            this.tecvListTableAdapter.ClearBeforeFill = true;
            // 
            // tecvContentTableAdapter
            // 
            this.tecvContentTableAdapter.ClearBeforeFill = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "FormMain";
            this.Text = "Программа анализа сбоев";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem miFile;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.ToolStripMenuItem miOther;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel slCopy;
        private System.Windows.Forms.ToolStripMenuItem miPlace;
        private System.Windows.Forms.ToolStripMenuItem miSystem;
        private System.Windows.Forms.ToolStripMenuItem miReceiver;
        private System.Windows.Forms.ToolStripMenuItem miTEC;
        private System.Windows.Forms.ToolStripMenuItem miTecImport;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private DataSet dataSet;
        private DataSetTableAdapters.TecListTableAdapter tecListTableAdapter;
        private DataSetTableAdapters.TecContentTableAdapter tecContentTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem miTecvImport;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem miTecv;
        private DataSetTableAdapters.TecvListTableAdapter tecvListTableAdapter;
        private DataSetTableAdapters.TecvContentTableAdapter tecvContentTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem miAdvice;
        private System.Windows.Forms.ToolStripMenuItem miWeather;
    }
}

