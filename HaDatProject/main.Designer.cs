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
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btSearch = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.dtpChecktime = new System.Windows.Forms.DateTimePicker();
            this.txtPIN = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgMain = new System.Windows.Forms.DataGridView();
            this.pin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checktime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMain)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btSearch);
            this.panel1.Controls.Add(this.btUpdate);
            this.panel1.Controls.Add(this.dtpChecktime);
            this.panel1.Controls.Add(this.txtPIN);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 191);
            this.panel1.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(421, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(73, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "Cập nhật";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(421, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 24;
            this.label4.Text = "Tìm kiếm";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "SEARCH";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(138, 26);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(235, 22);
            this.txtSearch.TabIndex = 22;
            // 
            // btSearch
            // 
            this.btSearch.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btSearch.BackColor = System.Drawing.Color.MintCream;
            this.btSearch.BackgroundImage = global::HaDatProject.Properties.Resources.google_web_search_100px;
            this.btSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btSearch.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btSearch.ForeColor = System.Drawing.Color.Black;
            this.btSearch.Location = new System.Drawing.Point(401, 3);
            this.btSearch.Name = "btSearch";
            this.btSearch.Size = new System.Drawing.Size(102, 57);
            this.btSearch.TabIndex = 21;
            this.btSearch.UseVisualStyleBackColor = false;
            this.btSearch.Click += new System.EventHandler(this.btSearch_Click);
            // 
            // btUpdate
            // 
            this.btUpdate.BackgroundImage = global::HaDatProject.Properties.Resources.icons8_update_100px;
            this.btUpdate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btUpdate.ForeColor = System.Drawing.SystemColors.Desktop;
            this.btUpdate.Location = new System.Drawing.Point(401, 92);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(102, 60);
            this.btUpdate.TabIndex = 18;
            this.btUpdate.UseVisualStyleBackColor = true;
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
            this.panel2.Location = new System.Drawing.Point(1, 200);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(649, 346);
            this.panel2.TabIndex = 1;
            // 
            // dtgMain
            // 
            this.dtgMain.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCellsExceptHeader;
            this.dtgMain.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.pin,
            this.checktime});
            this.dtgMain.Location = new System.Drawing.Point(3, 3);
            this.dtgMain.Name = "dtgMain";
            this.dtgMain.RowTemplate.Height = 24;
            this.dtgMain.Size = new System.Drawing.Size(646, 340);
            this.dtgMain.TabIndex = 0;
            this.dtgMain.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgMain_CellContentClick);
            this.dtgMain.RowStateChanged += new System.Windows.Forms.DataGridViewRowStateChangedEventHandler(this.dtgMain_RowStateChanged);
            // 
            // pin
            // 
            this.pin.DataPropertyName = "PIN";
            this.pin.HeaderText = "MSNV";
            this.pin.Name = "pin";
            this.pin.Width = 24;
            // 
            // checktime
            // 
            this.checktime.DataPropertyName = "checktime";
            this.checktime.HeaderText = "CheckTime";
            this.checktime.Name = "checktime";
            this.checktime.Width = 24;
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(658, 549);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "main";
            this.Text = "Main";
            this.Load += new System.EventHandler(this.main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMain)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn pin;
        private System.Windows.Forms.DataGridViewTextBoxColumn checktime;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

