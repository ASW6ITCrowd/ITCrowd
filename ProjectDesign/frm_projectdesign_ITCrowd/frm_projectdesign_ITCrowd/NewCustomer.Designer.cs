namespace frm_projectdesign_ITCrowd
{
    partial class NewCustomer
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
            this.components = new System.ComponentModel.Container();
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbAccBalance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOKNewCus = new System.Windows.Forms.Button();
            this.btnCloseNewCus = new System.Windows.Forms.Button();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.SuspendLayout();
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(78, 77);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(100, 20);
            this.tbFirstName.TabIndex = 0;
            this.tbFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.tbFirstName_Validating);
            this.tbFirstName.Validated += new System.EventHandler(this.tbFirstName_Validated);
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(78, 126);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(100, 20);
            this.tbLastName.TabIndex = 1;
            this.tbLastName.Validating += new System.ComponentModel.CancelEventHandler(this.tbLastName_Validating);
            this.tbLastName.Validated += new System.EventHandler(this.tbLastName_Validated);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(78, 170);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(100, 20);
            this.tbEmail.TabIndex = 2;
            this.tbEmail.Validating += new System.ComponentModel.CancelEventHandler(this.tbEmail_Validating);
            this.tbEmail.Validated += new System.EventHandler(this.tbEmail_Validated);
            // 
            // tbAccBalance
            // 
            this.tbAccBalance.Location = new System.Drawing.Point(78, 240);
            this.tbAccBalance.Name = "tbAccBalance";
            this.tbAccBalance.Size = new System.Drawing.Size(100, 20);
            this.tbAccBalance.TabIndex = 3;
            this.tbAccBalance.Validating += new System.ComponentModel.CancelEventHandler(this.tbAccBalance_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email Address";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Current Account Balance";
            // 
            // btnOKNewCus
            // 
            this.btnOKNewCus.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOKNewCus.Location = new System.Drawing.Point(78, 310);
            this.btnOKNewCus.Name = "btnOKNewCus";
            this.btnOKNewCus.Size = new System.Drawing.Size(75, 23);
            this.btnOKNewCus.TabIndex = 8;
            this.btnOKNewCus.Text = "OK";
            this.btnOKNewCus.UseVisualStyleBackColor = true;
            this.btnOKNewCus.Click += new System.EventHandler(this.btnOKNewCus_Click);
            // 
            // btnCloseNewCus
            // 
            this.btnCloseNewCus.Location = new System.Drawing.Point(184, 310);
            this.btnCloseNewCus.Name = "btnCloseNewCus";
            this.btnCloseNewCus.Size = new System.Drawing.Size(75, 23);
            this.btnCloseNewCus.TabIndex = 9;
            this.btnCloseNewCus.Text = "Close";
            this.btnCloseNewCus.UseVisualStyleBackColor = true;
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // NewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(425, 384);
            this.Controls.Add(this.btnCloseNewCus);
            this.Controls.Add(this.btnOKNewCus);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAccBalance);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbFirstName);
            this.Name = "NewCustomer";
            this.Text = "NewCustomer";
            ((System.ComponentModel.ISupportInitialize)(this.epError)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbAccBalance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOKNewCus;
        private System.Windows.Forms.Button btnCloseNewCus;
        private System.Windows.Forms.ErrorProvider epError;
    }
}