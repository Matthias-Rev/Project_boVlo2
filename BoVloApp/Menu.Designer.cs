
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
            this.SuspendLayout();
            // 
            // CATALOGUE
            // 
            this.CATALOGUE.Location = new System.Drawing.Point(268, 191);
            this.CATALOGUE.Name = "CATALOGUE";
            this.CATALOGUE.Size = new System.Drawing.Size(200, 50);
            this.CATALOGUE.TabIndex = 0;
            this.CATALOGUE.Text = "CATALOGUE";
            this.CATALOGUE.UseVisualStyleBackColor = true;
            // 
            // COMMANDES
            // 
            this.COMMANDES.Location = new System.Drawing.Point(654, 356);
            this.COMMANDES.Name = "COMMANDES";
            this.COMMANDES.Size = new System.Drawing.Size(200, 50);
            this.COMMANDES.TabIndex = 1;
            this.COMMANDES.Text = "COMMANDES";
            this.COMMANDES.UseVisualStyleBackColor = true;
            this.COMMANDES.Click += new System.EventHandler(this.COMMANDES_Click);
            // 
            // STOCK
            // 
            this.STOCK.Location = new System.Drawing.Point(654, 206);
            this.STOCK.Name = "STOCK";
            this.STOCK.Size = new System.Drawing.Size(200, 50);
            this.STOCK.TabIndex = 2;
            this.STOCK.Text = "STOCK";
            this.STOCK.UseVisualStyleBackColor = true;
            // 
            // CALENDRIER
            // 
            this.CALENDRIER.Location = new System.Drawing.Point(226, 356);
            this.CALENDRIER.Name = "CALENDRIER";
            this.CALENDRIER.Size = new System.Drawing.Size(200, 50);
            this.CALENDRIER.TabIndex = 3;
            this.CALENDRIER.Text = "CALENDRIER";
            this.CALENDRIER.UseVisualStyleBackColor = true;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.COMMANDES);
            this.Controls.Add(this.CALENDRIER);
            this.Controls.Add(this.STOCK);
            this.Controls.Add(this.CATALOGUE);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mainmenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button CATALOGUE;
        private System.Windows.Forms.Button COMMANDES;
        private System.Windows.Forms.Button STOCK;
        private System.Windows.Forms.Button CALENDRIER;
    }
}