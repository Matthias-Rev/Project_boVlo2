
namespace BoVloApp
{
    partial class Final_Catalog
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
            this.labelCompanyName = new System.Windows.Forms.Label();
            this.companyNameInput = new System.Windows.Forms.TextBox();
            this.labelTVA = new System.Windows.Forms.Label();
            this.tvaInput = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.addressInput = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.labelContact = new System.Windows.Forms.Label();
            this.contactInput = new System.Windows.Forms.TextBox();
            this.panelFinal = new System.Windows.Forms.Panel();
            this.panelFinal.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelCompanyName
            // 
            this.labelCompanyName.AutoSize = true;
            this.labelCompanyName.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelCompanyName.Location = new System.Drawing.Point(139, 43);
            this.labelCompanyName.Name = "labelCompanyName";
            this.labelCompanyName.Size = new System.Drawing.Size(215, 37);
            this.labelCompanyName.TabIndex = 0;
            this.labelCompanyName.Text = "Company Name:";
            // 
            // companyNameInput
            // 
            this.companyNameInput.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.companyNameInput.Location = new System.Drawing.Point(139, 93);
            this.companyNameInput.Name = "companyNameInput";
            this.companyNameInput.Size = new System.Drawing.Size(1397, 43);
            this.companyNameInput.TabIndex = 1;
            // 
            // labelTVA
            // 
            this.labelTVA.AutoSize = true;
            this.labelTVA.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTVA.Location = new System.Drawing.Point(139, 160);
            this.labelTVA.Name = "labelTVA";
            this.labelTVA.Size = new System.Drawing.Size(112, 37);
            this.labelTVA.TabIndex = 2;
            this.labelTVA.Text = "Nr. TVA:";
            // 
            // tvaInput
            // 
            this.tvaInput.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tvaInput.Location = new System.Drawing.Point(139, 220);
            this.tvaInput.Name = "tvaInput";
            this.tvaInput.Size = new System.Drawing.Size(1397, 43);
            this.tvaInput.TabIndex = 3;
            // 
            // labelAddress
            // 
            this.labelAddress.AutoSize = true;
            this.labelAddress.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelAddress.Location = new System.Drawing.Point(139, 296);
            this.labelAddress.Name = "labelAddress";
            this.labelAddress.Size = new System.Drawing.Size(117, 37);
            this.labelAddress.TabIndex = 4;
            this.labelAddress.Text = "Address:";
            // 
            // addressInput
            // 
            this.addressInput.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addressInput.Location = new System.Drawing.Point(139, 359);
            this.addressInput.Name = "addressInput";
            this.addressInput.Size = new System.Drawing.Size(1397, 43);
            this.addressInput.TabIndex = 5;
            // 
            // btnSubmit
            // 
            this.btnSubmit.AccessibleDescription = "";
            this.btnSubmit.AccessibleName = "button_confirm";
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnSubmit.Location = new System.Drawing.Point(531, 603);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(491, 126);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.SubmitBtn);
            // 
            // labelContact
            // 
            this.labelContact.AutoSize = true;
            this.labelContact.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelContact.Location = new System.Drawing.Point(139, 432);
            this.labelContact.Name = "labelContact";
            this.labelContact.Size = new System.Drawing.Size(122, 37);
            this.labelContact.TabIndex = 7;
            this.labelContact.Text = "Contact :";
            // 
            // contactInput
            // 
            this.contactInput.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.contactInput.Location = new System.Drawing.Point(139, 503);
            this.contactInput.Name = "contactInput";
            this.contactInput.Size = new System.Drawing.Size(1397, 43);
            this.contactInput.TabIndex = 6;
            // 
            // panelFinal
            // 
            this.panelFinal.Controls.Add(this.contactInput);
            this.panelFinal.Controls.Add(this.labelContact);
            this.panelFinal.Controls.Add(this.btnSubmit);
            this.panelFinal.Controls.Add(this.addressInput);
            this.panelFinal.Controls.Add(this.labelAddress);
            this.panelFinal.Controls.Add(this.tvaInput);
            this.panelFinal.Controls.Add(this.labelTVA);
            this.panelFinal.Controls.Add(this.companyNameInput);
            this.panelFinal.Controls.Add(this.labelCompanyName);
            this.panelFinal.Location = new System.Drawing.Point(0, 0);
            this.panelFinal.Name = "panelFinal";
            this.panelFinal.Size = new System.Drawing.Size(1664, 774);
            this.panelFinal.TabIndex = 9;
            // 
            // Final_Catalogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panelFinal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Final_Catalogue";
            this.Text = "Final_Catalogue";
            this.panelFinal.ResumeLayout(false);
            this.panelFinal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.TextBox companyNameInput;
        private System.Windows.Forms.Label labelTVA;
        private System.Windows.Forms.TextBox tvaInput;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox addressInput;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label labelContact;
        private System.Windows.Forms.TextBox contactInput;
        private System.Windows.Forms.Panel panelFinal;
    }
}