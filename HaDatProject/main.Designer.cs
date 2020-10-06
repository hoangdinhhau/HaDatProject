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
            this.txtId = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.dtpDenngay = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpTungay = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.btResest = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.btLogout = new System.Windows.Forms.Button();
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
            this.btXoa = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMain)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btXoa);
            this.panel1.Controls.Add(this.txtId);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btLogout);
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
            // txtId
            // 
            this.txtId.BackColor = System.Drawing.SystemColors.Menu;
            this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtId.Cursor = System.Windows.Forms.Cursors.No;
            this.txtId.ForeColor = System.Drawing.SystemColors.Menu;
            this.txtId.Location = new System.Drawing.Point(809, 153);
            this.txtId.Name = "txtId";
            this.txtId.ReadOnly = true;
            this.txtId.Size = new System.Drawing.Size(10, 15);
            this.txtId.TabIndex = 33;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.dtpDenngay);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.dtpTungay);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.btResest);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Controls.Add(this.btSearch);
            this.panel3.Location = new System.Drawing.Point(5, 6);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(814, 77);
            this.panel3.TabIndex = 32;
            // 
            // dtpDenngay
            // 
            this.dtpDenngay.CustomFormat = "dd/MM/yyyy";
            this.dtpDenngay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDenngay.Location = new System.Drawing.Point(339, 41);
            this.dtpDenngay.Name = "dtpDenngay";
            this.dtpDenngay.Size = new System.Drawing.Size(121, 22);
            this.dtpDenngay.TabIndex = 37;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(244, 44);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 19);
            this.label10.TabIndex = 36;
            this.label10.Text = "Đến ngày";
            // 
            // dtpTungay
            // 
            this.dtpTungay.CustomFormat = "dd/MM/yyyy";
            this.dtpTungay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpTungay.Location = new System.Drawing.Point(102, 41);
            this.dtpTungay.Name = "dtpTungay";
            this.dtpTungay.Size = new System.Drawing.Size(121, 22);
            this.dtpTungay.TabIndex = 35;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(9, 46);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 19);
            this.label9.TabIndex = 34;
            this.label9.Text = "Từ ngày";
            // 
            // btResest
            // 
            this.btResest.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btResest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btResest.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold);
            this.btResest.Location = new System.Drawing.Point(587, 11);
            this.btResest.Name = "btResest";
            this.btResest.Size = new System.Drawing.Size(98, 52);
            this.btResest.TabIndex = 32;
            this.btResest.Text = "Làm mới";
            this.btResest.UseVisualStyleBackColor = false;
            this.btResest.Click += new System.EventHandler(this.btResest_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 30;
            this.label1.Text = "Mã số NV";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(102, 14);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(358, 22);
            this.txtSearch.TabIndex = 29;
            // 
            // btSearch
            // 
            this.btSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btSearch.BackColor = System.Drawing.Color.MintCream;
            this.btSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btSearch.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSearch.ForeColor = System.Drawing.Color.Black;
            this.btSearch.Location = new System.Drawing.Point(475, 11);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(99, 52);
            this.btSearch.TabIndex = 28;
            this.btSearch.Text = "Tìm kiếm";
            this.btSearch.UseVisualStyleBackColor = false;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click_1);
            // 
            // btLogout
            // 
            this.btLogout.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btLogout.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold);
            this.btLogout.Location = new System.Drawing.Point(704, 91);
            this.btLogout.Name = "btLogout";
            this.btLogout.Size = new System.Drawing.Size(98, 56);
            this.btLogout.TabIndex = 30;
            this.btLogout.Text = "Thoát";
            this.btLogout.UseVisualStyleBackColor = false;
            this.btLogout.Click += new System.EventHandler(this.btLogout_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btUpdate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold);
            this.btUpdate.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btUpdate.Location = new System.Drawing.Point(481, 91);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(99, 54);
            this.btUpdate.TabIndex = 18;
            this.btUpdate.Text = "Cập nhật";
            this.btUpdate.UseVisualStyleBackColor = false;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // dtpChecktime
            // 
            this.dtpChecktime.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dtpChecktime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpChecktime.Location = new System.Drawing.Point(107, 123);
            this.dtpChecktime.Name = "dtpChecktime";
            this.dtpChecktime.Size = new System.Drawing.Size(359, 22);
            this.dtpChecktime.TabIndex = 6;
            this.dtpChecktime.Value = new System.DateTime(2020, 9, 1, 0, 0, 0, 0);
            // 
            // txtPIN
            // 
            this.txtPIN.BackColor = System.Drawing.SystemColors.Window;
            this.txtPIN.Cursor = System.Windows.Forms.Cursors.No;
            this.txtPIN.Location = new System.Drawing.Point(108, 91);
            this.txtPIN.Name = "txtPIN";
            this.txtPIN.ReadOnly = true;
            this.txtPIN.Size = new System.Drawing.Size(358, 22);
            this.txtPIN.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 19);
            this.label3.TabIndex = 3;
            this.label3.Text = "Checktime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã số NV";
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
            this.dtgMain.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgMain_CellContentClick);
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
            // btXoa
            // 
            this.btXoa.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btXoa.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold);
            this.btXoa.Location = new System.Drawing.Point(593, 91);
            this.btXoa.Name = "btXoa";
            this.btXoa.Size = new System.Drawing.Size(98, 56);
            this.btXoa.TabIndex = 34;
            this.btXoa.Text = "Xóa";
            this.btXoa.UseVisualStyleBackColor = false;
            this.btXoa.Click += new System.EventHandler(this.btXoa_Click);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn pin;
        private System.Windows.Forms.DataGridViewTextBoxColumn checktime;
        private System.Windows.Forms.Button btLogout;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btResest;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lịchSửChỉnhSửaToolStripMenuItem;
        private System.Windows.Forms.DateTimePicker dtpDenngay;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpTungay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btXoa;
    }
}

