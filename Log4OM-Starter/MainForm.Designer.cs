namespace Log4OM_Starter
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.versionLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.log4OM_Path = new System.Windows.Forms.TextBox();
            this.BackupPath = new System.Windows.Forms.TextBox();
            this.Log4OM_PathButton = new System.Windows.Forms.Button();
            this.Backup_PathButton = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.OnThisPc = new System.Windows.Forms.Button();
            this.OnAnotherPC = new System.Windows.Forms.Button();
            this.checkSqlLitePath = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.sqlLitePathButton = new System.Windows.Forms.Button();
            this.sqlLitePath = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.saveConfigCheck = new System.Windows.Forms.CheckBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkForUpdatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Log4OM-Starter";
            // 
            // versionLabel
            // 
            this.versionLabel.AutoSize = true;
            this.versionLabel.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.versionLabel.Location = new System.Drawing.Point(189, 41);
            this.versionLabel.Name = "versionLabel";
            this.versionLabel.Size = new System.Drawing.Size(67, 13);
            this.versionLabel.TabIndex = 1;
            this.versionLabel.Text = "ver. 0.0.0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(8, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(541, 26);
            this.label3.TabIndex = 2;
            this.label3.Text = "WARNING: This tool works exclusively with the Log4OM Portable version. Please ens" +
    "ure you \r\nare using the correct version before proceeding.\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Log4OM Path:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Backup Path:";
            // 
            // log4OM_Path
            // 
            this.log4OM_Path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.log4OM_Path.Location = new System.Drawing.Point(109, 35);
            this.log4OM_Path.Name = "log4OM_Path";
            this.log4OM_Path.Size = new System.Drawing.Size(408, 20);
            this.log4OM_Path.TabIndex = 5;
            this.log4OM_Path.Leave += new System.EventHandler(this.log4OM_Path_Leave);
            // 
            // BackupPath
            // 
            this.BackupPath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.BackupPath.Location = new System.Drawing.Point(109, 74);
            this.BackupPath.Name = "BackupPath";
            this.BackupPath.Size = new System.Drawing.Size(408, 20);
            this.BackupPath.TabIndex = 6;
            this.BackupPath.Leave += new System.EventHandler(this.BackupPath_Leave);
            // 
            // Log4OM_PathButton
            // 
            this.Log4OM_PathButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Log4OM_PathButton.Font = new System.Drawing.Font("Microsoft Yi Baiti", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Log4OM_PathButton.Location = new System.Drawing.Point(523, 35);
            this.Log4OM_PathButton.Name = "Log4OM_PathButton";
            this.Log4OM_PathButton.Size = new System.Drawing.Size(24, 20);
            this.Log4OM_PathButton.TabIndex = 7;
            this.Log4OM_PathButton.Text = "...";
            this.Log4OM_PathButton.UseVisualStyleBackColor = true;
            this.Log4OM_PathButton.Click += new System.EventHandler(this.Log4OM_PathButton_Click);
            // 
            // Backup_PathButton
            // 
            this.Backup_PathButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Backup_PathButton.Font = new System.Drawing.Font("Microsoft Yi Baiti", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backup_PathButton.Location = new System.Drawing.Point(523, 74);
            this.Backup_PathButton.Name = "Backup_PathButton";
            this.Backup_PathButton.Size = new System.Drawing.Size(24, 20);
            this.Backup_PathButton.TabIndex = 8;
            this.Backup_PathButton.Text = "...";
            this.Backup_PathButton.UseVisualStyleBackColor = true;
            this.Backup_PathButton.Click += new System.EventHandler(this.Backup_PathButton_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(172, 184);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(217, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Where did you last use Log4OM?";
            // 
            // OnThisPc
            // 
            this.OnThisPc.BackColor = System.Drawing.Color.Bisque;
            this.OnThisPc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OnThisPc.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnThisPc.Location = new System.Drawing.Point(6, 210);
            this.OnThisPc.Name = "OnThisPc";
            this.OnThisPc.Size = new System.Drawing.Size(236, 62);
            this.OnThisPc.TabIndex = 10;
            this.OnThisPc.Text = "On this Computer";
            this.OnThisPc.UseVisualStyleBackColor = false;
            this.OnThisPc.Click += new System.EventHandler(this.OnThisPc_Click);
            // 
            // OnAnotherPC
            // 
            this.OnAnotherPC.BackColor = System.Drawing.Color.MistyRose;
            this.OnAnotherPC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OnAnotherPC.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OnAnotherPC.Location = new System.Drawing.Point(319, 210);
            this.OnAnotherPC.Name = "OnAnotherPC";
            this.OnAnotherPC.Size = new System.Drawing.Size(236, 62);
            this.OnAnotherPC.TabIndex = 11;
            this.OnAnotherPC.Text = "On another Computer \r\n(or is it the first run on this one)\r\n(or i don\'t remember)" +
    "";
            this.OnAnotherPC.UseVisualStyleBackColor = false;
            this.OnAnotherPC.Click += new System.EventHandler(this.OnAnotherPC_Click);
            // 
            // checkSqlLitePath
            // 
            this.checkSqlLitePath.AutoSize = true;
            this.checkSqlLitePath.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkSqlLitePath.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkSqlLitePath.Location = new System.Drawing.Point(16, 113);
            this.checkSqlLitePath.Name = "checkSqlLitePath";
            this.checkSqlLitePath.Size = new System.Drawing.Size(365, 17);
            this.checkSqlLitePath.TabIndex = 12;
            this.checkSqlLitePath.Text = "The SqlLite database Path is the same on all my computers";
            this.checkSqlLitePath.UseVisualStyleBackColor = true;
            this.checkSqlLitePath.CheckedChanged += new System.EventHandler(this.checkSqlLitePath_CheckedChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 146);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "SqlLite Path:";
            // 
            // sqlLitePathButton
            // 
            this.sqlLitePathButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sqlLitePathButton.Font = new System.Drawing.Font("Microsoft Yi Baiti", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sqlLitePathButton.Location = new System.Drawing.Point(523, 142);
            this.sqlLitePathButton.Name = "sqlLitePathButton";
            this.sqlLitePathButton.Size = new System.Drawing.Size(24, 20);
            this.sqlLitePathButton.TabIndex = 15;
            this.sqlLitePathButton.Text = "...";
            this.sqlLitePathButton.UseVisualStyleBackColor = true;
            this.sqlLitePathButton.Click += new System.EventHandler(this.sqlLitePathButton_Click);
            // 
            // sqlLitePath
            // 
            this.sqlLitePath.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.sqlLitePath.Location = new System.Drawing.Point(109, 142);
            this.sqlLitePath.Name = "sqlLitePath";
            this.sqlLitePath.Size = new System.Drawing.Size(408, 20);
            this.sqlLitePath.TabIndex = 14;
            this.sqlLitePath.Leave += new System.EventHandler(this.sqlLitePath_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(7, 5);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(271, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "WARNING: When i should use this little tool?";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(2, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(523, 26);
            this.label9.TabIndex = 17;
            this.label9.Text = "You should only use it if you are running Log4OM-Portable on multiple PCs and syn" +
    "cing \r\nthe backup folder with backup software such as OneDrive, Dropbox, or Prot" +
    "onDrive.\r\n";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(5, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(523, 26);
            this.label10.TabIndex = 18;
            this.label10.Text = "WARNING: Do not run multiple instances of Log4OM-Portable simultaneously on diffe" +
    "rent \r\nPCs, as this may cause synchronization issues.\r\n";
            // 
            // saveConfigCheck
            // 
            this.saveConfigCheck.AutoSize = true;
            this.saveConfigCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveConfigCheck.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveConfigCheck.Location = new System.Drawing.Point(454, 37);
            this.saveConfigCheck.Name = "saveConfigCheck";
            this.saveConfigCheck.Size = new System.Drawing.Size(89, 17);
            this.saveConfigCheck.TabIndex = 19;
            this.saveConfigCheck.Text = "Save Config";
            this.saveConfigCheck.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 498);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.statusStrip1.Size = new System.Drawing.Size(579, 22);
            this.statusStrip1.TabIndex = 20;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatusLabel1.IsLink = true;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(93, 17);
            this.toolStripStatusLabel1.Text = "Made by IU5TRX";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(6, 112);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(561, 55);
            this.groupBox1.TabIndex = 21;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Location = new System.Drawing.Point(6, 169);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(561, 42);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Location = new System.Drawing.Point(5, 66);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(562, 46);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.sqlLitePathButton);
            this.groupBox4.Controls.Add(this.sqlLitePath);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.checkSqlLitePath);
            this.groupBox4.Controls.Add(this.OnAnotherPC);
            this.groupBox4.Controls.Add(this.OnThisPc);
            this.groupBox4.Controls.Add(this.label6);
            this.groupBox4.Controls.Add(this.Backup_PathButton);
            this.groupBox4.Controls.Add(this.Log4OM_PathButton);
            this.groupBox4.Controls.Add(this.BackupPath);
            this.groupBox4.Controls.Add(this.log4OM_Path);
            this.groupBox4.Controls.Add(this.label5);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Location = new System.Drawing.Point(6, 210);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(561, 285);
            this.groupBox4.TabIndex = 24;
            this.groupBox4.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.Size = new System.Drawing.Size(579, 24);
            this.menuStrip1.TabIndex = 25;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkForUpdatesToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // checkForUpdatesToolStripMenuItem
            // 
            this.checkForUpdatesToolStripMenuItem.Name = "checkForUpdatesToolStripMenuItem";
            this.checkForUpdatesToolStripMenuItem.Size = new System.Drawing.Size(171, 22);
            this.checkForUpdatesToolStripMenuItem.Text = "Check for Updates";
            this.checkForUpdatesToolStripMenuItem.Click += new System.EventHandler(this.checkForUpdatesToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Log4OM_Starter.Properties.Resources.favicon;
            this.pictureBox1.Location = new System.Drawing.Point(6, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 40);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(579, 520);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.saveConfigCheck);
            this.Controls.Add(this.versionLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Log4OM-Starter";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label versionLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox log4OM_Path;
        private System.Windows.Forms.TextBox BackupPath;
        private System.Windows.Forms.Button Log4OM_PathButton;
        private System.Windows.Forms.Button Backup_PathButton;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button OnThisPc;
        private System.Windows.Forms.Button OnAnotherPC;
        private System.Windows.Forms.CheckBox checkSqlLitePath;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button sqlLitePathButton;
        private System.Windows.Forms.TextBox sqlLitePath;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox saveConfigCheck;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkForUpdatesToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

