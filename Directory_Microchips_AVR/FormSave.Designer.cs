
namespace Directory_Microchips_AVR
{
    partial class FormSave
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
            this.buttonSaveYes = new System.Windows.Forms.Button();
            this.buttonSaveNo = new System.Windows.Forms.Button();
            this.logoM = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSaveYes
            // 
            this.buttonSaveYes.BackColor = System.Drawing.Color.Teal;
            this.buttonSaveYes.DialogResult = System.Windows.Forms.DialogResult.Yes;
            this.buttonSaveYes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSaveYes.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold);
            this.buttonSaveYes.ForeColor = System.Drawing.Color.White;
            this.buttonSaveYes.Location = new System.Drawing.Point(34, 103);
            this.buttonSaveYes.Name = "buttonSaveYes";
            this.buttonSaveYes.Size = new System.Drawing.Size(106, 50);
            this.buttonSaveYes.TabIndex = 72;
            this.buttonSaveYes.Text = "Yes";
            this.buttonSaveYes.UseVisualStyleBackColor = false;
            // 
            // buttonSaveNo
            // 
            this.buttonSaveNo.BackColor = System.Drawing.Color.Teal;
            this.buttonSaveNo.DialogResult = System.Windows.Forms.DialogResult.No;
            this.buttonSaveNo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSaveNo.Font = new System.Drawing.Font("Microsoft Tai Le", 15.75F, System.Drawing.FontStyle.Bold);
            this.buttonSaveNo.ForeColor = System.Drawing.Color.White;
            this.buttonSaveNo.Location = new System.Drawing.Point(195, 103);
            this.buttonSaveNo.Name = "buttonSaveNo";
            this.buttonSaveNo.Size = new System.Drawing.Size(106, 50);
            this.buttonSaveNo.TabIndex = 73;
            this.buttonSaveNo.Text = "No";
            this.buttonSaveNo.UseVisualStyleBackColor = false;
            // 
            // logoM
            // 
            this.logoM.AutoSize = true;
            this.logoM.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.logoM.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoM.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.logoM.ForeColor = System.Drawing.Color.White;
            this.logoM.Location = new System.Drawing.Point(55, 47);
            this.logoM.Name = "logoM";
            this.logoM.Size = new System.Drawing.Size(227, 28);
            this.logoM.TabIndex = 74;
            this.logoM.Text = "Save changes in DB?";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonSaveYes);
            this.groupBox1.Controls.Add(this.logoM);
            this.groupBox1.Controls.Add(this.buttonSaveNo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(326, 176);
            this.groupBox1.TabIndex = 75;
            this.groupBox1.TabStop = false;
            // 
            // FormSave
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ClientSize = new System.Drawing.Size(350, 200);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormSave";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormSave";
            this.Load += new System.EventHandler(this.FormSave_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonSaveYes;
        private System.Windows.Forms.Button buttonSaveNo;
        private System.Windows.Forms.Label logoM;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}