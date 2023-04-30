namespace WindowsFormsApp1
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
            this.tbName = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.tbPhone = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.countryListbox = new System.Windows.Forms.ListBox();
            this.searchtb = new System.Windows.Forms.TextBox();
            this.searchBt = new System.Windows.Forms.Button();
            this.statusLb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(244, 39);
            this.tbName.Multiline = true;
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(322, 48);
            this.tbName.TabIndex = 0;
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(244, 93);
            this.tbEmail.Multiline = true;
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(322, 48);
            this.tbEmail.TabIndex = 1;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(440, 345);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(126, 41);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click_1);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(244, 345);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(135, 41);
            this.btnClear.TabIndex = 9;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // tbPhone
            // 
            this.tbPhone.Location = new System.Drawing.Point(244, 147);
            this.tbPhone.Multiline = true;
            this.tbPhone.Name = "tbPhone";
            this.tbPhone.Size = new System.Drawing.Size(322, 48);
            this.tbPhone.TabIndex = 2;
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(244, 201);
            this.tbAddress.Multiline = true;
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(322, 115);
            this.tbAddress.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(141, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(141, 105);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(141, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Phone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(141, 204);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Address";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Bangladesh",
            "India",
            "Pakistan",
            "Bhutan",
            "Maynamer",
            "UK",
            "USA",
            ""});
            this.comboBox1.Location = new System.Drawing.Point(622, 39);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(151, 28);
            this.comboBox1.TabIndex = 10;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(639, 101);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(113, 24);
            this.checkBox1.TabIndex = 11;
            this.checkBox1.Text = "checkBox1";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // countryListbox
            // 
            this.countryListbox.AccessibleName = "countryListbox";
            this.countryListbox.FormattingEnabled = true;
            this.countryListbox.ItemHeight = 20;
            this.countryListbox.Items.AddRange(new object[] {
            "Banguladesh",
            "Australia",
            "India",
            "Pakistan",
            "Bhutan",
            "Maynmer",
            "china",
            "nepal",
            "japan",
            "Usa",
            "UK"});
            this.countryListbox.Location = new System.Drawing.Point(632, 131);
            this.countryListbox.Name = "countryListbox";
            this.countryListbox.Size = new System.Drawing.Size(120, 124);
            this.countryListbox.TabIndex = 12;
            // 
            // searchtb
            // 
            this.searchtb.AccessibleName = "searchboxtb";
            this.searchtb.Location = new System.Drawing.Point(633, 271);
            this.searchtb.Name = "searchtb";
            this.searchtb.Size = new System.Drawing.Size(119, 26);
            this.searchtb.TabIndex = 13;
            this.searchtb.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // searchBt
            // 
            this.searchBt.AccessibleName = "Searchbtn";
            this.searchBt.Location = new System.Drawing.Point(633, 311);
            this.searchBt.Name = "searchBt";
            this.searchBt.Size = new System.Drawing.Size(119, 29);
            this.searchBt.TabIndex = 14;
            this.searchBt.Text = "Search";
            this.searchBt.UseVisualStyleBackColor = true;
            this.searchBt.Click += new System.EventHandler(this.button1_Click);
            // 
            // statusLb
            // 
            this.statusLb.AccessibleName = "statuslbl";
            this.statusLb.AutoSize = true;
            this.statusLb.Location = new System.Drawing.Point(635, 355);
            this.statusLb.Name = "statusLb";
            this.statusLb.Size = new System.Drawing.Size(56, 20);
            this.statusLb.TabIndex = 15;
            this.statusLb.Text = "Status";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusLb);
            this.Controls.Add(this.searchBt);
            this.Controls.Add(this.searchtb);
            this.Controls.Add(this.countryListbox);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbPhone);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbName);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.TextBox tbPhone;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ListBox countryListbox;
        private System.Windows.Forms.TextBox searchtb;
        private System.Windows.Forms.Button searchBt;
        private System.Windows.Forms.Label statusLb;
    }
}

