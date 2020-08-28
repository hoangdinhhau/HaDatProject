namespace HaDatProject
{
    partial class fLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fLog));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btSeachLog = new System.Windows.Forms.Button();
            this.txtChecktime_Id = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtgLog = new System.Windows.Forms.DataGridView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgLog)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btSeachLog);
            this.panel1.Controls.Add(this.txtChecktime_Id);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(1, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(795, 100);
            this.panel1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(371, 54);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tìm kiếm";
            // 
            // btSeachLog
            // 
            this.btSeachLog.BackColor = System.Drawing.Color.Honeydew;
            this.btSeachLog.BackgroundImage = global::HaDatProject.Properties.Resources.google_web_search_100px;
            this.btSeachLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btSeachLog.Location = new System.Drawing.Point(362, 9);
            this.btSeachLog.Name = "btSeachLog";
            this.btSeachLog.Size = new System.Drawing.Size(90, 42);
            this.btSeachLog.TabIndex = 4;
            this.btSeachLog.UseVisualStyleBackColor = false;
            this.btSeachLog.Click += new System.EventHandler(this.btSeachLog_Click);
            // 
            // txtChecktime_Id
            // 
            this.txtChecktime_Id.Location = new System.Drawing.Point(165, 48);
            this.txtChecktime_Id.Name = "txtChecktime_Id";
            this.txtChecktime_Id.Size = new System.Drawing.Size(151, 22);
            this.txtChecktime_Id.TabIndex = 3;
            this.txtChecktime_Id.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(119, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "CHECKTIME_ID";
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(165, 9);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(151, 22);
            this.txtUserName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "USER NAME";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtgLog);
            this.panel2.Location = new System.Drawing.Point(3, 107);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(795, 331);
            this.panel2.TabIndex = 1;
            // 
            // dtgLog
            // 
            this.dtgLog.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dtgLog.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dtgLog.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgLog.Location = new System.Drawing.Point(4, 4);
            this.dtgLog.Name = "dtgLog";
            this.dtgLog.RowTemplate.Height = 24;
            this.dtgLog.Size = new System.Drawing.Size(788, 324);
            this.dtgLog.TabIndex = 0;
            // 
            // fLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "fLog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lịch sử chỉnh sửa";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgLog)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btSeachLog;
        private System.Windows.Forms.TextBox txtChecktime_Id;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dtgLog;
    }
}