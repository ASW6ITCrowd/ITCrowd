namespace frm_projectdesign_ITCrowd
{
    partial class EditCustomer
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
            this.lbEmail = new System.Windows.Forms.Label();
            this.lbLastName = new System.Windows.Forms.Label();
            this.tbEmailEdit = new System.Windows.Forms.TextBox();
            this.tbLastNameEdit = new System.Windows.Forms.TextBox();
            this.btnCloseEdit = new System.Windows.Forms.Button();
            this.btnOKEdit = new System.Windows.Forms.Button();
            this.epErrorEdit = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.epErrorEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Location = new System.Drawing.Point(31, 74);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(73, 13);
            this.lbEmail.TabIndex = 10;
            this.lbEmail.Text = "Email Address";
            // 
            // lbLastName
            // 
            this.lbLastName.AutoSize = true;
            this.lbLastName.Location = new System.Drawing.Point(34, 25);
            this.lbLastName.Name = "lbLastName";
            this.lbLastName.Size = new System.Drawing.Size(58, 13);
            this.lbLastName.TabIndex = 9;
            this.lbLastName.Text = "Last Name";
            // 
            // tbEmailEdit
            // 
            this.tbEmailEdit.Location = new System.Drawing.Point(31, 91);
            this.tbEmailEdit.Name = "tbEmailEdit";
            this.tbEmailEdit.Size = new System.Drawing.Size(100, 20);
            this.tbEmailEdit.TabIndex = 8;
            this.tbEmailEdit.Validating += new System.ComponentModel.CancelEventHandler(this.tbEmailEdit_Validating);
            this.tbEmailEdit.Validated += new System.EventHandler(this.tbEmailEdit_Validated);
            // 
            // tbLastNameEdit
            // 
            this.tbLastNameEdit.Location = new System.Drawing.Point(31, 47);
            this.tbLastNameEdit.Name = "tbLastNameEdit";
            this.tbLastNameEdit.Size = new System.Drawing.Size(100, 20);
            this.tbLastNameEdit.TabIndex = 7;
            this.tbLastNameEdit.Validating += new System.ComponentModel.CancelEventHandler(this.tbLastNameEdit_Validating);
            this.tbLastNameEdit.Validated += new System.EventHandler(this.tbLastNameEdit_Validated);
            // 
            // btnCloseEdit
            // 
            this.btnCloseEdit.Location = new System.Drawing.Point(93, 127);
            this.btnCloseEdit.Name = "btnCloseEdit";
            this.btnCloseEdit.Size = new System.Drawing.Size(75, 23);
            this.btnCloseEdit.TabIndex = 12;
            this.btnCloseEdit.Text = "Close";
            this.btnCloseEdit.UseVisualStyleBackColor = true;
            this.btnCloseEdit.Click += new System.EventHandler(this.btnCloseEdit_Click);
            // 
            // btnOKEdit
            // 
            this.btnOKEdit.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOKEdit.Location = new System.Drawing.Point(12, 127);
            this.btnOKEdit.Name = "btnOKEdit";
            this.btnOKEdit.Size = new System.Drawing.Size(75, 23);
            this.btnOKEdit.TabIndex = 11;
            this.btnOKEdit.Text = "OK";
            this.btnOKEdit.UseVisualStyleBackColor = true;
            this.btnOKEdit.Click += new System.EventHandler(this.btnOKEdit_Click);
            // 
            // epErrorEdit
            // 
            this.epErrorEdit.ContainerControl = this;
            // 
            // EditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(195, 171);
            this.Controls.Add(this.btnCloseEdit);
            this.Controls.Add(this.btnOKEdit);
            this.Controls.Add(this.lbEmail);
            this.Controls.Add(this.lbLastName);
            this.Controls.Add(this.tbEmailEdit);
            this.Controls.Add(this.tbLastNameEdit);
            this.Name = "EditCustomer";
            this.Text = "EditCustomer";
            ((System.ComponentModel.ISupportInitialize)(this.epErrorEdit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.Label lbLastName;
        private System.Windows.Forms.TextBox tbEmailEdit;
        private System.Windows.Forms.TextBox tbLastNameEdit;
        private System.Windows.Forms.Button btnCloseEdit;
        private System.Windows.Forms.Button btnOKEdit;
        private System.Windows.Forms.ErrorProvider epErrorEdit;
    }
}