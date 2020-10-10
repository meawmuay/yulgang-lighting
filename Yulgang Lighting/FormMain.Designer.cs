namespace Yulgang_Lighting
{
    partial class FormMain
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
            if( disposing && ( components != null ) )
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBoxLighting = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxSide = new System.Windows.Forms.ComboBox();
            this.buttonChangeLighting = new System.Windows.Forms.Button();
            this.buttonRollbackLighting = new System.Windows.Forms.Button();
            this.pictureBoxCover = new System.Windows.Forms.PictureBox();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBoxLogo = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonFolderBrowserDialog = new System.Windows.Forms.Button();
            this.textBoxYulgangPath = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).BeginInit();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.groupBox1.Controls.Add(this.comboBoxLighting);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBoxSide);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox1.Location = new System.Drawing.Point(242, 248);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(403, 95);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "เปลี่ยนแสงดี 1.5 เท่านั้น";
            // 
            // comboBoxLighting
            // 
            this.comboBoxLighting.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxLighting.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.comboBoxLighting.FormattingEnabled = true;
            this.comboBoxLighting.Location = new System.Drawing.Point(213, 56);
            this.comboBoxLighting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxLighting.Name = "comboBoxLighting";
            this.comboBoxLighting.Size = new System.Drawing.Size(177, 24);
            this.comboBoxLighting.TabIndex = 16;
            this.comboBoxLighting.SelectedIndexChanged += new System.EventHandler(this.comboBoxLighting_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label2.Location = new System.Drawing.Point(15, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 16);
            this.label2.TabIndex = 15;
            this.label2.Text = "ฝ่าย";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label1.Location = new System.Drawing.Point(15, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 16);
            this.label1.TabIndex = 12;
            this.label1.Text = "สีที่ต้องการ";
            // 
            // comboBoxSide
            // 
            this.comboBoxSide.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSide.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.comboBoxSide.FormattingEnabled = true;
            this.comboBoxSide.Items.AddRange(new object[] {
            "อธรรม",
            "ธรรมะ"});
            this.comboBoxSide.Location = new System.Drawing.Point(213, 23);
            this.comboBoxSide.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxSide.Name = "comboBoxSide";
            this.comboBoxSide.Size = new System.Drawing.Size(177, 24);
            this.comboBoxSide.TabIndex = 11;
            // 
            // buttonChangeLighting
            // 
            this.buttonChangeLighting.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.buttonChangeLighting.Location = new System.Drawing.Point(241, 352);
            this.buttonChangeLighting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonChangeLighting.Name = "buttonChangeLighting";
            this.buttonChangeLighting.Size = new System.Drawing.Size(132, 42);
            this.buttonChangeLighting.TabIndex = 12;
            this.buttonChangeLighting.Text = "เปลี่ยนแสงดี";
            this.buttonChangeLighting.UseVisualStyleBackColor = true;
            this.buttonChangeLighting.Click += new System.EventHandler(this.buttonChangeLighting_Click);
            // 
            // buttonRollbackLighting
            // 
            this.buttonRollbackLighting.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.buttonRollbackLighting.Location = new System.Drawing.Point(382, 353);
            this.buttonRollbackLighting.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonRollbackLighting.Name = "buttonRollbackLighting";
            this.buttonRollbackLighting.Size = new System.Drawing.Size(102, 41);
            this.buttonRollbackLighting.TabIndex = 13;
            this.buttonRollbackLighting.Text = "คืนค่าเดิม";
            this.buttonRollbackLighting.UseVisualStyleBackColor = true;
            this.buttonRollbackLighting.Click += new System.EventHandler(this.buttonRollbackLighting_Click);
            // 
            // pictureBoxCover
            // 
            this.pictureBoxCover.BackColor = System.Drawing.SystemColors.Control;
            this.pictureBoxCover.Location = new System.Drawing.Point(12, 35);
            this.pictureBoxCover.Name = "pictureBoxCover";
            this.pictureBoxCover.Size = new System.Drawing.Size(220, 359);
            this.pictureBoxCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxCover.TabIndex = 0;
            this.pictureBoxCover.TabStop = false;
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemUpdate,
            this.ToolStripMenuItemAbout});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(654, 24);
            this.menuStrip.TabIndex = 15;
            this.menuStrip.Text = "menuStrip1";
            // 
            // ToolStripMenuItemUpdate
            // 
            this.ToolStripMenuItemUpdate.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItemUpdate.Name = "ToolStripMenuItemUpdate";
            this.ToolStripMenuItemUpdate.Size = new System.Drawing.Size(56, 20);
            this.ToolStripMenuItemUpdate.Text = "อัปเดต";
            this.ToolStripMenuItemUpdate.Click += new System.EventHandler(this.ToolStripMenuItemUpdate_Click);
            // 
            // ToolStripMenuItemAbout
            // 
            this.ToolStripMenuItemAbout.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolStripMenuItemAbout.Name = "ToolStripMenuItemAbout";
            this.ToolStripMenuItemAbout.Size = new System.Drawing.Size(62, 20);
            this.ToolStripMenuItemAbout.Text = "เกี่ยวกับ";
            this.ToolStripMenuItemAbout.Click += new System.EventHandler(this.ToolStripMenuItemAbout_Click);
            // 
            // pictureBoxLogo
            // 
            this.pictureBoxLogo.Location = new System.Drawing.Point(274, 3);
            this.pictureBoxLogo.Name = "pictureBoxLogo";
            this.pictureBoxLogo.Size = new System.Drawing.Size(345, 132);
            this.pictureBoxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLogo.TabIndex = 16;
            this.pictureBoxLogo.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.buttonFolderBrowserDialog);
            this.groupBox2.Controls.Add(this.textBoxYulgangPath);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.groupBox2.Location = new System.Drawing.Point(242, 147);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(402, 95);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "เลือกโฟลเดอร์ตัวเกม";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.label3.Location = new System.Drawing.Point(15, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "ที่อยู่ตัวเกม Yulgang";
            // 
            // buttonFolderBrowserDialog
            // 
            this.buttonFolderBrowserDialog.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.buttonFolderBrowserDialog.Location = new System.Drawing.Point(280, 54);
            this.buttonFolderBrowserDialog.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonFolderBrowserDialog.Name = "buttonFolderBrowserDialog";
            this.buttonFolderBrowserDialog.Size = new System.Drawing.Size(110, 27);
            this.buttonFolderBrowserDialog.TabIndex = 10;
            this.buttonFolderBrowserDialog.Text = "เลือกตัวเกม";
            this.buttonFolderBrowserDialog.UseVisualStyleBackColor = true;
            this.buttonFolderBrowserDialog.Click += new System.EventHandler(this.buttonFolderBrowserDialog_Click);
            // 
            // textBoxYulgangPath
            // 
            this.textBoxYulgangPath.Enabled = false;
            this.textBoxYulgangPath.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.textBoxYulgangPath.Location = new System.Drawing.Point(15, 23);
            this.textBoxYulgangPath.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxYulgangPath.Name = "textBoxYulgangPath";
            this.textBoxYulgangPath.Size = new System.Drawing.Size(374, 23);
            this.textBoxYulgangPath.TabIndex = 9;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(654, 410);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBoxLogo);
            this.Controls.Add(this.pictureBoxCover);
            this.Controls.Add(this.buttonRollbackLighting);
            this.Controls.Add(this.buttonChangeLighting);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormMain";
            this.Text = "Yulgang Lighting เปลี่ยนแสงความดี";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCover)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBoxLighting;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxSide;
        private System.Windows.Forms.Button buttonChangeLighting;
        private System.Windows.Forms.Button buttonRollbackLighting;
        private System.Windows.Forms.PictureBox pictureBoxCover;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemUpdate;
        private System.Windows.Forms.PictureBox pictureBoxLogo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonFolderBrowserDialog;
        private System.Windows.Forms.TextBox textBoxYulgangPath;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemAbout;
    }
}

