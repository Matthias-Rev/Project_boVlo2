
namespace BoVloApp
{
    partial class GestionDeCommande
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.Title = new System.Windows.Forms.Label();
            this.backPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMargin = new System.Drawing.Size(3, 3);
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(501, 303);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(6, 0, 0, 0);
            this.panel1.Size = new System.Drawing.Size(933, 372);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(786, 58);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(123, 56);
            this.button1.TabIndex = 5;
            this.button1.Text = "Details";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(413, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(235, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Date attendue: XX-XX-XXXX";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(31, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "XXXXX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(413, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Société: XXXX";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(31, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "N° de commande:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(933, 150);
            this.panel2.TabIndex = 5;
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(359, 105);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(1123, 106);
            this.Title.TabIndex = 6;
            this.Title.Text = "Gestion de commande de vélo";
            // 
            // backPanel
            // 
            this.backPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backPanel.Location = new System.Drawing.Point(0, 0);
            this.backPanel.Name = "backPanel";
            this.backPanel.Size = new System.Drawing.Size(2586, 1466);
            this.backPanel.TabIndex = 7;
            // 
            // GestionDeCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(2586, 1466);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.backPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GestionDeCommande";
            this.Text = "GestionDeCommande";
            this.Load += new System.EventHandler(this.GestionDeCommande_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel backPanel;
    }
}