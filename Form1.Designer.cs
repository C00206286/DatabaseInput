namespace DatabaseInput
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
            this.CompanyBox = new System.Windows.Forms.ComboBox();
            this.AddCompany = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.CompanyTextBox = new System.Windows.Forms.TextBox();
            this.AccountTextBox = new System.Windows.Forms.TextBox();
            this.NumberTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // CompanyBox
            // 
            this.CompanyBox.FormattingEnabled = true;
            this.CompanyBox.Location = new System.Drawing.Point(353, 57);
            this.CompanyBox.Name = "CompanyBox";
            this.CompanyBox.Size = new System.Drawing.Size(191, 21);
            this.CompanyBox.TabIndex = 0;
            this.CompanyBox.Text = "Company";
            this.CompanyBox.SelectedIndexChanged += new System.EventHandler(this.CompanyBox_SelectedIndexChanged);
            // 
            // AddCompany
            // 
            this.AddCompany.Location = new System.Drawing.Point(55, 220);
            this.AddCompany.Name = "AddCompany";
            this.AddCompany.Size = new System.Drawing.Size(131, 23);
            this.AddCompany.TabIndex = 1;
            this.AddCompany.Text = "Add Company";
            this.AddCompany.UseVisualStyleBackColor = true;
            this.AddCompany.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(55, 110);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(131, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Add Number";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // CompanyTextBox
            // 
            this.CompanyTextBox.Location = new System.Drawing.Point(353, 220);
            this.CompanyTextBox.Name = "CompanyTextBox";
            this.CompanyTextBox.Size = new System.Drawing.Size(191, 20);
            this.CompanyTextBox.TabIndex = 3;
            this.CompanyTextBox.Text = "New Company";
            this.CompanyTextBox.TextChanged += new System.EventHandler(this.CompanyTextBox_TextChanged);
            // 
            // AccountTextBox
            // 
            this.AccountTextBox.Location = new System.Drawing.Point(353, 258);
            this.AccountTextBox.Name = "AccountTextBox";
            this.AccountTextBox.Size = new System.Drawing.Size(77, 20);
            this.AccountTextBox.TabIndex = 4;
            this.AccountTextBox.Text = "Account Code";
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.Location = new System.Drawing.Point(353, 110);
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.Size = new System.Drawing.Size(191, 20);
            this.NumberTextBox.TabIndex = 5;
            this.NumberTextBox.Text = "New Number";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.NumberTextBox);
            this.Controls.Add(this.AccountTextBox);
            this.Controls.Add(this.CompanyTextBox);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.AddCompany);
            this.Controls.Add(this.CompanyBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CompanyBox;
        private System.Windows.Forms.Button AddCompany;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox CompanyTextBox;
        private System.Windows.Forms.TextBox AccountTextBox;
        private System.Windows.Forms.TextBox NumberTextBox;
    }
}

