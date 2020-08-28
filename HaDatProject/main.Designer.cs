namespace HaDatProject
{
    partial class main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(main));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.btResest = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.btLogout = new System.Windows.Forms.Button();
            this.txtId = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btUpdate = new System.Windows.Forms.Button();
            this.dtpChecktime = new System.Windows.Forms.DateTimePicker();
            this.txtPIN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgMain = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checktime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.lịchSửChỉnhSửaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMain)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.btLogout);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.btUpdate);
            this.panel1.Controls.Add(this.dtpChecktime);
            this.panel1.Controls.Add(this.txtPIN);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(1, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(825, 180);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.btResest);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Controls.Add(this.btSearch);
            this.panel3.Location = new System.Drawing.Point(5, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(814, 70);
            this.panel3.TabIndex = 32;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(551, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "Làm mới";
            // 
            // btResest
            // 
            this.btResest.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btResest.BackgroundImage = global::HaDatProject.Properties.Resources.refresh_96px;
            this.btResest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btResest.Location = new System.Drawing.Point(530, 6);
            this.btResest.Name = "btResest";
            this.btResest.Size = new System.Drawing.Size(98, 39);
            this.btResest.TabIndex = 32;
            this.btResest.UseVisualStyleBackColor = false;
            this.btResest.Click += new System.EventHandler(this.btResest_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(417, 48);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 31;
            this.label4.Text = "Tìm kiếm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(7, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "SEARCH";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(132, 14);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(235, 22);
            this.txtSearch.TabIndex = 29;
            // 
            // btSearch
            // 
            this.btSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btSearch.BackColor = System.Drawing.Color.MintCream;
            this.btSearch.BackgroundImage = global::HaDatProject.Properties.Resources.google_web_search_100px;
            this.btSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btSearch.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSearch.ForeColor = System.Drawing.Color.Black;
            this.btSearch.Location = new System.Drawing.Point(406, 6);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(99, 39);
            this.btSearch.TabIndex = 28;
            this.btSearch.UseVisualStyleBackColor = false;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(734, 162);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 17);
            this.label8.TabIndex = 31;
            this.label8.Text = "Đăng xuất";
            // 
            // btLogout
            // 
            this.btLogout.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btLogout.BackgroundImage = global::HaDatProject.Properties.Resources.door_sensor_alarmed_80px;
            this.btLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btLogout.Location = new System.Drawing.Point(737, 125);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(84, 34);
            this.btLogout.TabIndex = 30;
            this.btLogout.UseVisualStyleBackColor = false;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.SystemColors.Window;
            this.txtId.Cursor = System.Windows.Forms.Cursors.No;
            this.txtId.Location = new System.Drawing.Point(440, 84);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(87, 22);
            this.txtId.TabIndex = 29;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(397, 86);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(28, 20);
            this.label7.TabIndex = 28;
            this.label7.Text = "ID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(432, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Cập nhật";
            // 
            // btUpdate
            // 
            this.btUpdate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btUpdate.BackgroundImage = global::HaDatProject.Properties.Resources.icons8_update_100px;
            this.btUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdate.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btUpdate.Location = new System.Drawing.Point(423, 114);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(112, 42);
            this.btUpdate.TabIndex = 18;
            this.btUpdate.UseVisualStyleBackColor = false;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // dtpChecktime
            // 
            this.dtpChecktime.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpChecktime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpChecktime.Location = new System.Drawing.Point(138, 134);
            this.dtpChecktime.Name = "dtpChecktime";
            this.dtpChecktime.Size = new System.Drawing.Size(235, 22);
            this.dtpChecktime.TabIndex = 6;
            // 
            // txtPIN
            // 
            this.txtPIN.BackColor = System.Drawing.SystemColors.Window;
            this.txtPIN.Cursor = System.Windows.Forms.Cursors.No;
            this.txtPIN.Location = new System.Drawing.Point(138, 86);
            this.txtPIN.Name = "txtPIN";
            this.txtPIN.ReadOnly = true;
            this.txtPIN.Size = new System.Drawing.Size(235, 22);
            this.txtPIN.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 139);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "CHECKTIME";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(10, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "MSNV";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgMain);
            this.panel2.Location = new System.Drawing.Point(1, 212);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(825, 254);
            this.panel2.TabIndex = 1;
            // 
            // dtgMain
            // 
            this.dtgMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgMain.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.pin,
            this.checktime});
            this.dtgMain.Location = new System.Drawing.Point(5, 3);
            this.dtgMain.Name = "dtgMain";
            this.dtgMain.RowTemplate.Height = 24;
            this.dtgMain.Size = new System.Drawing.Size(814, 248);
            this.dtgMain.TabIndex = 0;
            this.dtgMain.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgMain_CellContentClick);
            this.dtgMain.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dtgMain_RowStateChanged);
            // 
            // ID
            // 
            this.ID.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ID.DataPropertyName = "ID";
            this.ID.FillWeight = 76.14214F;
            this.ID.Frozen = true;
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.Width = 50;
            // 
            // pin
            // 
            this.pin.DataPropertyName = "PIN";
            this.pin.FillWeight = 111.9289F;
            this.pin.HeaderText = "MSNV";
            this.pin.Name = "pin";
            // 
            // checktime
            // 
            this.checktime.DataPropertyName = "checktime";
            this.checktime.FillWeight = 111.9289F;
            this.checktime.HeaderText = "CheckTime";
            this.checktime.Name = "checktime";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lịchSửChỉnhSửaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(828, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // lịchSửChỉnhSửaToolStripMenuItem
            // 
            this.lịchSửChỉnhSửaToolStripMenuItem.Name = "lịchSửChỉnhSửaToolStripMenuItem";
            this.lịchSửChỉnhSửaToolStripMenuItem.Size = new System.Drawing.Size(132, 24);
            this.lịchSửChỉnhSửaToolStripMenuItem.Text = "Lịch sử chỉnh sửa";
            this.lịchSửChỉnhSửaToolStripMenuItem.Click += new System.EventHandler(this.lịchSửChỉnhSửaToolStripMenuItem_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(828, 469);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMain)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.DateTimePicker dtpChecktime;
        private System.Windows.Forms.TextBox txtPIN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgMain;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn pin;
        private System.Windows.Forms.DataGridViewTextBoxColumn checktime;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btResest;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lịchSửChỉnhSửaToolStripMenuItem;
    }
}

