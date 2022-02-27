
namespace BoVloApp
{
    partial class Panier
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
            this.buttonFinaliser = new System.Windows.Forms.Button();
            this.buttonPlanning = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.LabelTotal = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.Label();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.CadreTaille1 = new System.Windows.Forms.RichTextBox();
            this.CadreType1 = new System.Windows.Forms.RichTextBox();
            this.CadreQuantite1 = new System.Windows.Forms.RichTextBox();
            this.CadrePrix1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox10 = new System.Windows.Forms.RichTextBox();
            this.richTextBox6 = new System.Windows.Forms.RichTextBox();
            this.richTextBox7 = new System.Windows.Forms.RichTextBox();
            this.CadreCouleur1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox8 = new System.Windows.Forms.RichTextBox();
            this.richTextBox12 = new System.Windows.Forms.RichTextBox();
            this.PanelPanier = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // buttonFinaliser
            // 
            this.buttonFinaliser.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonFinaliser.Location = new System.Drawing.Point(1520, 890);
            this.buttonFinaliser.Name = "buttonFinaliser";
            this.buttonFinaliser.Size = new System.Drawing.Size(230, 75);
            this.buttonFinaliser.TabIndex = 0;
            this.buttonFinaliser.Text = "Finaliser";
            this.buttonFinaliser.UseVisualStyleBackColor = true;
            // 
            // buttonPlanning
            // 
            this.buttonPlanning.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonPlanning.Location = new System.Drawing.Point(829, 890);
            this.buttonPlanning.Name = "buttonPlanning";
            this.buttonPlanning.Size = new System.Drawing.Size(400, 75);
            this.buttonPlanning.TabIndex = 1;
            this.buttonPlanning.Text = "Consulter Planning";
            this.buttonPlanning.UseVisualStyleBackColor = true;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(354, 890);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(275, 75);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // LabelTotal
            // 
            this.LabelTotal.AutoSize = true;
            this.LabelTotal.Font = new System.Drawing.Font("Segoe UI", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LabelTotal.Location = new System.Drawing.Point(202, 899);
            this.LabelTotal.Name = "LabelTotal";
            this.LabelTotal.Size = new System.Drawing.Size(122, 57);
            this.LabelTotal.TabIndex = 3;
            this.LabelTotal.Text = "Total:";
            this.LabelTotal.Click += new System.EventHandler(this.label1_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(861, 51);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(220, 89);
            this.Title.TabIndex = 4;
            this.Title.Text = "Panier";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(1712, 190);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(33, 615);
            this.vScrollBar1.TabIndex = 5;
            this.vScrollBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar1_Scroll);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(202, 185);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(1548, 627);
            this.richTextBox2.TabIndex = 6;
            this.richTextBox2.Text = "";
            // 
            // CadreTaille1
            // 
            this.CadreTaille1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CadreTaille1.Location = new System.Drawing.Point(462, 285);
            this.CadreTaille1.Name = "CadreTaille1";
            this.CadreTaille1.Size = new System.Drawing.Size(625, 100);
            this.CadreTaille1.TabIndex = 8;
            this.CadreTaille1.Text = "*Taille*";
            // 
            // CadreType1
            // 
            this.CadreType1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CadreType1.Location = new System.Drawing.Point(462, 185);
            this.CadreType1.Name = "CadreType1";
            this.CadreType1.Size = new System.Drawing.Size(1250, 100);
            this.CadreType1.TabIndex = 9;
            this.CadreType1.Text = "Type de vélo";
            // 
            // CadreQuantite1
            // 
            this.CadreQuantite1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CadreQuantite1.Location = new System.Drawing.Point(202, 185);
            this.CadreQuantite1.Name = "CadreQuantite1";
            this.CadreQuantite1.Size = new System.Drawing.Size(260, 125);
            this.CadreQuantite1.TabIndex = 10;
            this.CadreQuantite1.Text = "*Quantité*";
            // 
            // CadrePrix1
            // 
            this.CadrePrix1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CadrePrix1.Location = new System.Drawing.Point(202, 310);
            this.CadrePrix1.Name = "CadrePrix1";
            this.CadrePrix1.Size = new System.Drawing.Size(260, 75);
            this.CadrePrix1.TabIndex = 14;
            this.CadrePrix1.Text = "*prix/unité*";
            // 
            // richTextBox10
            // 
            this.richTextBox10.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox10.Location = new System.Drawing.Point(202, 510);
            this.richTextBox10.Name = "richTextBox10";
            this.richTextBox10.Size = new System.Drawing.Size(260, 75);
            this.richTextBox10.TabIndex = 16;
            this.richTextBox10.Text = "*prix/unité*";
            // 
            // richTextBox6
            // 
            this.richTextBox6.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox6.Location = new System.Drawing.Point(202, 385);
            this.richTextBox6.Name = "richTextBox6";
            this.richTextBox6.Size = new System.Drawing.Size(260, 125);
            this.richTextBox6.TabIndex = 17;
            this.richTextBox6.Text = "*Quantité*";
            // 
            // richTextBox7
            // 
            this.richTextBox7.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox7.Location = new System.Drawing.Point(462, 385);
            this.richTextBox7.Name = "richTextBox7";
            this.richTextBox7.Size = new System.Drawing.Size(1250, 100);
            this.richTextBox7.TabIndex = 18;
            this.richTextBox7.Text = "Type de vélo";
            // 
            // CadreCouleur1
            // 
            this.CadreCouleur1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.CadreCouleur1.Location = new System.Drawing.Point(1087, 285);
            this.CadreCouleur1.Name = "CadreCouleur1";
            this.CadreCouleur1.Size = new System.Drawing.Size(625, 100);
            this.CadreCouleur1.TabIndex = 19;
            this.CadreCouleur1.Text = "*Couleur*";
            // 
            // richTextBox8
            // 
            this.richTextBox8.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox8.Location = new System.Drawing.Point(462, 485);
            this.richTextBox8.Name = "richTextBox8";
            this.richTextBox8.Size = new System.Drawing.Size(625, 100);
            this.richTextBox8.TabIndex = 20;
            this.richTextBox8.Text = "*Taille*";
            // 
            // richTextBox12
            // 
            this.richTextBox12.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.richTextBox12.Location = new System.Drawing.Point(1087, 485);
            this.richTextBox12.Name = "richTextBox12";
            this.richTextBox12.Size = new System.Drawing.Size(625, 100);
            this.richTextBox12.TabIndex = 21;
            this.richTextBox12.Text = "*Couleur*";
            // 
            // PanelPanier
            // 
            this.PanelPanier.Location = new System.Drawing.Point(0, 0);
            this.PanelPanier.Name = "PanelPanier";
            this.PanelPanier.Size = new System.Drawing.Size(1942, 1102);
            this.PanelPanier.TabIndex = 22;
            // 
            // Panier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.richTextBox12);
            this.Controls.Add(this.richTextBox8);
            this.Controls.Add(this.CadreCouleur1);
            this.Controls.Add(this.richTextBox7);
            this.Controls.Add(this.richTextBox6);
            this.Controls.Add(this.richTextBox10);
            this.Controls.Add(this.CadrePrix1);
            this.Controls.Add(this.CadreQuantite1);
            this.Controls.Add(this.CadreType1);
            this.Controls.Add(this.CadreTaille1);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.LabelTotal);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.buttonPlanning);
            this.Controls.Add(this.buttonFinaliser);
            this.Controls.Add(this.PanelPanier);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Panier";
            this.Text = "Panier";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFinaliser;
        private System.Windows.Forms.Button buttonPlanning;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label LabelTotal;
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox CadreTaille1;
        private System.Windows.Forms.RichTextBox CadreType1;
        private System.Windows.Forms.RichTextBox CadreQuantite1;
        private System.Windows.Forms.RichTextBox CadrePrix1;
        private System.Windows.Forms.RichTextBox richTextBox10;
        private System.Windows.Forms.RichTextBox richTextBox6;
        private System.Windows.Forms.RichTextBox richTextBox7;
        private System.Windows.Forms.RichTextBox CadreCouleur1;
        private System.Windows.Forms.RichTextBox richTextBox8;
        private System.Windows.Forms.RichTextBox richTextBox12;
        private System.Windows.Forms.Panel PanelPanier;
    }
}