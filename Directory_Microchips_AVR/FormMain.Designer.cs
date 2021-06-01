
namespace Directory_Microchips_AVR
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panelMain = new System.Windows.Forms.Panel();
            this.logoPanel = new System.Windows.Forms.Panel();
            this.LogoIT = new System.Windows.Forms.Label();
            this.logoM = new System.Windows.Forms.Label();
            this.panelDataTable = new System.Windows.Forms.Panel();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.panelCatalog = new System.Windows.Forms.Panel();
            this.buttonProjects = new System.Windows.Forms.Button();
            this.buttonTimers = new System.Windows.Forms.Button();
            this.buttonInterfaces = new System.Windows.Forms.Button();
            this.buttonDataMemories = new System.Windows.Forms.Button();
            this.buttonCorpuses = new System.Windows.Forms.Button();
            this.duttonMicrochipsAVR = new System.Windows.Forms.Button();
            this.directoru_microchip_avr_DataSet = new Directory_Microchips_AVR.directoru_microchip_avr_DataSet();
            this.corpusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.corpusTableAdapter = new Directory_Microchips_AVR.directoru_microchip_avr_DataSetTableAdapters.corpusTableAdapter();
            this.microchipavrBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.microchip_avrTableAdapter = new Directory_Microchips_AVR.directoru_microchip_avr_DataSetTableAdapters.microchip_avrTableAdapter();
            this.datamemoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.data_memoryTableAdapter = new Directory_Microchips_AVR.directoru_microchip_avr_DataSetTableAdapters.data_memoryTableAdapter();
            this.interfacesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.interfacesTableAdapter = new Directory_Microchips_AVR.directoru_microchip_avr_DataSetTableAdapters.interfacesTableAdapter();
            this.timerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.timerTableAdapter = new Directory_Microchips_AVR.directoru_microchip_avr_DataSetTableAdapters.timerTableAdapter();
            this.mySqlDataAdapter1 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.mySqlDataAdapter2 = new MySql.Data.MySqlClient.MySqlDataAdapter();
            this.buttonTableCatalog = new System.Windows.Forms.Button();
            this.panelExit = new System.Windows.Forms.Panel();
            this.panelMain.SuspendLayout();
            this.logoPanel.SuspendLayout();
            this.panelDataTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.panelCatalog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.directoru_microchip_avr_DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.corpusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.microchipavrBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datamemoryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.interfacesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timerBindingSource)).BeginInit();
            this.panelExit.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMain
            // 
            this.panelMain.Controls.Add(this.logoPanel);
            this.panelMain.Controls.Add(this.panelDataTable);
            this.panelMain.Controls.Add(this.panelCatalog);
            this.panelMain.Controls.Add(this.panelExit);
            this.panelMain.Cursor = System.Windows.Forms.Cursors.Default;
            this.panelMain.Location = new System.Drawing.Point(0, 0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1320, 1200);
            this.panelMain.TabIndex = 0;
            // 
            // logoPanel
            // 
            this.logoPanel.Controls.Add(this.LogoIT);
            this.logoPanel.Controls.Add(this.logoM);
            this.logoPanel.Location = new System.Drawing.Point(0, 0);
            this.logoPanel.Name = "logoPanel";
            this.logoPanel.Size = new System.Drawing.Size(1320, 70);
            this.logoPanel.TabIndex = 67;
            // 
            // LogoIT
            // 
            this.LogoIT.AutoSize = true;
            this.LogoIT.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LogoIT.Font = new System.Drawing.Font("Microsoft YaHei", 25F, System.Drawing.FontStyle.Bold);
            this.LogoIT.ForeColor = System.Drawing.Color.Teal;
            this.LogoIT.Location = new System.Drawing.Point(200, 9);
            this.LogoIT.Name = "LogoIT";
            this.LogoIT.Size = new System.Drawing.Size(115, 56);
            this.LogoIT.TabIndex = 2;
            this.LogoIT.Text = "AVR";
            // 
            // logoM
            // 
            this.logoM.AutoSize = true;
            this.logoM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoM.Font = new System.Drawing.Font("Microsoft YaHei", 25F, System.Drawing.FontStyle.Bold);
            this.logoM.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.logoM.Location = new System.Drawing.Point(3, 9);
            this.logoM.Name = "logoM";
            this.logoM.Size = new System.Drawing.Size(257, 56);
            this.logoM.TabIndex = 3;
            this.logoM.Text = "Microchips";
            // 
            // panelDataTable
            // 
            this.panelDataTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panelDataTable.Controls.Add(this.dataGridView);
            this.panelDataTable.Location = new System.Drawing.Point(300, 163);
            this.panelDataTable.Name = "panelDataTable";
            this.panelDataTable.Size = new System.Drawing.Size(1007, 871);
            this.panelDataTable.TabIndex = 66;
            this.panelDataTable.Visible = false;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToOrderColumns = true;
            this.dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.dataGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeight = 29;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.Location = new System.Drawing.Point(0, 100);
            this.dataGridView.Name = "dataGridView";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView.RowHeadersWidth = 51;
            this.dataGridView.Size = new System.Drawing.Size(1030, 611);
            this.dataGridView.StandardTab = true;
            this.dataGridView.TabIndex = 72;
            // 
            // panelCatalog
            // 
            this.panelCatalog.Controls.Add(this.buttonProjects);
            this.panelCatalog.Controls.Add(this.buttonTimers);
            this.panelCatalog.Controls.Add(this.buttonInterfaces);
            this.panelCatalog.Controls.Add(this.buttonDataMemories);
            this.panelCatalog.Controls.Add(this.buttonCorpuses);
            this.panelCatalog.Controls.Add(this.duttonMicrochipsAVR);
            this.panelCatalog.Location = new System.Drawing.Point(0, 150);
            this.panelCatalog.Name = "panelCatalog";
            this.panelCatalog.Size = new System.Drawing.Size(294, 490);
            this.panelCatalog.TabIndex = 61;
            // 
            // buttonProjects
            // 
            this.buttonProjects.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonProjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonProjects.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold);
            this.buttonProjects.ForeColor = System.Drawing.Color.White;
            this.buttonProjects.Location = new System.Drawing.Point(-3, 403);
            this.buttonProjects.Name = "buttonProjects";
            this.buttonProjects.Size = new System.Drawing.Size(297, 80);
            this.buttonProjects.TabIndex = 70;
            this.buttonProjects.Text = "Projects";
            this.buttonProjects.UseVisualStyleBackColor = false;
            // 
            // buttonTimers
            // 
            this.buttonTimers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonTimers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTimers.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold);
            this.buttonTimers.ForeColor = System.Drawing.Color.White;
            this.buttonTimers.Location = new System.Drawing.Point(-3, 323);
            this.buttonTimers.Name = "buttonTimers";
            this.buttonTimers.Size = new System.Drawing.Size(297, 80);
            this.buttonTimers.TabIndex = 69;
            this.buttonTimers.Text = "Timers";
            this.buttonTimers.UseVisualStyleBackColor = false;
            // 
            // buttonInterfaces
            // 
            this.buttonInterfaces.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonInterfaces.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInterfaces.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold);
            this.buttonInterfaces.ForeColor = System.Drawing.Color.White;
            this.buttonInterfaces.Location = new System.Drawing.Point(-3, 243);
            this.buttonInterfaces.Name = "buttonInterfaces";
            this.buttonInterfaces.Size = new System.Drawing.Size(297, 80);
            this.buttonInterfaces.TabIndex = 68;
            this.buttonInterfaces.Text = "Interfaces";
            this.buttonInterfaces.UseVisualStyleBackColor = false;
            // 
            // buttonDataMemories
            // 
            this.buttonDataMemories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonDataMemories.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDataMemories.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold);
            this.buttonDataMemories.ForeColor = System.Drawing.Color.White;
            this.buttonDataMemories.Location = new System.Drawing.Point(-3, 163);
            this.buttonDataMemories.Name = "buttonDataMemories";
            this.buttonDataMemories.Size = new System.Drawing.Size(297, 80);
            this.buttonDataMemories.TabIndex = 67;
            this.buttonDataMemories.Text = "Data memories";
            this.buttonDataMemories.UseVisualStyleBackColor = false;
            // 
            // buttonCorpuses
            // 
            this.buttonCorpuses.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.buttonCorpuses.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCorpuses.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold);
            this.buttonCorpuses.ForeColor = System.Drawing.Color.White;
            this.buttonCorpuses.Location = new System.Drawing.Point(-3, 83);
            this.buttonCorpuses.Name = "buttonCorpuses";
            this.buttonCorpuses.Size = new System.Drawing.Size(297, 80);
            this.buttonCorpuses.TabIndex = 66;
            this.buttonCorpuses.Text = "Corpuses";
            this.buttonCorpuses.UseVisualStyleBackColor = false;
            // 
            // duttonMicrochipsAVR
            // 
            this.duttonMicrochipsAVR.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.duttonMicrochipsAVR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.duttonMicrochipsAVR.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold);
            this.duttonMicrochipsAVR.ForeColor = System.Drawing.Color.White;
            this.duttonMicrochipsAVR.Location = new System.Drawing.Point(-3, 3);
            this.duttonMicrochipsAVR.Name = "duttonMicrochipsAVR";
            this.duttonMicrochipsAVR.Size = new System.Drawing.Size(297, 80);
            this.duttonMicrochipsAVR.TabIndex = 65;
            this.duttonMicrochipsAVR.Text = "Microcontrollers  AVR";
            this.duttonMicrochipsAVR.UseVisualStyleBackColor = false;
            // 
            // directoru_microchip_avr_DataSet
            // 
            this.directoru_microchip_avr_DataSet.DataSetName = "directoru_microcontroller_avr_DataSet";
            this.directoru_microchip_avr_DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // corpusBindingSource
            // 
            this.corpusBindingSource.DataMember = "corpus";
            this.corpusBindingSource.DataSource = this.directoru_microchip_avr_DataSet;
            // 
            // corpusTableAdapter
            // 
            this.corpusTableAdapter.ClearBeforeFill = true;
            // 
            // microchipavrBindingSource
            // 
            this.microchipavrBindingSource.DataMember = "microchip_avr";
            this.microchipavrBindingSource.DataSource = this.directoru_microchip_avr_DataSet;
            // 
            // microchip_avrTableAdapter
            // 
            this.microchip_avrTableAdapter.ClearBeforeFill = true;
            // 
            // datamemoryBindingSource
            // 
            this.datamemoryBindingSource.DataMember = "data_memory";
            this.datamemoryBindingSource.DataSource = this.directoru_microchip_avr_DataSet;
            // 
            // data_memoryTableAdapter
            // 
            this.data_memoryTableAdapter.ClearBeforeFill = true;
            // 
            // interfacesBindingSource
            // 
            this.interfacesBindingSource.DataMember = "interfaces";
            this.interfacesBindingSource.DataSource = this.directoru_microchip_avr_DataSet;
            // 
            // interfacesTableAdapter
            // 
            this.interfacesTableAdapter.ClearBeforeFill = true;
            // 
            // timerBindingSource
            // 
            this.timerBindingSource.DataMember = "timer";
            this.timerBindingSource.DataSource = this.directoru_microchip_avr_DataSet;
            // 
            // timerTableAdapter
            // 
            this.timerTableAdapter.ClearBeforeFill = true;
            // 
            // mySqlDataAdapter1
            // 
            this.mySqlDataAdapter1.DeleteCommand = null;
            this.mySqlDataAdapter1.InsertCommand = null;
            this.mySqlDataAdapter1.SelectCommand = null;
            this.mySqlDataAdapter1.UpdateCommand = null;
            // 
            // mySqlDataAdapter2
            // 
            this.mySqlDataAdapter2.DeleteCommand = null;
            this.mySqlDataAdapter2.InsertCommand = null;
            this.mySqlDataAdapter2.SelectCommand = null;
            this.mySqlDataAdapter2.UpdateCommand = null;
            // 
            // buttonTableCatalog
            // 
            this.buttonTableCatalog.BackColor = System.Drawing.Color.Teal;
            this.buttonTableCatalog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTableCatalog.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold);
            this.buttonTableCatalog.ForeColor = System.Drawing.Color.White;
            this.buttonTableCatalog.Image = global::Directory_Microchips_AVR.Properties.Resources.Ресурс_1;
            this.buttonTableCatalog.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonTableCatalog.Location = new System.Drawing.Point(-3, -3);
            this.buttonTableCatalog.Name = "buttonTableCatalog";
            this.buttonTableCatalog.Size = new System.Drawing.Size(297, 86);
            this.buttonTableCatalog.TabIndex = 71;
            this.buttonTableCatalog.Text = "Table catalog";
            this.buttonTableCatalog.UseVisualStyleBackColor = false;
            this.buttonTableCatalog.Click += new System.EventHandler(this.buttonTableCatalog_Click);
            // 
            // panelExit
            // 
            this.panelExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.panelExit.Controls.Add(this.buttonTableCatalog);
            this.panelExit.Location = new System.Drawing.Point(0, 70);
            this.panelExit.Name = "panelExit";
            this.panelExit.Size = new System.Drawing.Size(1320, 80);
            this.panelExit.TabIndex = 20;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1340, 1034);
            this.Controls.Add(this.panelMain);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft YaHei", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "Redactor BD Directory:\"Microchip AVR\"";
            this.panelMain.ResumeLayout(false);
            this.logoPanel.ResumeLayout(false);
            this.logoPanel.PerformLayout();
            this.panelDataTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.panelCatalog.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.directoru_microchip_avr_DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.corpusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.microchipavrBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datamemoryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.interfacesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timerBindingSource)).EndInit();
            this.panelExit.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Panel panelCatalog;
        private System.Windows.Forms.Panel panelDataTable;
        private System.Windows.Forms.Panel logoPanel;
        private System.Windows.Forms.Label LogoIT;
        private System.Windows.Forms.Label logoM;
        private directoru_microchip_avr_DataSet directoru_microchip_avr_DataSet;
        private System.Windows.Forms.BindingSource corpusBindingSource;
        private directoru_microchip_avr_DataSetTableAdapters.corpusTableAdapter corpusTableAdapter;
        private System.Windows.Forms.BindingSource microchipavrBindingSource;
        private directoru_microchip_avr_DataSetTableAdapters.microchip_avrTableAdapter microchip_avrTableAdapter;
        private System.Windows.Forms.Button duttonMicrochipsAVR;
        private System.Windows.Forms.Button buttonCorpuses;
        private System.Windows.Forms.Button buttonDataMemories;
        private System.Windows.Forms.Button buttonProjects;
        private System.Windows.Forms.Button buttonTimers;
        private System.Windows.Forms.Button buttonInterfaces;
        private System.Windows.Forms.BindingSource datamemoryBindingSource;
        private directoru_microchip_avr_DataSetTableAdapters.data_memoryTableAdapter data_memoryTableAdapter;
        private System.Windows.Forms.BindingSource interfacesBindingSource;
        private directoru_microchip_avr_DataSetTableAdapters.interfacesTableAdapter interfacesTableAdapter;
        private System.Windows.Forms.BindingSource timerBindingSource;
        private directoru_microchip_avr_DataSetTableAdapters.timerTableAdapter timerTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter1;
        private MySql.Data.MySqlClient.MySqlDataAdapter mySqlDataAdapter2;
        private System.Windows.Forms.Panel panelExit;
        private System.Windows.Forms.Button buttonTableCatalog;
    }
}

