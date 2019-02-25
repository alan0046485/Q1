namespace Q1
{
    partial class CustomerArrearsReport
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
            this.dgvCustomerArrears = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerArrears)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvCustomerArrears
            // 
            this.dgvCustomerArrears.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerArrears.Location = new System.Drawing.Point(1, 0);
            this.dgvCustomerArrears.Name = "dgvCustomerArrears";
            this.dgvCustomerArrears.Size = new System.Drawing.Size(509, 150);
            this.dgvCustomerArrears.TabIndex = 0;
            // 
            // CustomerArrearsReport
            // 
            this.ClientSize = new System.Drawing.Size(512, 261);
            this.Controls.Add(this.dgvCustomerArrears);
            this.Name = "CustomerArrearsReport";
            this.Text = "Customer Arrears Report";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerArrears)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCustomerArrears;
    }
}
