
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
            this.components = new System.ComponentModel.Container();
            this.panier = new System.Windows.Forms.Button();
            this.veloType = new System.Windows.Forms.Button();
            this.nextVelo = new System.Windows.Forms.Button();
            this.preVelo = new System.Windows.Forms.Button();
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
            this.labelPrix = new System.Windows.Forms.Label();
            this.labelPrixVelo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.size = new System.Windows.Forms.ComboBox();
            this.colourCIty = new System.Windows.Forms.ComboBox();
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
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.White;
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(1327, 492);
            this.button7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(21, 20);
            this.button7.TabIndex = 10;
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
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
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(1331, 408);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(121, 33);
            this.btnAjouter.TabIndex = 17;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // nbreAjout
            // 
            this.nbreAjout.Location = new System.Drawing.Point(1242, 414);
            this.nbreAjout.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nbreAjout.Name = "nbreAjout";
            this.nbreAjout.Size = new System.Drawing.Size(83, 23);
            this.nbreAjout.TabIndex = 18;
            this.nbreAjout.TextChanged += new System.EventHandler(this.nbreAjout_TextChanged);
            // 
            // turquoise
            // 
            this.turquoise.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.turquoise.Location = new System.Drawing.Point(1354, 492);
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
            this.button2.Location = new System.Drawing.Point(1380, 492);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(21, 20);
            this.button2.TabIndex = 20;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button3.Location = new System.Drawing.Point(1407, 492);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(21, 20);
            this.button3.TabIndex = 21;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(1325, 527);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(22, 20);
            this.button1.TabIndex = 22;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Visible = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Location = new System.Drawing.Point(1353, 526);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(21, 21);
            this.button4.TabIndex = 23;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Visible = false;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button5.Location = new System.Drawing.Point(1379, 525);
            this.button5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(21, 22);
            this.button5.TabIndex = 24;
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Visible = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.White;
            this.button6.Location = new System.Drawing.Point(1325, 562);
            this.button6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(21, 22);
            this.button6.TabIndex = 25;
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Visible = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button8.Location = new System.Drawing.Point(1354, 562);
            this.button8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(21, 22);
            this.button8.TabIndex = 26;
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Visible = false;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button9.Location = new System.Drawing.Point(1381, 562);
            this.button9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(23, 20);
            this.button9.TabIndex = 27;
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Visible = false;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // labelPrix
            // 
            this.labelPrix.AutoSize = true;
            this.labelPrix.Location = new System.Drawing.Point(1328, 205);
            this.labelPrix.Name = "labelPrix";
            this.labelPrix.Size = new System.Drawing.Size(30, 15);
            this.labelPrix.TabIndex = 29;
            this.labelPrix.Text = "Prix:";
            // 
            // labelPrixVelo
            // 
            this.labelPrixVelo.AutoSize = true;
            this.labelPrixVelo.Location = new System.Drawing.Point(1369, 205);
            this.labelPrixVelo.Name = "labelPrixVelo";
            this.labelPrixVelo.Size = new System.Drawing.Size(31, 15);
            this.labelPrixVelo.TabIndex = 30;
            this.labelPrixVelo.Text = "500E";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1331, 243);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 15);
            this.label2.TabIndex = 31;
            this.label2.Text = "Taille:";
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Location = new System.Drawing.Point(1331, 320);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(52, 15);
            this.labelColor.TabIndex = 32;
            this.labelColor.Text = "Couleur:";
            this.labelColor.Click += new System.EventHandler(this.labelColor_Click);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // size
            // 
            this.size.FormattingEnabled = true;
            this.size.Items.AddRange(new object[] {
            "27",
            "28"});
            this.size.Location = new System.Drawing.Point(1332, 261);
            this.size.Name = "size";
            this.size.Size = new System.Drawing.Size(121, 23);
            this.size.TabIndex = 38;
            this.size.SelectedIndexChanged += new System.EventHandler(this.size_SelectedIndexChanged);
            // 
            // colourCIty
            // 
            this.colourCIty.FormattingEnabled = true;
            this.colourCIty.Items.AddRange(new object[] {
            "White",
            "Blue",
            "Rose",
            "Green"});
            this.colourCIty.Location = new System.Drawing.Point(1332, 338);
            this.colourCIty.Name = "colourCIty";
            this.colourCIty.Size = new System.Drawing.Size(121, 23);
            this.colourCIty.TabIndex = 39;
            this.colourCIty.SelectedIndexChanged += new System.EventHandler(this.colourCIty_SelectedIndexChanged);
            // 
            // Catalogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1699, 825);
            this.Controls.Add(this.colourCIty);
            this.Controls.Add(this.size);
            this.Controls.Add(this.labelColor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelPrixVelo);
            this.Controls.Add(this.labelPrix);
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
            this.Controls.Add(this.preVelo);
            this.Controls.Add(this.nextVelo);
            this.Controls.Add(this.veloType);
            this.Controls.Add(this.panier);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
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
        private System.Windows.Forms.Label labelPrix;
        private System.Windows.Forms.Label labelPrixVelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox size;
        private System.Windows.Forms.ComboBox colourCIty;
    }
}