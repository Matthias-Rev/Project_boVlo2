
namespace BoVloApp
{
    partial class Stock
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
            this.title_label = new System.Windows.Forms.Label();
            this.bike_button = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.search_textbox = new System.Windows.Forms.TextBox();
            this.piece_button = new System.Windows.Forms.Button();
            this.search_button = new System.Windows.Forms.Button();
            this.type_combobox = new System.Windows.Forms.ComboBox();
            this.type_label = new System.Windows.Forms.Label();
            this.color_label = new System.Windows.Forms.Label();
            this.color_combobox = new System.Windows.Forms.ComboBox();
            this.size_label = new System.Windows.Forms.Label();
            this.size_combobox = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title_label.Location = new System.Drawing.Point(914, 43);
            this.title_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(238, 89);
            this.title_label.TabIndex = 0;
            this.title_label.Text = "Supply";
            // 
            // bike_button
            // 
            this.bike_button.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bike_button.Location = new System.Drawing.Point(689, 288);
            this.bike_button.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.bike_button.Name = "bike_button";
            this.bike_button.Size = new System.Drawing.Size(95, 43);
            this.bike_button.TabIndex = 2;
            this.bike_button.Text = "Bikes";
            this.bike_button.UseVisualStyleBackColor = true;
            this.bike_button.Click += new System.EventHandler(this.bike_button_Click);
            // 
            // search_textbox
            // 
            this.search_textbox.Location = new System.Drawing.Point(813, 248);
            this.search_textbox.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.search_textbox.Name = "search_textbox";
            this.search_textbox.Size = new System.Drawing.Size(585, 27);
            this.search_textbox.TabIndex = 4;
            // 
            // piece_button
            // 
            this.piece_button.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.piece_button.Location = new System.Drawing.Point(591, 288);
            this.piece_button.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.piece_button.Name = "piece_button";
            this.piece_button.Size = new System.Drawing.Size(95, 43);
            this.piece_button.TabIndex = 5;
            this.piece_button.Text = "Pieces";
            this.piece_button.UseVisualStyleBackColor = true;
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(1410, 248);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(117, 28);
            this.search_button.TabIndex = 6;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = true;
            // 
            // type_combobox
            // 
            this.type_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type_combobox.FormattingEnabled = true;
            this.type_combobox.Location = new System.Drawing.Point(875, 293);
            this.type_combobox.Name = "type_combobox";
            this.type_combobox.Size = new System.Drawing.Size(137, 28);
            this.type_combobox.TabIndex = 7;
            this.type_combobox.SelectedIndexChanged += new System.EventHandler(this.type_combobox_SelectedIndexChanged);
            // 
            // type_label
            // 
            this.type_label.AutoSize = true;
            this.type_label.Location = new System.Drawing.Point(879, 261);
            this.type_label.Name = "type_label";
            this.type_label.Size = new System.Drawing.Size(47, 20);
            this.type_label.TabIndex = 8;
            this.type_label.Text = "Type :";
            // 
            // color_label
            // 
            this.color_label.AutoSize = true;
            this.color_label.Location = new System.Drawing.Point(1039, 261);
            this.color_label.Name = "color_label";
            this.color_label.Size = new System.Drawing.Size(52, 20);
            this.color_label.TabIndex = 10;
            this.color_label.Text = "Color :";
            // 
            // color_combobox
            // 
            this.color_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.color_combobox.FormattingEnabled = true;
            this.color_combobox.Location = new System.Drawing.Point(1037, 293);
            this.color_combobox.Name = "color_combobox";
            this.color_combobox.Size = new System.Drawing.Size(137, 28);
            this.color_combobox.TabIndex = 9;
            this.color_combobox.SelectedIndexChanged += new System.EventHandler(this.color_combobox_SelectedIndexChanged);
            // 
            // size_label
            // 
            this.size_label.AutoSize = true;
            this.size_label.Location = new System.Drawing.Point(1202, 261);
            this.size_label.Name = "size_label";
            this.size_label.Size = new System.Drawing.Size(43, 20);
            this.size_label.TabIndex = 12;
            this.size_label.Text = "Size :";
            // 
            // size_combobox
            // 
            this.size_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.size_combobox.FormattingEnabled = true;
            this.size_combobox.Location = new System.Drawing.Point(1199, 293);
            this.size_combobox.Name = "size_combobox";
            this.size_combobox.Size = new System.Drawing.Size(137, 28);
            this.size_combobox.TabIndex = 11;
            this.size_combobox.SelectedIndexChanged += new System.EventHandler(this.size_combobox_SelectedIndexChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(591, 357);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(891, 541);
            this.dataGridView1.TabIndex = 13;
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1942, 1102);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.size_label);
            this.Controls.Add(this.size_combobox);
            this.Controls.Add(this.color_label);
            this.Controls.Add(this.color_combobox);
            this.Controls.Add(this.type_label);
            this.Controls.Add(this.type_combobox);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.piece_button);
            this.Controls.Add(this.search_textbox);
            this.Controls.Add(this.bike_button);
            this.Controls.Add(this.title_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.Name = "Stock";
            this.Text = "Supply";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Button bike_button;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox search_textbox;
        private System.Windows.Forms.Button piece_button;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.ComboBox type_combobox;
        private System.Windows.Forms.Label type_label;
        private System.Windows.Forms.Label color_label;
        private System.Windows.Forms.ComboBox color_combobox;
        private System.Windows.Forms.Label size_label;
        private System.Windows.Forms.ComboBox size_combobox;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}