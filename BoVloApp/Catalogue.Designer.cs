
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
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.couleurFIxe = new System.Windows.Forms.TextBox();
            this.picture = new System.Windows.Forms.PictureBox();
            this.btn = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.nbreAjout = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // panier
            // 
            this.panier.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panier.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panier.Location = new System.Drawing.Point(1644, 45);
            this.panier.Name = "panier";
            this.panier.Size = new System.Drawing.Size(123, 50);
            this.panier.TabIndex = 0;
            this.panier.Text = "Panier";
            this.panier.UseVisualStyleBackColor = false;
            this.panier.Click += new System.EventHandler(this.button1_Click);
            // 
            // veloType
            // 
            this.veloType.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.veloType.Location = new System.Drawing.Point(997, 53);
            this.veloType.Name = "veloType";
            this.veloType.Size = new System.Drawing.Size(91, 42);
            this.veloType.TabIndex = 1;
            this.veloType.Text = "Ville";
            this.veloType.UseVisualStyleBackColor = true;
            this.veloType.Click += new System.EventHandler(this.button2_Click);
            // 
            // nextVelo
            // 
            this.nextVelo.Location = new System.Drawing.Point(1084, 53);
            this.nextVelo.Name = "nextVelo";
            this.nextVelo.Size = new System.Drawing.Size(60, 42);
            this.nextVelo.TabIndex = 2;
            this.nextVelo.Text = "-->";
            this.nextVelo.UseVisualStyleBackColor = true;
            this.nextVelo.Click += new System.EventHandler(this.button3_Click);
            // 
            // preVelo
            // 
            this.preVelo.Location = new System.Drawing.Point(940, 53);
            this.preVelo.Name = "preVelo";
            this.preVelo.Size = new System.Drawing.Size(60, 42);
            this.preVelo.TabIndex = 3;
            this.preVelo.Text = "<--";
            this.preVelo.UseVisualStyleBackColor = true;
            this.preVelo.Click += new System.EventHandler(this.button4_Click);
            // 
            // prixFixe
            // 
            this.prixFixe.Location = new System.Drawing.Point(1521, 221);
            this.prixFixe.Name = "prixFixe";
            this.prixFixe.Size = new System.Drawing.Size(48, 27);
            this.prixFixe.TabIndex = 5;
            this.prixFixe.Text = "Prix:";
            this.prixFixe.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // prix
            // 
            this.prix.Location = new System.Drawing.Point(1521, 254);
            this.prix.Name = "prix";
            this.prix.Size = new System.Drawing.Size(48, 27);
            this.prix.TabIndex = 6;
            this.prix.Text = "500E";
            this.prix.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tailleFixe
            // 
            this.tailleFixe.Location = new System.Drawing.Point(1521, 314);
            this.tailleFixe.Name = "tailleFixe";
            this.tailleFixe.Size = new System.Drawing.Size(54, 27);
            this.tailleFixe.TabIndex = 7;
            this.tailleFixe.Text = "Taille:";
            this.tailleFixe.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // btn27
            // 
            this.btn27.Location = new System.Drawing.Point(1521, 347);
            this.btn27.Name = "btn27";
            this.btn27.Size = new System.Drawing.Size(41, 34);
            this.btn27.TabIndex = 8;
            this.btn27.Text = "27\"";
            this.btn27.UseVisualStyleBackColor = true;
            // 
            // btn28
            // 
            this.btn28.Location = new System.Drawing.Point(1568, 347);
            this.btn28.Name = "btn28";
            this.btn28.Size = new System.Drawing.Size(41, 34);
            this.btn28.TabIndex = 9;
            this.btn28.Text = "28\"";
            this.btn28.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.Red;
            this.button7.ForeColor = System.Drawing.Color.Red;
            this.button7.Location = new System.Drawing.Point(1521, 447);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(24, 23);
            this.button7.TabIndex = 10;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.Aqua;
            this.button8.Location = new System.Drawing.Point(1551, 447);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(24, 23);
            this.button8.TabIndex = 11;
            this.button8.UseVisualStyleBackColor = false;
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.Desktop;
            this.button9.Location = new System.Drawing.Point(1581, 447);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(24, 23);
            this.button9.TabIndex = 12;
            this.button9.UseVisualStyleBackColor = false;
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.Lime;
            this.button10.Location = new System.Drawing.Point(1611, 447);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(24, 23);
            this.button10.TabIndex = 13;
            this.button10.UseVisualStyleBackColor = false;
            // 
            // couleurFIxe
            // 
            this.couleurFIxe.Location = new System.Drawing.Point(1521, 414);
            this.couleurFIxe.Name = "couleurFIxe";
            this.couleurFIxe.Size = new System.Drawing.Size(125, 27);
            this.couleurFIxe.TabIndex = 14;
            this.couleurFIxe.Text = "Couleur";
            this.couleurFIxe.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // picture
            // 
            this.picture.Location = new System.Drawing.Point(774, 221);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(504, 380);
            this.picture.TabIndex = 15;
            this.picture.TabStop = false;
            this.picture.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn
            // 
            this.btn.Location = new System.Drawing.Point(119, 58);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(71, 39);
            this.btn.TabIndex = 16;
            this.btn.Text = "<--";
            this.btn.UseVisualStyleBackColor = true;
            this.btn.Click += new System.EventHandler(this.button11_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(1521, 564);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(135, 37);
            this.btnAjouter.TabIndex = 17;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // nbreAjout
            // 
            this.nbreAjout.Location = new System.Drawing.Point(1421, 574);
            this.nbreAjout.Name = "nbreAjout";
            this.nbreAjout.Size = new System.Drawing.Size(94, 27);
            this.nbreAjout.TabIndex = 18;
            // 
            // Catalogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1902, 1033);
            this.Controls.Add(this.nbreAjout);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.couleurFIxe);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
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
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox couleurFIxe;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.TextBox nbreAjout;
    }
}