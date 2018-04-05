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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.gbCustomer = new System.Windows.Forms.GroupBox();
            this.lbIDadd = new System.Windows.Forms.Label();
            this.tbEditID = new System.Windows.Forms.TextBox();
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.btnSaveCSV = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.gbAmount = new System.Windows.Forms.GroupBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.btnOwe = new System.Windows.Forms.Button();
            this.lbAmount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbChangeCustomerID = new System.Windows.Forms.TextBox();
            this.tbAmount = new System.Windows.Forms.TextBox();
            this.epErrorMain = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lbLastNameSearch = new System.Windows.Forms.Label();
            this.tbReadBox = new System.Windows.Forms.DataGridView();
            this.c1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.c6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAll = new System.Windows.Forms.Button();
            this.rbGerman = new System.Windows.Forms.RadioButton();
            this.rbEnglish = new System.Windows.Forms.RadioButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.gbCustomer.SuspendLayout();
            this.gbAmount.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epErrorMain)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbReadBox)).BeginInit();
            this.SuspendLayout();
            // 
            // gbCustomer
            // 
            this.gbCustomer.Controls.Add(this.lbIDadd);
            this.gbCustomer.Controls.Add(this.tbEditID);
            this.gbCustomer.Controls.Add(this.btnEditCustomer);
            this.gbCustomer.Controls.Add(this.btnAddCustomer);
            this.gbCustomer.Location = new System.Drawing.Point(752, 51);
            this.gbCustomer.Name = "gbCustomer";
            this.gbCustomer.Size = new System.Drawing.Size(200, 116);
            this.gbCustomer.TabIndex = 1;
            this.gbCustomer.TabStop = false;
            this.gbCustomer.Text = "Customer";
            // 
            // lbIDadd
            // 
            this.lbIDadd.AutoSize = true;
            this.lbIDadd.Location = new System.Drawing.Point(8, 82);
            this.lbIDadd.Name = "lbIDadd";
            this.lbIDadd.Size = new System.Drawing.Size(21, 13);
            this.lbIDadd.TabIndex = 6;
            this.lbIDadd.Text = "ID:";
            // 
            // tbEditID
            // 
            this.tbEditID.Location = new System.Drawing.Point(35, 80);
            this.tbEditID.Name = "tbEditID";
            this.tbEditID.Size = new System.Drawing.Size(31, 20);
            this.tbEditID.TabIndex = 2;
            this.tbEditID.Text = "1";
            this.tbEditID.Validating += new System.ComponentModel.CancelEventHandler(this.tbEditID_Validating);
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.Location = new System.Drawing.Point(72, 77);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(99, 23);
            this.btnEditCustomer.TabIndex = 1;
            this.btnEditCustomer.Text = "Edit Customer";
            this.btnEditCustomer.UseVisualStyleBackColor = true;
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(72, 38);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(99, 23);
            this.btnAddCustomer.TabIndex = 0;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // btnSaveCSV
            // 
            this.btnSaveCSV.Location = new System.Drawing.Point(760, 343);
            this.btnSaveCSV.Name = "btnSaveCSV";
            this.btnSaveCSV.Size = new System.Drawing.Size(75, 23);
            this.btnSaveCSV.TabIndex = 2;
            this.btnSaveCSV.Text = "Save";
            this.btnSaveCSV.UseVisualStyleBackColor = true;
            this.btnSaveCSV.Click += new System.EventHandler(this.btnSaveCSV_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(866, 343);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // gbAmount
            // 
            this.gbAmount.Controls.Add(this.btnPay);
            this.gbAmount.Controls.Add(this.btnOwe);
            this.gbAmount.Controls.Add(this.lbAmount);
            this.gbAmount.Controls.Add(this.label1);
            this.gbAmount.Controls.Add(this.tbChangeCustomerID);
            this.gbAmount.Controls.Add(this.tbAmount);
            this.gbAmount.Location = new System.Drawing.Point(752, 186);
            this.gbAmount.Name = "gbAmount";
            this.gbAmount.Size = new System.Drawing.Size(200, 133);
            this.gbAmount.TabIndex = 4;
            this.gbAmount.TabStop = false;
            this.gbAmount.Text = "Change Balance";
            // 
            // btnPay
            // 
            this.btnPay.Location = new System.Drawing.Point(114, 82);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(75, 23);
            this.btnPay.TabIndex = 5;
            this.btnPay.Text = "PAY";
            this.btnPay.UseVisualStyleBackColor = true;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // btnOwe
            // 
            this.btnOwe.Location = new System.Drawing.Point(24, 82);
            this.btnOwe.Name = "btnOwe";
            this.btnOwe.Size = new System.Drawing.Size(75, 23);
            this.btnOwe.TabIndex = 4;
            this.btnOwe.Text = "OWE";
            this.btnOwe.UseVisualStyleBackColor = true;
            this.btnOwe.Click += new System.EventHandler(this.btnOwe_Click);
            // 
            // lbAmount
            // 
            this.lbAmount.AutoSize = true;
            this.lbAmount.Location = new System.Drawing.Point(111, 20);
            this.lbAmount.Name = "lbAmount";
            this.lbAmount.Size = new System.Drawing.Size(43, 13);
            this.lbAmount.TabIndex = 3;
            this.lbAmount.Text = "Amount";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "ID";
            // 
            // tbChangeCustomerID
            // 
            this.tbChangeCustomerID.Location = new System.Drawing.Point(35, 38);
            this.tbChangeCustomerID.Name = "tbChangeCustomerID";
            this.tbChangeCustomerID.Size = new System.Drawing.Size(31, 20);
            this.tbChangeCustomerID.TabIndex = 1;
            this.tbChangeCustomerID.Text = "1";
            this.tbChangeCustomerID.Validating += new System.ComponentModel.CancelEventHandler(this.tbChangeCustomerID_Validating);
            // 
            // tbAmount
            // 
            this.tbAmount.Location = new System.Drawing.Point(114, 38);
            this.tbAmount.Name = "tbAmount";
            this.tbAmount.Size = new System.Drawing.Size(57, 20);
            this.tbAmount.TabIndex = 0;
            this.tbAmount.Text = "0";
            this.tbAmount.Validating += new System.ComponentModel.CancelEventHandler(this.tbAmount_Validating);
            // 
            // epErrorMain
            // 
            this.epErrorMain.ContainerControl = this;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(215, 14);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(90, 23);
            this.btnSearch.TabIndex = 6;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(97, 16);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(100, 20);
            this.tbSearch.TabIndex = 7;
            this.tbSearch.Validating += new System.ComponentModel.CancelEventHandler(this.tbSearch_Validating);
            // 
            // lbLastNameSearch
            // 
            this.lbLastNameSearch.AutoSize = true;
            this.lbLastNameSearch.Location = new System.Drawing.Point(33, 18);
            this.lbLastNameSearch.Name = "lbLastNameSearch";
            this.lbLastNameSearch.Size = new System.Drawing.Size(58, 13);
            this.lbLastNameSearch.TabIndex = 8;
            this.lbLastNameSearch.Text = "Last Name";
            // 
            // tbReadBox
            // 
            this.tbReadBox.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbReadBox.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.c1,
            this.c3,
            this.c2,
            this.c4,
            this.c5,
            this.c6});
            this.tbReadBox.Location = new System.Drawing.Point(36, 51);
            this.tbReadBox.Name = "tbReadBox";
            this.tbReadBox.Size = new System.Drawing.Size(710, 417);
            this.tbReadBox.TabIndex = 9;
            // 
            // c1
            // 
            this.c1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.c1.HeaderText = "Customer ID";
            this.c1.Name = "c1";
            this.c1.ReadOnly = true;
            this.c1.Width = 83;
            // 
            // c3
            // 
            this.c3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.c3.HeaderText = "First Name";
            this.c3.Name = "c3";
            this.c3.ReadOnly = true;
            this.c3.Width = 76;
            // 
            // c2
            // 
            this.c2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.c2.HeaderText = "Last Name";
            this.c2.Name = "c2";
            this.c2.ReadOnly = true;
            this.c2.Width = 77;
            // 
            // c4
            // 
            this.c4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.c4.HeaderText = "Account Balance";
            this.c4.Name = "c4";
            this.c4.ReadOnly = true;
            this.c4.Width = 105;
            // 
            // c5
            // 
            this.c5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.c5.HeaderText = "Email Address";
            this.c5.Name = "c5";
            this.c5.ReadOnly = true;
            this.c5.Width = 90;
            // 
            // c6
            // 
            this.c6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.c6.HeaderText = "Last Change";
            this.c6.Name = "c6";
            this.c6.ReadOnly = true;
            this.c6.Width = 85;
            // 
            // btnAll
            // 
            this.btnAll.Location = new System.Drawing.Point(311, 14);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(90, 23);
            this.btnAll.TabIndex = 10;
            this.btnAll.Text = "Show All";
            this.btnAll.UseVisualStyleBackColor = true;
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // rbGerman
            // 
            this.rbGerman.AutoSize = true;
            this.rbGerman.Location = new System.Drawing.Point(887, 451);
            this.rbGerman.Name = "rbGerman";
            this.rbGerman.Size = new System.Drawing.Size(65, 17);
            this.rbGerman.TabIndex = 11;
            this.rbGerman.Text = "Deutsch";
            this.rbGerman.UseVisualStyleBackColor = true;
            this.rbGerman.CheckedChanged += new System.EventHandler(this.rbGerman_CheckedChanged);
            // 
            // rbEnglish
            // 
            this.rbEnglish.AutoSize = true;
            this.rbEnglish.Checked = true;
            this.rbEnglish.Location = new System.Drawing.Point(887, 427);
            this.rbEnglish.Name = "rbEnglish";
            this.rbEnglish.Size = new System.Drawing.Size(59, 17);
            this.rbEnglish.TabIndex = 12;
            this.rbEnglish.TabStop = true;
            this.rbEnglish.Text = "English";
            this.rbEnglish.UseVisualStyleBackColor = true;
            this.rbEnglish.CheckedChanged += new System.EventHandler(this.rbEnglish_CheckedChanged);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Black;
            this.imageList1.Images.SetKeyName(0, "usa.png");
            this.imageList1.Images.SetKeyName(1, "Germany.png");
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 555);
            this.Controls.Add(this.rbEnglish);
            this.Controls.Add(this.rbGerman);
            this.Controls.Add(this.btnAll);
            this.Controls.Add(this.tbReadBox);
            this.Controls.Add(this.lbLastNameSearch);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.gbAmount);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSaveCSV);
            this.Controls.Add(this.gbCustomer);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.gbCustomer.ResumeLayout(false);
            this.gbCustomer.PerformLayout();
            this.gbAmount.ResumeLayout(false);
            this.gbAmount.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.epErrorMain)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbReadBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox gbCustomer;
        private System.Windows.Forms.Button btnEditCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.Button btnSaveCSV;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox gbAmount;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnOwe;
        private System.Windows.Forms.Label lbAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbChangeCustomerID;
        private System.Windows.Forms.TextBox tbAmount;
        private System.Windows.Forms.Label lbIDadd;
        private System.Windows.Forms.ErrorProvider epErrorMain;
        private System.Windows.Forms.TextBox tbEditID;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lbLastNameSearch;
        private System.Windows.Forms.DataGridView tbReadBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn c1;
        private System.Windows.Forms.DataGridViewTextBoxColumn c3;
        private System.Windows.Forms.DataGridViewTextBoxColumn c2;
        private System.Windows.Forms.DataGridViewTextBoxColumn c4;
        private System.Windows.Forms.DataGridViewTextBoxColumn c5;
        private System.Windows.Forms.DataGridViewTextBoxColumn c6;
        private System.Windows.Forms.Button btnAll;
        private System.Windows.Forms.RadioButton rbEnglish;
        private System.Windows.Forms.RadioButton rbGerman;
        private System.Windows.Forms.ImageList imageList1;
    }
}