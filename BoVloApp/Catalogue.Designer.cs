
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
            this.picture = new System.Windows.Forms.PictureBox();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.nbreAjout = new System.Windows.Forms.TextBox();
            this.labelPrix = new System.Windows.Forms.Label();
            this.labelPrixVelo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.size = new System.Windows.Forms.ComboBox();
            this.colourCIty = new System.Windows.Forms.ComboBox();
            this.BackPanel = new System.Windows.Forms.Panel();
            this.AdevntureColour = new System.Windows.Forms.ComboBox();
            this.explorer_colour = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.BackPanel.SuspendLayout();
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
            // BackPanel
            // 
            this.BackPanel.Controls.Add(this.AdevntureColour);
            this.BackPanel.Controls.Add(this.explorer_colour);
            this.BackPanel.Controls.Add(this.colourCIty);
            this.BackPanel.Controls.Add(this.size);
            this.BackPanel.Controls.Add(this.labelColor);
            this.BackPanel.Controls.Add(this.label2);
            this.BackPanel.Controls.Add(this.labelPrixVelo);
            this.BackPanel.Controls.Add(this.labelPrix);
            this.BackPanel.Controls.Add(this.nbreAjout);
            this.BackPanel.Controls.Add(this.btnAjouter);
            this.BackPanel.Controls.Add(this.picture);
            this.BackPanel.Controls.Add(this.preVelo);
            this.BackPanel.Controls.Add(this.nextVelo);
            this.BackPanel.Controls.Add(this.veloType);
            this.BackPanel.Controls.Add(this.panier);
            this.BackPanel.Location = new System.Drawing.Point(-1, 1);
            this.BackPanel.Name = "BackPanel";
            this.BackPanel.Size = new System.Drawing.Size(1701, 823);
            this.BackPanel.TabIndex = 40;
            // 
            // AdevntureColour
            // 
            this.AdevntureColour.FormattingEnabled = true;
            this.AdevntureColour.Items.AddRange(new object[] {
            "White",
            "Black",
            "Blue"});
            this.AdevntureColour.Location = new System.Drawing.Point(1332, 338);
            this.AdevntureColour.Name = "AdevntureColour";
            this.AdevntureColour.Size = new System.Drawing.Size(121, 23);
            this.AdevntureColour.TabIndex = 41;
            this.AdevntureColour.Visible = false;
            this.AdevntureColour.SelectedIndexChanged += new System.EventHandler(this.AdevntureColour_SelectedIndexChanged);
            // 
            // explorer_colour
            // 
            this.explorer_colour.FormattingEnabled = true;
            this.explorer_colour.Items.AddRange(new object[] {
            "White",
            "Black",
            "Blue"});
            this.explorer_colour.Location = new System.Drawing.Point(1331, 338);
            this.explorer_colour.Name = "explorer_colour";
            this.explorer_colour.Size = new System.Drawing.Size(121, 23);
            this.explorer_colour.TabIndex = 40;
            this.explorer_colour.Visible = false;
            this.explorer_colour.SelectedIndexChanged += new System.EventHandler(this.explorer_colour_SelectedIndexChanged);
            // 
            // Catalogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1699, 825);
            this.Controls.Add(this.BackPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Catalogue";
            this.Text = "Catalogue";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.BackPanel.ResumeLayout(false);
            this.BackPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button panier;
        private System.Windows.Forms.Button veloType;
        private System.Windows.Forms.Button nextVelo;
        private System.Windows.Forms.Button preVelo;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Button btnAjouter;
        private System.Windows.Forms.TextBox nbreAjout;
        private System.Windows.Forms.Label labelPrix;
        private System.Windows.Forms.Label labelPrixVelo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ComboBox size;
        private System.Windows.Forms.ComboBox colourCIty;
        private System.Windows.Forms.Panel BackPanel;
        private System.Windows.Forms.ComboBox explorer_colour;
        private System.Windows.Forms.ComboBox AdevntureColour;
    }
}