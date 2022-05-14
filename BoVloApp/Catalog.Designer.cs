
namespace BoVloApp
{
    partial class Catalog
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
            this.basketBtn = new System.Windows.Forms.Button();
            this.veloType = new System.Windows.Forms.Button();
            this.nextVelo = new System.Windows.Forms.Button();
            this.preVelo = new System.Windows.Forms.Button();
            this.picture = new System.Windows.Forms.PictureBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelPriceBike = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.labelColour = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.BackPanel = new System.Windows.Forms.Panel();
            this.color_combobox = new System.Windows.Forms.ComboBox();
            this.size_combobox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.BackPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // basketBtn
            // 
            this.basketBtn.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.basketBtn.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.basketBtn.Location = new System.Drawing.Point(1438, 34);
            this.basketBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.basketBtn.Name = "basketBtn";
            this.basketBtn.Size = new System.Drawing.Size(108, 38);
            this.basketBtn.TabIndex = 0;
            this.basketBtn.Text = "Basket";
            this.basketBtn.UseVisualStyleBackColor = false;
            this.basketBtn.Click += new System.EventHandler(this.GoToBasket);
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
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(1331, 408);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(121, 33);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.AddBtn);
            // 
            // inputBox
            // 
            this.inputBox.Location = new System.Drawing.Point(1242, 414);
            this.inputBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(83, 23);
            this.inputBox.TabIndex = 18;
            this.inputBox.TextChanged += new System.EventHandler(this.InputBoxColorChange);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Location = new System.Drawing.Point(1328, 205);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(53, 15);
            this.labelPrice.TabIndex = 29;
            this.labelPrice.Text = "Price (€):";
            // 
            // labelPriceBike
            // 
            this.labelPriceBike.AutoSize = true;
            this.labelPriceBike.Location = new System.Drawing.Point(1381, 205);
            this.labelPriceBike.Name = "labelPriceBike";
            this.labelPriceBike.Size = new System.Drawing.Size(41, 15);
            this.labelPriceBike.TabIndex = 30;
            this.labelPriceBike.Text = "(price)";
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Location = new System.Drawing.Point(1331, 243);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(30, 15);
            this.labelSize.TabIndex = 31;
            this.labelSize.Text = "Size:";
            // 
            // labelColour
            // 
            this.labelColour.AutoSize = true;
            this.labelColour.Location = new System.Drawing.Point(1331, 320);
            this.labelColour.Name = "labelColour";
            this.labelColour.Size = new System.Drawing.Size(46, 15);
            this.labelColour.TabIndex = 32;
            this.labelColour.Text = "Colour:";
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
            this.BackPanel.Controls.Add(this.labelColour);
            this.BackPanel.Controls.Add(this.labelSize);
            this.BackPanel.Controls.Add(this.labelPriceBike);
            this.BackPanel.Controls.Add(this.labelPrice);
            this.BackPanel.Controls.Add(this.inputBox);
            this.BackPanel.Controls.Add(this.btnAdd);
            this.BackPanel.Controls.Add(this.picture);
            this.BackPanel.Controls.Add(this.preVelo);
            this.BackPanel.Controls.Add(this.nextVelo);
            this.BackPanel.Controls.Add(this.veloType);
            this.BackPanel.Controls.Add(this.basketBtn);
            this.BackPanel.Location = new System.Drawing.Point(-1, 1);
            this.BackPanel.Name = "BackPanel";
            this.BackPanel.Size = new System.Drawing.Size(1701, 823);
            this.BackPanel.TabIndex = 40;
            // 
            // color_combobox
            // 
            this.color_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.color_combobox.FormattingEnabled = true;
            this.color_combobox.Items.AddRange(new object[] {
            "27",
            "28"});
            this.color_combobox.Location = new System.Drawing.Point(1332, 338);
            this.color_combobox.Name = "color_combobox";
            this.color_combobox.Size = new System.Drawing.Size(121, 23);
            this.color_combobox.TabIndex = 39;
            this.color_combobox.SelectedIndexChanged += new System.EventHandler(this.color_combobox_SelectedIndexChanged);
            // 
            // size_combobox
            // 
            this.size_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.size_combobox.FormattingEnabled = true;
            this.size_combobox.Items.AddRange(new object[] {
            "27",
            "28"});
            this.size_combobox.Location = new System.Drawing.Point(1332, 261);
            this.size_combobox.Name = "size_combobox";
            this.size_combobox.Size = new System.Drawing.Size(121, 23);
            this.size_combobox.TabIndex = 38;
            // 
            // Catalogue
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1684, 791);
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

        private System.Windows.Forms.Button basketBtn;
        private System.Windows.Forms.Button veloType;
        private System.Windows.Forms.Button nextVelo;
        private System.Windows.Forms.Button preVelo;
        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelPriceBike;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label labelColour;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel BackPanel;
        private System.Windows.Forms.ComboBox color_combobox;
        private System.Windows.Forms.ComboBox size_combobox;
    }
}