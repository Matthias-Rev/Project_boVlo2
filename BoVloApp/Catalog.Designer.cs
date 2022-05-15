
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
            this.btnAdd = new System.Windows.Forms.Button();
            this.inputBox = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelPriceBike = new System.Windows.Forms.Label();
            this.labelSize = new System.Windows.Forms.Label();
            this.labelColor = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.BackPanel = new System.Windows.Forms.Panel();
            this.label_quantity = new System.Windows.Forms.Label();
            this.color_combobox = new System.Windows.Forms.ComboBox();
            this.size_combobox = new System.Windows.Forms.ComboBox();
            this.BackPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // basketBtn
            // 
            this.basketBtn.BackColor = System.Drawing.SystemColors.Control;
            this.basketBtn.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.basketBtn.Location = new System.Drawing.Point(1438, 34);
            this.basketBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.basketBtn.Name = "basketBtn";
            this.basketBtn.Size = new System.Drawing.Size(181, 70);
            this.basketBtn.TabIndex = 0;
            this.basketBtn.Text = "Basket";
            this.basketBtn.UseVisualStyleBackColor = false;
            this.basketBtn.Click += new System.EventHandler(this.GoToBasket);
            // 
            // veloType
            // 
            this.veloType.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.veloType.Location = new System.Drawing.Point(796, 40);
            this.veloType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.veloType.Name = "veloType";
            this.veloType.Size = new System.Drawing.Size(388, 55);
            this.veloType.TabIndex = 1;
            this.veloType.Text = "City";
            this.veloType.UseVisualStyleBackColor = true;
            // 
            // nextVelo
            // 
            this.nextVelo.Location = new System.Drawing.Point(1175, 40);
            this.nextVelo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.nextVelo.Name = "nextVelo";
            this.nextVelo.Size = new System.Drawing.Size(88, 55);
            this.nextVelo.TabIndex = 2;
            this.nextVelo.Text = "-->";
            this.nextVelo.UseVisualStyleBackColor = true;
            this.nextVelo.Click += new System.EventHandler(this.buttonNext_Click);
            // 
            // preVelo
            // 
            this.preVelo.Location = new System.Drawing.Point(715, 40);
            this.preVelo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.preVelo.Name = "preVelo";
            this.preVelo.Size = new System.Drawing.Size(88, 55);
            this.preVelo.TabIndex = 3;
            this.preVelo.Text = "<--";
            this.preVelo.UseVisualStyleBackColor = true;
            this.preVelo.Click += new System.EventHandler(this.buttonPre_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnAdd.Location = new System.Drawing.Point(1044, 499);
            this.btnAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(197, 100);
            this.btnAdd.TabIndex = 17;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.AddBtn);
            // 
            // inputBox
            // 
            this.inputBox.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.inputBox.Location = new System.Drawing.Point(739, 514);
            this.inputBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.inputBox.Name = "inputBox";
            this.inputBox.Size = new System.Drawing.Size(264, 50);
            this.inputBox.TabIndex = 18;
            this.inputBox.TextChanged += new System.EventHandler(this.InputBoxColorChange);
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPrice.Location = new System.Drawing.Point(782, 146);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(209, 45);
            this.labelPrice.TabIndex = 29;
            this.labelPrice.Text = "Price (€/unit):";
            // 
            // labelPriceBike
            // 
            this.labelPriceBike.AutoSize = true;
            this.labelPriceBike.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelPriceBike.Location = new System.Drawing.Point(1013, 146);
            this.labelPriceBike.Name = "labelPriceBike";
            this.labelPriceBike.Size = new System.Drawing.Size(110, 45);
            this.labelPriceBike.TabIndex = 30;
            this.labelPriceBike.Text = "(price)";
            // 
            // labelSize
            // 
            this.labelSize.AutoSize = true;
            this.labelSize.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelSize.Location = new System.Drawing.Point(822, 240);
            this.labelSize.Name = "labelSize";
            this.labelSize.Size = new System.Drawing.Size(83, 45);
            this.labelSize.TabIndex = 31;
            this.labelSize.Text = "Size:";
            // 
            // labelColor
            // 
            this.labelColor.AutoSize = true;
            this.labelColor.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelColor.Location = new System.Drawing.Point(770, 338);
            this.labelColor.Name = "labelColor";
            this.labelColor.Size = new System.Drawing.Size(104, 45);
            this.labelColor.TabIndex = 32;
            this.labelColor.Text = "Color:";
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // BackPanel
            // 
            this.BackPanel.Controls.Add(this.label_quantity);
            this.BackPanel.Controls.Add(this.color_combobox);
            this.BackPanel.Controls.Add(this.size_combobox);
            this.BackPanel.Controls.Add(this.labelColor);
            this.BackPanel.Controls.Add(this.labelSize);
            this.BackPanel.Controls.Add(this.labelPriceBike);
            this.BackPanel.Controls.Add(this.labelPrice);
            this.BackPanel.Controls.Add(this.inputBox);
            this.BackPanel.Controls.Add(this.btnAdd);
            this.BackPanel.Controls.Add(this.preVelo);
            this.BackPanel.Controls.Add(this.nextVelo);
            this.BackPanel.Controls.Add(this.veloType);
            this.BackPanel.Controls.Add(this.basketBtn);
            this.BackPanel.Location = new System.Drawing.Point(-1, 1);
            this.BackPanel.Name = "BackPanel";
            this.BackPanel.Size = new System.Drawing.Size(1701, 823);
            this.BackPanel.TabIndex = 40;
            // 
            // label_quantity
            // 
            this.label_quantity.AutoSize = true;
            this.label_quantity.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_quantity.Location = new System.Drawing.Point(541, 519);
            this.label_quantity.Name = "label_quantity";
            this.label_quantity.Size = new System.Drawing.Size(148, 45);
            this.label_quantity.TabIndex = 40;
            this.label_quantity.Text = "Quantity:";
            // 
            // color_combobox
            // 
            this.color_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.color_combobox.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.color_combobox.FormattingEnabled = true;
            this.color_combobox.Items.AddRange(new object[] {
            "27",
            "28"});
            this.color_combobox.Location = new System.Drawing.Point(923, 338);
            this.color_combobox.Name = "color_combobox";
            this.color_combobox.Size = new System.Drawing.Size(293, 53);
            this.color_combobox.TabIndex = 39;
            // 
            // size_combobox
            // 
            this.size_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.size_combobox.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.size_combobox.FormattingEnabled = true;
            this.size_combobox.Items.AddRange(new object[] {
            "27",
            "28"});
            this.size_combobox.Location = new System.Drawing.Point(912, 240);
            this.size_combobox.Name = "size_combobox";
            this.size_combobox.Size = new System.Drawing.Size(153, 53);
            this.size_combobox.TabIndex = 38;
            // 
            // Catalog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1684, 791);
            this.Controls.Add(this.BackPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Catalog";
            this.Text = "Catalogue";
            this.BackPanel.ResumeLayout(false);
            this.BackPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button basketBtn;
        private System.Windows.Forms.Button veloType;
        private System.Windows.Forms.Button nextVelo;
        private System.Windows.Forms.Button preVelo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox inputBox;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelPriceBike;
        private System.Windows.Forms.Label labelSize;
        private System.Windows.Forms.Label labelColor;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Panel BackPanel;
        private System.Windows.Forms.ComboBox color_combobox;
        private System.Windows.Forms.ComboBox size_combobox;
        private System.Windows.Forms.Label label_quantity;
    }
}