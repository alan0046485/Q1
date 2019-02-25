namespace Q1
{
    partial class Form1
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
            this.dgvWaterMeters = new System.Windows.Forms.DataGridView();
            this.dgvAccount = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpWaterMeterSort = new System.Windows.Forms.GroupBox();
            this.rbVolumeUsed = new System.Windows.Forms.RadioButton();
            this.rbMetreID = new System.Windows.Forms.RadioButton();
            this.btnSummaryReport = new System.Windows.Forms.Button();
            this.btnCustomerArrears = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWaterMeters)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).BeginInit();
            this.grpWaterMeterSort.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvWaterMeters
            // 
            this.dgvWaterMeters.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWaterMeters.Location = new System.Drawing.Point(13, 19);
            this.dgvWaterMeters.Name = "dgvWaterMeters";
            this.dgvWaterMeters.Size = new System.Drawing.Size(714, 150);
            this.dgvWaterMeters.TabIndex = 0;
            this.dgvWaterMeters.RowEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvWaterMeters_RowEnter);
            // 
            // dgvAccount
            // 
            this.dgvAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccount.Location = new System.Drawing.Point(13, 187);
            this.dgvAccount.Name = "dgvAccount";
            this.dgvAccount.Size = new System.Drawing.Size(714, 150);
            this.dgvAccount.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Water Metres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 171);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Water Metre Account";
            // 
            // grpWaterMeterSort
            // 
            this.grpWaterMeterSort.Controls.Add(this.rbVolumeUsed);
            this.grpWaterMeterSort.Controls.Add(this.rbMetreID);
            this.grpWaterMeterSort.Location = new System.Drawing.Point(13, 355);
            this.grpWaterMeterSort.Name = "grpWaterMeterSort";
            this.grpWaterMeterSort.Size = new System.Drawing.Size(200, 87);
            this.grpWaterMeterSort.TabIndex = 4;
            this.grpWaterMeterSort.TabStop = false;
            this.grpWaterMeterSort.Text = "Sort Water Metres";
            // 
            // rbVolumeUsed
            // 
            this.rbVolumeUsed.AutoSize = true;
            this.rbVolumeUsed.Location = new System.Drawing.Point(6, 55);
            this.rbVolumeUsed.Name = "rbVolumeUsed";
            this.rbVolumeUsed.Size = new System.Drawing.Size(88, 17);
            this.rbVolumeUsed.TabIndex = 1;
            this.rbVolumeUsed.TabStop = true;
            this.rbVolumeUsed.Text = "Volume Used";
            this.rbVolumeUsed.UseVisualStyleBackColor = true;
            this.rbVolumeUsed.CheckedChanged += new System.EventHandler(this.rbVolumeUsed_CheckedChanged);
            // 
            // rbMetreID
            // 
            this.rbMetreID.AutoSize = true;
            this.rbMetreID.Location = new System.Drawing.Point(6, 19);
            this.rbMetreID.Name = "rbMetreID";
            this.rbMetreID.Size = new System.Drawing.Size(63, 17);
            this.rbMetreID.TabIndex = 0;
            this.rbMetreID.TabStop = true;
            this.rbMetreID.Text = "MetreID";
            this.rbMetreID.UseVisualStyleBackColor = true;
            this.rbMetreID.CheckedChanged += new System.EventHandler(this.rbMetreID_CheckedChanged);
            // 
            // btnSummaryReport
            // 
            this.btnSummaryReport.Location = new System.Drawing.Point(580, 374);
            this.btnSummaryReport.Name = "btnSummaryReport";
            this.btnSummaryReport.Size = new System.Drawing.Size(101, 86);
            this.btnSummaryReport.TabIndex = 2;
            this.btnSummaryReport.Text = "Summary Report";
            this.btnSummaryReport.UseVisualStyleBackColor = true;
            this.btnSummaryReport.Click += new System.EventHandler(this.btnSummaryReport_Click);
            // 
            // btnCustomerArrears
            // 
            this.btnCustomerArrears.Location = new System.Drawing.Point(449, 374);
            this.btnCustomerArrears.Name = "btnCustomerArrears";
            this.btnCustomerArrears.Size = new System.Drawing.Size(101, 86);
            this.btnCustomerArrears.TabIndex = 5;
            this.btnCustomerArrears.Text = "Customer Arrears";
            this.btnCustomerArrears.UseVisualStyleBackColor = true;
            this.btnCustomerArrears.Click += new System.EventHandler(this.btnCustomerArrears_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(731, 481);
            this.Controls.Add(this.btnCustomerArrears);
            this.Controls.Add(this.grpWaterMeterSort);
            this.Controls.Add(this.btnSummaryReport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvAccount);
            this.Controls.Add(this.dgvWaterMeters);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvWaterMeters)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccount)).EndInit();
            this.grpWaterMeterSort.ResumeLayout(false);
            this.grpWaterMeterSort.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvWaterMeters;
        private System.Windows.Forms.DataGridView dgvAccount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpWaterMeterSort;
        private System.Windows.Forms.RadioButton rbVolumeUsed;
        private System.Windows.Forms.RadioButton rbMetreID;
        private System.Windows.Forms.Button btnSummaryReport;
        private System.Windows.Forms.Button btnCustomerArrears;
    }
}

