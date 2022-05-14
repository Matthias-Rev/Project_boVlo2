namespace BoVloApp
{
    partial class CatalogMember
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
            this.labelAlreadyClient = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelNotInDB = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelCompanyVAT = new System.Windows.Forms.Label();
            this.companyVATInput = new System.Windows.Forms.TextBox();
            this.lookUpCompany = new System.Windows.Forms.Button();
            this.btnBecomeMember = new System.Windows.Forms.Button();
            this.labelNotCustomer = new System.Windows.Forms.Label();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.panelMember = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMember.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelAlreadyClient
            // 
            this.labelAlreadyClient.AutoSize = true;
            this.labelAlreadyClient.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAlreadyClient.Location = new System.Drawing.Point(124, 71);
            this.labelAlreadyClient.Name = "labelAlreadyClient";
            this.labelAlreadyClient.Size = new System.Drawing.Size(165, 28);
            this.labelAlreadyClient.TabIndex = 0;
            this.labelAlreadyClient.Text = "Existing customer";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelNotInDB);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.labelCompanyVAT);
            this.panel1.Controls.Add(this.companyVATInput);
            this.panel1.Controls.Add(this.lookUpCompany);
            this.panel1.Controls.Add(this.btnBecomeMember);
            this.panel1.Controls.Add(this.labelNotCustomer);
            this.panel1.Controls.Add(this.labelAlreadyClient);
            this.panel1.Location = new System.Drawing.Point(467, 233);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(822, 396);
            this.panel1.TabIndex = 2;
            // 
            // labelNotInDB
            // 
            this.labelNotInDB.AutoSize = true;
            this.labelNotInDB.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNotInDB.ForeColor = System.Drawing.Color.Red;
            this.labelNotInDB.Location = new System.Drawing.Point(41, 256);
            this.labelNotInDB.Name = "labelNotInDB";
            this.labelNotInDB.Size = new System.Drawing.Size(221, 21);
            this.labelNotInDB.TabIndex = 6;
            this.labelNotInDB.Text = "Customer not in our database!";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.pictureBox1.Location = new System.Drawing.Point(413, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(9, 392);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // labelCompanyVAT
            // 
            this.labelCompanyVAT.AutoSize = true;
            this.labelCompanyVAT.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCompanyVAT.Location = new System.Drawing.Point(41, 155);
            this.labelCompanyVAT.Name = "labelCompanyVAT";
            this.labelCompanyVAT.Size = new System.Drawing.Size(264, 28);
            this.labelCompanyVAT.TabIndex = 5;
            this.labelCompanyVAT.Text = "VAT number of the company:";
            // 
            // companyVATInput
            // 
            this.companyVATInput.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.companyVATInput.Location = new System.Drawing.Point(41, 202);
            this.companyVATInput.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.companyVATInput.Name = "companyVATInput";
            this.companyVATInput.Size = new System.Drawing.Size(321, 34);
            this.companyVATInput.TabIndex = 4;
            // 
            // lookUpCompany
            // 
            this.lookUpCompany.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lookUpCompany.Location = new System.Drawing.Point(102, 304);
            this.lookUpCompany.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.lookUpCompany.Name = "lookUpCompany";
            this.lookUpCompany.Size = new System.Drawing.Size(170, 52);
            this.lookUpCompany.TabIndex = 3;
            this.lookUpCompany.Text = "Look up";
            this.lookUpCompany.UseVisualStyleBackColor = true;
            this.lookUpCompany.Click += new System.EventHandler(this.LookUpCustomer);
            // 
            // btnBecomeMember
            // 
            this.btnBecomeMember.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnBecomeMember.Location = new System.Drawing.Point(489, 174);
            this.btnBecomeMember.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnBecomeMember.Name = "btnBecomeMember";
            this.btnBecomeMember.Size = new System.Drawing.Size(265, 71);
            this.btnBecomeMember.TabIndex = 2;
            this.btnBecomeMember.Text = "Create";
            this.btnBecomeMember.UseVisualStyleBackColor = true;
            this.btnBecomeMember.Click += new System.EventHandler(this.BecomeCustomer);
            // 
            // labelNotCustomer
            // 
            this.labelNotCustomer.AutoSize = true;
            this.labelNotCustomer.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelNotCustomer.Location = new System.Drawing.Point(553, 71);
            this.labelNotCustomer.Name = "labelNotCustomer";
            this.labelNotCustomer.Size = new System.Drawing.Size(137, 28);
            this.labelNotCustomer.TabIndex = 1;
            this.labelNotCustomer.Text = "New customer";
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // panelMember
            // 
            this.panelMember.Controls.Add(this.panel1);
            this.panelMember.Location = new System.Drawing.Point(1, 1);
            this.panelMember.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelMember.Name = "panelMember";
            this.panelMember.Size = new System.Drawing.Size(1664, 774);
            this.panelMember.TabIndex = 3;
            // 
            // CatalogMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1664, 775);
            this.Controls.Add(this.panelMember);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "CatalogMember";
            this.Text = "CatalogueMember";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMember.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelAlreadyClient;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBecomeMember;
        private System.Windows.Forms.Label labelNotCustomer;
        private System.Windows.Forms.Button lookUpCompany;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label labelCompanyVAT;
        private System.Windows.Forms.TextBox companyVATInput;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Panel panelMember;
        private System.Windows.Forms.Label labelNotInDB;
    }
}