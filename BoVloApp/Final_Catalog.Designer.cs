
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
            this.labelVAT = new System.Windows.Forms.Label();
            this.VATInput = new System.Windows.Forms.TextBox();
            this.labelAddress = new System.Windows.Forms.Label();
            this.addressInput = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.labelEmail = new System.Windows.Forms.Label();
            this.emailInput = new System.Windows.Forms.TextBox();
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
            // labelVAT
            // 
            this.labelVAT.AutoSize = true;
            this.labelVAT.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelVAT.Location = new System.Drawing.Point(139, 160);
            this.labelVAT.Name = "labelVAT";
            this.labelVAT.Size = new System.Drawing.Size(173, 37);
            this.labelVAT.TabIndex = 2;
            this.labelVAT.Text = "VAT number :";
            // 
            // VATInput
            // 
            this.VATInput.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VATInput.Location = new System.Drawing.Point(139, 220);
            this.VATInput.Name = "VATInput";
            this.VATInput.Size = new System.Drawing.Size(1397, 43);
            this.VATInput.TabIndex = 3;
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
            // labelEmail
            // 
            this.labelEmail.AutoSize = true;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelEmail.Location = new System.Drawing.Point(139, 432);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(106, 37);
            this.labelEmail.TabIndex = 7;
            this.labelEmail.Text = "E-mail :";
            // 
            // emailInput
            // 
            this.emailInput.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.emailInput.Location = new System.Drawing.Point(139, 503);
            this.emailInput.Name = "emailInput";
            this.emailInput.Size = new System.Drawing.Size(1397, 43);
            this.emailInput.TabIndex = 6;
            // 
            // panelFinal
            // 
            this.panelFinal.Controls.Add(this.emailInput);
            this.panelFinal.Controls.Add(this.labelEmail);
            this.panelFinal.Controls.Add(this.btnSubmit);
            this.panelFinal.Controls.Add(this.addressInput);
            this.panelFinal.Controls.Add(this.labelAddress);
            this.panelFinal.Controls.Add(this.VATInput);
            this.panelFinal.Controls.Add(this.labelVAT);
            this.panelFinal.Controls.Add(this.companyNameInput);
            this.panelFinal.Controls.Add(this.labelCompanyName);
            this.panelFinal.Location = new System.Drawing.Point(0, 0);
            this.panelFinal.Name = "panelFinal";
            this.panelFinal.Size = new System.Drawing.Size(1664, 774);
            this.panelFinal.TabIndex = 9;
            // 
            // Final_Catalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.panelFinal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Final_Catalog";
            this.Text = "Final_Catalogue";
            this.panelFinal.ResumeLayout(false);
            this.panelFinal.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelCompanyName;
        private System.Windows.Forms.TextBox companyNameInput;
        private System.Windows.Forms.Label labelVAT;
        private System.Windows.Forms.TextBox VATInput;
        private System.Windows.Forms.Label labelAddress;
        private System.Windows.Forms.TextBox addressInput;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label labelEmail;
        private System.Windows.Forms.TextBox emailInput;
        private System.Windows.Forms.Panel panelFinal;
    }
}