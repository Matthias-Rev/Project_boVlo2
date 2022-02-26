
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
            this.btn27 = new System.Windows.Forms.Button();
            this.btn28 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.picture = new System.Windows.Forms.PictureBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.nbreAjout = new System.Windows.Forms.TextBox();
            this.turquoise = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.labelPrix = new System.Windows.Forms.Label();
            this.labelPrixVelo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // panier
            // 
            this.panier.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.panier.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panier.Location = new System.Drawing.Point(1643, 45);
            this.panier.Name = "panier";
            this.panier.Size = new System.Drawing.Size(123, 51);
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
            this.veloType.Size = new System.Drawing.Size(166, 44);
            this.veloType.TabIndex = 1;
            this.veloType.Text = "City";
            this.veloType.UseVisualStyleBackColor = true;
            // 
            // nextVelo
            // 
            this.nextVelo.Location = new System.Drawing.Point(1158, 53);
            this.nextVelo.Name = "nextVelo";
            this.nextVelo.Size = new System.Drawing.Size(59, 43);
            this.nextVelo.TabIndex = 2;
            this.nextVelo.Text = "-->";
            this.nextVelo.UseVisualStyleBackColor = true;
            this.nextVelo.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // preVelo
            // 
            this.preVelo.Location = new System.Drawing.Point(939, 53);
            this.preVelo.Name = "preVelo";
            this.preVelo.Size = new System.Drawing.Size(59, 43);
            this.preVelo.TabIndex = 3;
            this.preVelo.Text = "<--";
            this.preVelo.UseVisualStyleBackColor = true;
            this.preVelo.Click += new System.EventHandler(this.buttonPre_Click);
            // 
            // btn27
            // 
            this.btn27.Location = new System.Drawing.Point(1521, 347);
            this.btn27.Name = "btn27";
            this.btn27.Size = new System.Drawing.Size(41, 35);
            this.btn27.TabIndex = 8;
            this.btn27.Text = "27\"";
            this.btn27.UseVisualStyleBackColor = true;
            // 
            // btn28
            // 
            this.btn28.Location = new System.Drawing.Point(1568, 347);
            this.btn28.Name = "btn28";
            this.btn28.Size = new System.Drawing.Size(41, 35);
            this.btn28.TabIndex = 9;
            this.btn28.Text = "28\"";
            this.btn28.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(1521, 451);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(24, 27);
            this.button7.TabIndex = 10;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // picture
            // 
            this.picture.Image = global::BoVloApp.Properties.Resources.Velo_ville_cream;
            this.picture.Location = new System.Drawing.Point(752, 179);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(550, 479);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 15;
            this.picture.TabStop = false;
            this.picture.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(1521, 544);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(138, 44);
            this.btnAjouter.TabIndex = 17;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // nbreAjout
            // 
            this.nbreAjout.Location = new System.Drawing.Point(1419, 552);
            this.nbreAjout.Name = "nbreAjout";
            this.nbreAjout.Size = new System.Drawing.Size(94, 27);
            this.nbreAjout.TabIndex = 18;
            this.nbreAjout.TextChanged += new System.EventHandler(this.nbreAjout_TextChanged);
            // 
            // turquoise
            // 
            this.turquoise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.turquoise.Location = new System.Drawing.Point(1552, 451);
            this.turquoise.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.turquoise.Name = "turquoise";
            this.turquoise.Size = new System.Drawing.Size(24, 27);
            this.turquoise.TabIndex = 19;
            this.turquoise.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.turquoise.UseVisualStyleBackColor = false;
            this.turquoise.Click += new System.EventHandler(this.turquoise_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.button2.Location = new System.Drawing.Point(1582, 451);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 27);
            this.button2.TabIndex = 20;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button3.Location = new System.Drawing.Point(1613, 451);
            this.button3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(24, 27);
            this.button3.TabIndex = 21;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1520, 451);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 27);
            this.button1.TabIndex = 22;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(1551, 451);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(24, 28);
            this.button4.TabIndex = 23;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button5.Location = new System.Drawing.Point(1582, 451);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(24, 29);
            this.button5.TabIndex = 24;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(1520, 451);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(24, 30);
            this.button6.TabIndex = 25;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button8.Location = new System.Drawing.Point(1551, 451);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(24, 30);
            this.button8.TabIndex = 26;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Visible = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button9.Location = new System.Drawing.Point(1580, 454);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(26, 27);
            this.button9.TabIndex = 27;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Visible = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 20);
            this.label1.TabIndex = 28;
            this.label1.Text = "label1";
            // 
            // labelPrix
            // 
            this.labelPrix.AutoSize = true;
            this.labelPrix.Location = new System.Drawing.Point(1518, 273);
            this.labelPrix.Name = "labelPrix";
            this.labelPrix.Size = new System.Drawing.Size(36, 20);
            this.labelPrix.TabIndex = 29;
            this.labelPrix.Text = "Prix:";
            // 
            // labelPrixVelo
            // 
            this.labelPrixVelo.AutoSize = true;
            this.labelPrixVelo.Location = new System.Drawing.Point(1565, 273);
            this.labelPrixVelo.Name = "labelPrixVelo";
            this.labelPrixVelo.Size = new System.Drawing.Size(41, 20);
            this.labelPrixVelo.TabIndex = 30;
            this.labelPrixVelo.Text = "500E";
            this.labelPrixVelo.Click += new System.EventHandler(this.labelPrixVelo_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1521, 324);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Taille:";
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(1521, 427);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(63, 20);
            this.labelColor.TabIndex = 32;
            this.labelColor.Text = "Couleur:";
            // 
            // Catalogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 1102);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelPrixVelo);
            this.Controls.Add(this.labelPrix);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.turquoise);
            this.Controls.Add(this.nbreAjout);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.picture);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.btn28);
            this.Controls.Add(this.btn27);
            this.Controls.Add(this.preVelo);
            this.Controls.Add(this.nextVelo);
            this.Controls.Add(this.veloType);
            this.Controls.Add(this.panier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.Button btn27;
        private System.Windows.Forms.Button btn28;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.TextBox nbreAjout;
        private System.Windows.Forms.Button turquoise;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelPrix;
        private System.Windows.Forms.Label labelPrixVelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelColor;
    }
}