
namespace BoVloApp
{
    partial class StockVélo
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
            this.label1 = new System.Windows.Forms.Label();
            this.Taille = new System.Windows.Forms.ComboBox();
            this.Couleur = new System.Windows.Forms.ComboBox();
            this.Modèle = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(671, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(438, 106);
            this.label1.TabIndex = 0;
            this.label1.Text = "Stock vélos";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Taille
            // 
            this.Taille.FormattingEnabled = true;
            this.Taille.Location = new System.Drawing.Point(840, 280);
            this.Taille.Name = "Taille";
            this.Taille.Size = new System.Drawing.Size(182, 33);
            this.Taille.TabIndex = 3;
            // 
            // Couleur
            // 
            this.Couleur.FormattingEnabled = true;
            this.Couleur.Location = new System.Drawing.Point(1103, 280);
            this.Couleur.Name = "Couleur";
            this.Couleur.Size = new System.Drawing.Size(182, 33);
            this.Couleur.TabIndex = 6;
            // 
            // Modèle
            // 
            this.Modèle.FormattingEnabled = true;
            this.Modèle.Location = new System.Drawing.Point(1349, 280);
            this.Modèle.Name = "Modèle";
            this.Modèle.Size = new System.Drawing.Size(182, 33);
            this.Modèle.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(229, 260);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 50);
            this.button1.TabIndex = 8;
            this.button1.Text = "Pièces";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.Location = new System.Drawing.Point(439, 260);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 50);
            this.button2.TabIndex = 9;
            this.button2.Text = "Vélos";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(229, 421);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1368, 516);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // StockVélo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1898, 1024);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Modèle);
            this.Controls.Add(this.Couleur);
            this.Controls.Add(this.Taille);
            this.Controls.Add(this.label1);
            this.Name = "StockVélo";
            this.Text = "StockPiece";
            this.Load += new System.EventHandler(this.StockPiece_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox Taille;
        private System.Windows.Forms.ComboBox Couleur;
        private System.Windows.Forms.ComboBox Modèle;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}