
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
            this.BackPanel = new System.Windows.Forms.Panel();
            this.color_combobox = new System.Windows.Forms.ComboBox();
            this.size_combobox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.BackPanel.SuspendLayout();
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
            // picture
            // 
            this.picture.Image = global::BoVloApp.Properties.Resources.Velo_ville_cream;
            this.picture.Location = new System.Drawing.Point(752, 179);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(550, 479);
            this.picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picture.TabIndex = 15;
            this.picture.TabStop = false;
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
            // 
            // labelPrix
            // 
            this.labelPrix.AutoSize = true;
            this.labelPrix.Location = new System.Drawing.Point(1518, 273);
            this.labelPrix.Name = "labelPrix";
            this.labelPrix.Size = new System.Drawing.Size(58, 20);
            this.labelPrix.TabIndex = 29;
            this.labelPrix.Text = "Prix (€):";
            this.labelPrix.Click += new System.EventHandler(this.labelPrix_Click);
            // 
            // labelPrixVelo
            // 
            this.labelPrixVelo.AutoSize = true;
            this.labelPrixVelo.Location = new System.Drawing.Point(1578, 273);
            this.labelPrixVelo.Name = "labelPrixVelo";
            this.labelPrixVelo.Size = new System.Drawing.Size(52, 20);
            this.labelPrixVelo.TabIndex = 30;
            this.labelPrixVelo.Text = "(price)";
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
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // BackPanel
            // 
            this.BackPanel.Controls.Add(this.color_combobox);
            this.BackPanel.Controls.Add(this.size_combobox);
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
            this.BackPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.BackPanel.Name = "BackPanel";
            this.BackPanel.Size = new System.Drawing.Size(1944, 1097);
            this.BackPanel.TabIndex = 40;
            // 
            // color_combobox
            // 
            this.color_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.color_combobox.FormattingEnabled = true;
            this.color_combobox.Items.AddRange(new object[] {
            "27",
            "28"});
            this.color_combobox.Location = new System.Drawing.Point(1522, 451);
            this.color_combobox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.color_combobox.Name = "color_combobox";
            this.color_combobox.Size = new System.Drawing.Size(138, 28);
            this.color_combobox.TabIndex = 39;
            // 
            // size_combobox
            // 
            this.size_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.size_combobox.FormattingEnabled = true;
            this.size_combobox.Items.AddRange(new object[] {
            "27",
            "28"});
            this.size_combobox.Location = new System.Drawing.Point(1522, 348);
            this.size_combobox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.size_combobox.Name = "size_combobox";
            this.size_combobox.Size = new System.Drawing.Size(138, 28);
            this.size_combobox.TabIndex = 38;
            // 
            // Catalogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1055);
            this.Controls.Add(this.BackPanel);
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
        private System.Windows.Forms.Panel BackPanel;
        private System.Windows.Forms.ComboBox color_combobox;
        private System.Windows.Forms.ComboBox size_combobox;
    }
}