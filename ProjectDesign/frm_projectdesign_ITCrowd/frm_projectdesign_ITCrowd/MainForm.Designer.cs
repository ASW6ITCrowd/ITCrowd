namespace frm_projectdesign_ITCrowd
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
            this.tbReadBox = new System.Windows.Forms.TextBox();
            this.gbCustomer = new System.Windows.Forms.GroupBox();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.btnSaveCSV = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbAmount = new System.Windows.Forms.GroupBox();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.tbChangeCustomerID = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOwe = new System.Windows.Forms.Button();
            this.btnPay = new System.Windows.Forms.Button();
            this.gbCustomer.SuspendLayout();
            this.gbAmount.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbReadBox
            // 
            this.tbReadBox.Location = new System.Drawing.Point(28, 42);
            this.tbReadBox.Multiline = true;
            this.tbReadBox.Name = "tbReadBox";
            this.tbReadBox.ReadOnly = true;
            this.tbReadBox.Size = new System.Drawing.Size(465, 315);
            this.tbReadBox.TabIndex = 0;
            // 
            // gbCustomer
            // 
            this.gbCustomer.Controls.Add(this.btnEditCustomer);
            this.gbCustomer.Controls.Add(this.btnAddCustomer);
            this.gbCustomer.Location = new System.Drawing.Point(544, 42);
            this.gbCustomer.Name = "gbCustomer";
            this.gbCustomer.Size = new System.Drawing.Size(200, 116);
            this.gbCustomer.TabIndex = 1;
            this.gbCustomer.TabStop = false;
            this.gbCustomer.Text = "Customer";
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(24, 38);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(99, 23);
            this.btnAddCustomer.TabIndex = 0;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.Location = new System.Drawing.Point(24, 79);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(99, 23);
            this.btnEditCustomer.TabIndex = 1;
            this.btnEditCustomer.Text = "Edit Customer";
            this.btnEditCustomer.UseVisualStyleBackColor = true;
            // 
            // btnSaveCSV
            // 
            this.btnSaveCSV.Location = new System.Drawing.Point(552, 334);
            this.btnSaveCSV.Name = "btnSaveCSV";
            this.btnSaveCSV.Size = new System.Drawing.Size(75, 23);
            this.btnSaveCSV.TabIndex = 2;
            this.btnSaveCSV.Text = "Save";
            this.btnSaveCSV.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(658, 334);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // gbAmount
            // 
            this.gbAmount.Controls.Add(this.btnPay);
            this.gbAmount.Controls.Add(this.btnOwe);
            this.gbAmount.Controls.Add(this.label2);
            this.gbAmount.Controls.Add(this.label1);
            this.gbAmount.Controls.Add(this.tbChangeCustomerID);
            this.gbAmount.Controls.Add(this.tbAmount);
            this.gbAmount.Location = new System.Drawing.Point(544, 177);
            this.gbAmount.Name = "gbAmount";
            this.gbAmount.Size = new System.Drawing.Size(200, 133);
            this.gbAmount.TabIndex = 4;
            this.gbAmount.TabStop = false;
            this.gbAmount.Text = "Change Amount";
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(114, 38);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(57, 20);
            this.tbAmount.TabIndex = 0;
            // 
            // tbChangeCustomerID
            // 
            this.tbChangeCustomerID.Location = new System.Drawing.Point(24, 38);
            this.tbChangeCustomerID.Name = "tbChangeCustomerID";
            this.tbChangeCustomerID.Size = new System.Drawing.Size(59, 20);
            this.tbChangeCustomerID.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Cutomer ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Amount";
            // 
            // btnOwe
            // 
            this.btnOwe.Location = new System.Drawing.Point(24, 82);
            this.btnOwe.Name = "btnOwe";
            this.btnOwe.Size = new System.Drawing.Size(75, 23);
            this.btnOwe.TabIndex = 4;
            this.btnOwe.Text = "OWE";
            this.btnOwe.UseVisualStyleBackColor = true;
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(114, 82);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(75, 23);
            this.btnPay.TabIndex = 5;
            this.btnPay.Text = "PAY";
            this.btnPay.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 391);
            this.Controls.Add(this.gbAmount);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSaveCSV);
            this.Controls.Add(this.gbCustomer);
            this.Controls.Add(this.tbReadBox);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.gbCustomer.ResumeLayout(false);
            this.gbAmount.ResumeLayout(false);
            this.gbAmount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbReadBox;
        private System.Windows.Forms.GroupBox gbCustomer;
        private System.Windows.Forms.Button btnEditCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnSaveCSV;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox gbAmount;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnOwe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbChangeCustomerID;
        private System.Windows.Forms.TextBox tbAmount;
    }
}