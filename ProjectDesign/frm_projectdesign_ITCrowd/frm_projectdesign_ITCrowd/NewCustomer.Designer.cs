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
            this.lbFirstName = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbBalance = new System.Windows.Forms.Label();
            this.btnOKNewCus = new System.Windows.Forms.Button();
            this.btnCloseNewCus = new System.Windows.Forms.Button();
            this.epError = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epError)).BeginInit();
            this.SuspendLayout();
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(23, 42);
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(100, 20);
            this.tbFirstName.TabIndex = 0;
            this.tbFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.tbFirstName_Validating);
            this.tbFirstName.Validated += new System.EventHandler(this.tbFirstName_Validated);
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(23, 91);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(100, 20);
            this.tbLastName.TabIndex = 1;
            this.tbLastName.Validating += new System.ComponentModel.CancelEventHandler(this.tbLastName_Validating);
            this.tbLastName.Validated += new System.EventHandler(this.tbLastName_Validated);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(23, 135);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(100, 20);
            this.tbEmail.TabIndex = 2;
            this.tbEmail.Validating += new System.ComponentModel.CancelEventHandler(this.tbEmail_Validating);
            this.tbEmail.Validated += new System.EventHandler(this.tbEmail_Validated);
            // 
            // tbAccBalance
            // 
            this.tbAccBalance.Location = new System.Drawing.Point(23, 183);
            this.tbAccBalance.Name = "tbAccBalance";
            this.tbAccBalance.Size = new System.Drawing.Size(100, 20);
            this.tbAccBalance.TabIndex = 3;
            this.tbAccBalance.Validating += new System.ComponentModel.CancelEventHandler(this.tbAccBalance_Validating);
            // 
            // lbFirstName
            // 
            this.lbFirstName.AutoSize = true;
            this.lbFirstName.Location = new System.Drawing.Point(23, 23);
            this.lbFirstName.Name = "lbFirstName";
            this.lbFirstName.Size = new System.Drawing.Size(57, 13);
            this.lbFirstName.TabIndex = 4;
            this.lbFirstName.Text = "First Name";
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Location = new System.Drawing.Point(26, 69);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(58, 13);
            this.lbLastName.TabIndex = 5;
            this.lbLastName.Text = "Last Name";
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(23, 118);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(73, 13);
            this.lbEmail.TabIndex = 6;
            this.lbEmail.Text = "Email Address";
            // 
            // lbBalance
            // 
            this.lbBalance.AutoSize = true;
            this.lbBalance.Location = new System.Drawing.Point(23, 167);
            this.lbBalance.Name = "lbBalance";
            this.lbBalance.Size = new System.Drawing.Size(89, 13);
            this.lbBalance.TabIndex = 7;
            this.lbBalance.Text = "Account Balance";
            // 
            // btnOKNewCus
            // 
            this.btnOKNewCus.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOKNewCus.Location = new System.Drawing.Point(11, 221);
            this.btnOKNewCus.Name = "btnOKNewCus";
            this.btnOKNewCus.Size = new System.Drawing.Size(75, 23);
            this.btnOKNewCus.TabIndex = 8;
            this.btnOKNewCus.Text = "OK";
            this.btnOKNewCus.UseVisualStyleBackColor = true;
            this.btnOKNewCus.Click += new System.EventHandler(this.btnOKNewCus_Click);
            // 
            // btnCloseNewCus
            // 
            this.btnCloseNewCus.Location = new System.Drawing.Point(92, 221);
            this.btnCloseNewCus.Name = "btnCloseNewCus";
            this.btnCloseNewCus.Size = new System.Drawing.Size(75, 23);
            this.btnCloseNewCus.TabIndex = 9;
            this.btnCloseNewCus.Text = "Close";
            this.btnCloseNewCus.UseVisualStyleBackColor = true;
            this.btnCloseNewCus.Click += new System.EventHandler(this.btnCloseNewCus_Click);
            // 
            // epError
            // 
            this.epError.ContainerControl = this;
            // 
            // NewCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(200, 264);
            this.Controls.Add(this.btnCloseNewCus);
            this.Controls.Add(this.btnOKNewCus);
            this.Controls.Add(this.lbBalance);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.lbFirstName);
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
        private System.Windows.Forms.Label lbFirstName;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbBalance;
        private System.Windows.Forms.Button btnOKNewCus;
        private System.Windows.Forms.Button btnCloseNewCus;
        private System.Windows.Forms.ErrorProvider epError;
    }
}