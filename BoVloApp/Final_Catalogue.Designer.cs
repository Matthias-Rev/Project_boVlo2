
namespace BoVloApp
{
    partial class Final_Catalogue
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
            this.name_label = new System.Windows.Forms.Label();
            this.name_textbox = new System.Windows.Forms.TextBox();
            this.VAT_label = new System.Windows.Forms.Label();
            this.VAT_textbox = new System.Windows.Forms.TextBox();
            this.address_lebel = new System.Windows.Forms.Label();
            this.address_textbox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.email_label = new System.Windows.Forms.Label();
            this.email_textbox = new System.Windows.Forms.TextBox();
            this.panelFinal = new System.Windows.Forms.Panel();
            this.panelFinal.SuspendLayout();
            this.SuspendLayout();
            // 
            // name_label
            // 
            this.name_label.AutoSize = true;
            this.name_label.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name_label.Location = new System.Drawing.Point(139, 43);
            this.name_label.Name = "name_label";
            this.name_label.Size = new System.Drawing.Size(217, 37);
            this.name_label.TabIndex = 0;
            this.name_label.Text = "Company name :";
            // 
            // name_textbox
            // 
            this.name_textbox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.name_textbox.Location = new System.Drawing.Point(139, 93);
            this.name_textbox.Name = "name_textbox";
            this.name_textbox.Size = new System.Drawing.Size(1397, 43);
            this.name_textbox.TabIndex = 1;
            this.name_textbox.TextChanged += new System.EventHandler(this.name_textbox_TextChanged);
            // 
            // VAT_label
            // 
            this.VAT_label.AutoSize = true;
            this.VAT_label.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VAT_label.Location = new System.Drawing.Point(139, 160);
            this.VAT_label.Name = "VAT_label";
            this.VAT_label.Size = new System.Drawing.Size(166, 37);
            this.VAT_label.TabIndex = 2;
            this.VAT_label.Text = "VAT number:";
            // 
            // VAT_textbox
            // 
            this.VAT_textbox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.VAT_textbox.Location = new System.Drawing.Point(139, 220);
            this.VAT_textbox.Name = "VAT_textbox";
            this.VAT_textbox.Size = new System.Drawing.Size(1397, 43);
            this.VAT_textbox.TabIndex = 3;
            this.VAT_textbox.TextChanged += new System.EventHandler(this.VAT_textbox_TextChanged);
            // 
            // address_lebel
            // 
            this.address_lebel.AutoSize = true;
            this.address_lebel.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.address_lebel.Location = new System.Drawing.Point(139, 296);
            this.address_lebel.Name = "address_lebel";
            this.address_lebel.Size = new System.Drawing.Size(117, 37);
            this.address_lebel.TabIndex = 4;
            this.address_lebel.Text = "Address:";
            // 
            // address_textbox
            // 
            this.address_textbox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.address_textbox.Location = new System.Drawing.Point(139, 359);
            this.address_textbox.Name = "address_textbox";
            this.address_textbox.Size = new System.Drawing.Size(1397, 43);
            this.address_textbox.TabIndex = 5;
            this.address_textbox.TextChanged += new System.EventHandler(this.address_textbox_TextChanged);
            // 
            // button1
            // 
            this.button1.AccessibleDescription = "";
            this.button1.AccessibleName = "button_confirm";
            this.button1.Font = new System.Drawing.Font("Segoe UI", 35F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(531, 603);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(491, 126);
            this.button1.TabIndex = 7;
            this.button1.Text = "Confirmer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // email_label
            // 
            this.email_label.AutoSize = true;
            this.email_label.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.email_label.Location = new System.Drawing.Point(139, 432);
            this.email_label.Name = "email_label";
            this.email_label.Size = new System.Drawing.Size(95, 37);
            this.email_label.TabIndex = 7;
            this.email_label.Text = "Email :";
            // 
            // email_textbox
            // 
            this.email_textbox.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.email_textbox.Location = new System.Drawing.Point(139, 503);
            this.email_textbox.Name = "email_textbox";
            this.email_textbox.Size = new System.Drawing.Size(1397, 43);
            this.email_textbox.TabIndex = 6;
            this.email_textbox.TextChanged += new System.EventHandler(this.email_textbox_TextChanged);
            // 
            // panelFinal
            // 
            this.panelFinal.Controls.Add(this.email_textbox);
            this.panelFinal.Controls.Add(this.email_label);
            this.panelFinal.Controls.Add(this.button1);
            this.panelFinal.Controls.Add(this.address_textbox);
            this.panelFinal.Controls.Add(this.address_lebel);
            this.panelFinal.Controls.Add(this.VAT_textbox);
            this.panelFinal.Controls.Add(this.VAT_label);
            this.panelFinal.Controls.Add(this.name_textbox);
            this.panelFinal.Controls.Add(this.name_label);
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

        private System.Windows.Forms.Label name_label;
        private System.Windows.Forms.TextBox name_textbox;
        private System.Windows.Forms.Label VAT_label;
        private System.Windows.Forms.TextBox VAT_textbox;
        private System.Windows.Forms.Label address_lebel;
        private System.Windows.Forms.TextBox address_textbox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label email_label;
        private System.Windows.Forms.TextBox email_textbox;
        private System.Windows.Forms.Panel panelFinal;
    }
}