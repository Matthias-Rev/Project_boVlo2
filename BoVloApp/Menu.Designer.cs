
namespace BoVloApp
{
    partial class Menu
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
            this.CATALOGUE = new System.Windows.Forms.Button();
            this.COMMANDES = new System.Windows.Forms.Button();
            this.STOCK = new System.Windows.Forms.Button();
            this.CALENDRIER = new System.Windows.Forms.Button();
            this.Titel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CATALOGUE
            // 
            this.CATALOGUE.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CATALOGUE.Location = new System.Drawing.Point(234, 143);
            this.CATALOGUE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CATALOGUE.Name = "CATALOGUE";
            this.CATALOGUE.Size = new System.Drawing.Size(350, 112);
            this.CATALOGUE.TabIndex = 0;
            this.CATALOGUE.Text = "CATALOGUE";
            this.CATALOGUE.UseVisualStyleBackColor = true;
            this.CATALOGUE.Click += new System.EventHandler(this.CATALOGUE_Click);
            // 
            // COMMANDES
            // 
            this.COMMANDES.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.COMMANDES.Location = new System.Drawing.Point(572, 267);
            this.COMMANDES.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.COMMANDES.Name = "COMMANDES";
            this.COMMANDES.Size = new System.Drawing.Size(350, 112);
            this.COMMANDES.TabIndex = 1;
            this.COMMANDES.Text = "COMMANDES";
            this.COMMANDES.UseVisualStyleBackColor = true;
            this.COMMANDES.Click += new System.EventHandler(this.COMMANDES_Click);
            // 
            // STOCK
            // 
            this.STOCK.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.STOCK.Location = new System.Drawing.Point(628, 154);
            this.STOCK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.STOCK.Name = "STOCK";
            this.STOCK.Size = new System.Drawing.Size(350, 112);
            this.STOCK.TabIndex = 2;
            this.STOCK.Text = "STOCK";
            this.STOCK.UseVisualStyleBackColor = true;
            this.STOCK.Click += new System.EventHandler(this.STOCK_Click);
            // 
            // CALENDRIER
            // 
            this.CALENDRIER.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CALENDRIER.Location = new System.Drawing.Point(198, 267);
            this.CALENDRIER.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CALENDRIER.Name = "CALENDRIER";
            this.CALENDRIER.Size = new System.Drawing.Size(350, 112);
            this.CALENDRIER.TabIndex = 3;
            this.CALENDRIER.Text = "CALENDRIER";
            this.CALENDRIER.UseVisualStyleBackColor = true;
            this.CALENDRIER.Click += new System.EventHandler(this.CALENDRIER_Click);
            // 
            // Titel
            // 
            this.Titel.AutoSize = true;
            this.Titel.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Titel.Location = new System.Drawing.Point(386, 530);
            this.Titel.Name = "Titel";
            this.Titel.Size = new System.Drawing.Size(199, 72);
            this.Titel.TabIndex = 4;
            this.Titel.Text = "BOVLO";
            this.Titel.Click += new System.EventHandler(this.label1_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1904, 1041);
            this.Controls.Add(this.Titel);
            this.Controls.Add(this.COMMANDES);
            this.Controls.Add(this.CALENDRIER);
            this.Controls.Add(this.STOCK);
            this.Controls.Add(this.CATALOGUE);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mainmenu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button CATALOGUE;
        private System.Windows.Forms.Button COMMANDES;
        private System.Windows.Forms.Button STOCK;
        private System.Windows.Forms.Button CALENDRIER;
        private System.Windows.Forms.Label Titel;
    }
}