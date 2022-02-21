
namespace BoVloApp
{
    partial class Catalogue
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
            this.panier = new System.Windows.Forms.Button();
            this.veloType = new System.Windows.Forms.Button();
            this.nextVelo = new System.Windows.Forms.Button();
            this.preVelo = new System.Windows.Forms.Button();
            this.prixFixe = new System.Windows.Forms.TextBox();
            this.prix = new System.Windows.Forms.TextBox();
            this.tailleFixe = new System.Windows.Forms.TextBox();
            this.btn27 = new System.Windows.Forms.Button();
            this.btn28 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.couleurFIxe = new System.Windows.Forms.TextBox();
            this.picture = new System.Windows.Forms.PictureBox();
            this.btn = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.nbreAjout = new System.Windows.Forms.TextBox();
            this.turquoise = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // panier
            // 
            this.panier.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panier.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panier.Location = new System.Drawing.Point(1438, 34);
            this.panier.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panier.Name = "panier";
            this.panier.Size = new System.Drawing.Size(108, 38);
            this.panier.TabIndex = 0;
            this.panier.Text = "Panier";
            this.panier.UseVisualStyleBackColor = false;
            this.panier.Click += new System.EventHandler(this.button1_Click);
            // 
            // veloType
            // 
            this.veloType.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.veloType.Location = new System.Drawing.Point(872, 40);
            this.veloType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.veloType.Name = "veloType";
            this.veloType.Size = new System.Drawing.Size(145, 33);
            this.veloType.TabIndex = 1;
            this.veloType.Text = "City";
            this.veloType.UseVisualStyleBackColor = true;
            // 
            // nextVelo
            // 
            this.nextVelo.Location = new System.Drawing.Point(1013, 40);
            this.nextVelo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nextVelo.Name = "nextVelo";
            this.nextVelo.Size = new System.Drawing.Size(52, 32);
            this.nextVelo.TabIndex = 2;
            this.nextVelo.Text = "-->";
            this.nextVelo.UseVisualStyleBackColor = true;
            this.nextVelo.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // preVelo
            // 
            this.preVelo.Location = new System.Drawing.Point(822, 40);
            this.preVelo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.preVelo.Name = "preVelo";
            this.preVelo.Size = new System.Drawing.Size(52, 32);
            this.preVelo.TabIndex = 3;
            this.preVelo.Text = "<--";
            this.preVelo.UseVisualStyleBackColor = true;
            this.preVelo.Click += new System.EventHandler(this.buttonPre_Click);
            // 
            // prixFixe
            // 
            this.prixFixe.Location = new System.Drawing.Point(1331, 166);
            this.prixFixe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prixFixe.Name = "prixFixe";
            this.prixFixe.Size = new System.Drawing.Size(42, 23);
            this.prixFixe.TabIndex = 5;
            this.prixFixe.Text = "Prix:";
            this.prixFixe.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // prix
            // 
            this.prix.Location = new System.Drawing.Point(1331, 190);
            this.prix.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prix.Name = "prix";
            this.prix.Size = new System.Drawing.Size(42, 23);
            this.prix.TabIndex = 6;
            this.prix.Text = "500E";
            this.prix.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tailleFixe
            // 
            this.tailleFixe.Location = new System.Drawing.Point(1331, 236);
            this.tailleFixe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tailleFixe.Name = "tailleFixe";
            this.tailleFixe.Size = new System.Drawing.Size(48, 23);
            this.tailleFixe.TabIndex = 7;
            this.tailleFixe.Text = "Taille:";
            this.tailleFixe.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // btn27
            // 
            this.btn27.Location = new System.Drawing.Point(1331, 260);
            this.btn27.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn27.Name = "btn27";
            this.btn27.Size = new System.Drawing.Size(36, 26);
            this.btn27.TabIndex = 8;
            this.btn27.Text = "27\"";
            this.btn27.UseVisualStyleBackColor = true;
            // 
            // btn28
            // 
            this.btn28.Location = new System.Drawing.Point(1372, 260);
            this.btn28.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn28.Name = "btn28";
            this.btn28.Size = new System.Drawing.Size(36, 26);
            this.btn28.TabIndex = 9;
            this.btn28.Text = "28\"";
            this.btn28.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(1331, 338);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(21, 20);
            this.button7.TabIndex = 10;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // couleurFIxe
            // 
            this.couleurFIxe.Location = new System.Drawing.Point(1331, 310);
            this.couleurFIxe.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.couleurFIxe.Name = "couleurFIxe";
            this.couleurFIxe.Size = new System.Drawing.Size(110, 23);
            this.couleurFIxe.TabIndex = 14;
            this.couleurFIxe.Text = "Couleur";
            this.couleurFIxe.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // picture
            // 
            this.picture.Image = global::BoVloApp.Properties.Resources.Velo_ville_cream;
            this.picture.Location = new System.Drawing.Point(658, 134);
            this.picture.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(481, 359);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 15;
            this.picture.TabStop = false;
            this.picture.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(202, 44);
            this.btn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(62, 29);
            this.btn.TabIndex = 16;
            this.btn.Text = "<--";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.button11_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(1331, 408);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(121, 33);
            this.btnAjouter.TabIndex = 17;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // nbreAjout
            // 
            this.nbreAjout.Location = new System.Drawing.Point(1242, 414);
            this.nbreAjout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nbreAjout.Name = "nbreAjout";
            this.nbreAjout.Size = new System.Drawing.Size(83, 23);
            this.nbreAjout.TabIndex = 18;
            // 
            // turquoise
            // 
            this.turquoise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.turquoise.Location = new System.Drawing.Point(1358, 338);
            this.turquoise.Name = "turquoise";
            this.turquoise.Size = new System.Drawing.Size(21, 20);
            this.turquoise.TabIndex = 19;
            this.turquoise.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.turquoise.UseVisualStyleBackColor = false;
            this.turquoise.Click += new System.EventHandler(this.turquoise_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(1384, 338);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(21, 20);
            this.button2.TabIndex = 20;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button3.Location = new System.Drawing.Point(1411, 338);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(21, 20);
            this.button3.TabIndex = 21;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Catalogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1664, 775);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.turquoise);
            this.Controls.Add(this.nbreAjout);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.couleurFIxe);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btn28);
            this.Controls.Add(this.btn27);
            this.Controls.Add(this.tailleFixe);
            this.Controls.Add(this.prix);
            this.Controls.Add(this.prixFixe);
            this.Controls.Add(this.preVelo);
            this.Controls.Add(this.nextVelo);
            this.Controls.Add(this.veloType);
            this.Controls.Add(this.panier);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Catalogue";
            this.Text = "Catalogue";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button panier;
        private System.Windows.Forms.Button veloType;
        private System.Windows.Forms.Button nextVelo;
        private System.Windows.Forms.Button preVelo;
        private System.Windows.Forms.TextBox prixFixe;
        private System.Windows.Forms.TextBox prix;
        private System.Windows.Forms.TextBox tailleFixe;
        private System.Windows.Forms.Button btn27;
        private System.Windows.Forms.Button btn28;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox couleurFIxe;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.TextBox nbreAjout;
        private System.Windows.Forms.Button turquoise;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
    }
}