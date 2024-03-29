﻿
namespace BoVloApp
{
    partial class Supply
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
            this.btnParts = new System.Windows.Forms.Button();
            this.search_button = new System.Windows.Forms.Button();
            this.type_combobox = new System.Windows.Forms.ComboBox();
            this.type_label = new System.Windows.Forms.Label();
            this.color_label = new System.Windows.Forms.Label();
            this.color_combobox = new System.Windows.Forms.ComboBox();
            this.size_label = new System.Windows.Forms.Label();
            this.size_combobox = new System.Windows.Forms.ComboBox();
            this.dataGridViewBikes = new System.Windows.Forms.DataGridView();
            this.stockPiece = new System.Windows.Forms.DataGridView();
            this.OrderPiece = new System.Windows.Forms.Button();
            this.AvailablePiece = new System.Windows.Forms.DataGridView();
            this.GenerateOrder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBikes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockPiece)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AvailablePiece)).BeginInit();
            this.SuspendLayout();
            // 
            // title_label
            // 
            this.title_label.AutoSize = true;
            this.title_label.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.title_label.Location = new System.Drawing.Point(800, 32);
            this.title_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title_label.Name = "title_label";
            this.title_label.Size = new System.Drawing.Size(193, 72);
            this.title_label.TabIndex = 0;
            this.title_label.Text = "Supply";
            // 
            // bike_button
            // 
            this.bike_button.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bike_button.Location = new System.Drawing.Point(603, 216);
            this.bike_button.Margin = new System.Windows.Forms.Padding(2);
            this.bike_button.Name = "bike_button";
            this.bike_button.Size = new System.Drawing.Size(83, 32);
            this.bike_button.TabIndex = 2;
            this.bike_button.Text = "Bikes";
            this.bike_button.UseVisualStyleBackColor = true;
            this.bike_button.Click += new System.EventHandler(this.bike_button_Click);
            // 
            // search_textbox
            // 
            this.search_textbox.Location = new System.Drawing.Point(711, 186);
            this.search_textbox.Margin = new System.Windows.Forms.Padding(2);
            this.search_textbox.Name = "search_textbox";
            this.search_textbox.Size = new System.Drawing.Size(512, 23);
            this.search_textbox.TabIndex = 4;
            // 
            // btnParts
            // 
            this.btnParts.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnParts.Location = new System.Drawing.Point(517, 216);
            this.btnParts.Margin = new System.Windows.Forms.Padding(2);
            this.btnParts.Name = "btnParts";
            this.btnParts.Size = new System.Drawing.Size(83, 32);
            this.btnParts.TabIndex = 5;
            this.btnParts.Text = "Parts";
            this.btnParts.UseVisualStyleBackColor = true;
            this.btnParts.Click += new System.EventHandler(this.piece_button_Click_1);
            // 
            // search_button
            // 
            this.search_button.Location = new System.Drawing.Point(1234, 186);
            this.search_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.search_button.Name = "search_button";
            this.search_button.Size = new System.Drawing.Size(102, 21);
            this.search_button.TabIndex = 6;
            this.search_button.Text = "Search";
            this.search_button.UseVisualStyleBackColor = true;
            // 
            // type_combobox
            // 
            this.type_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.type_combobox.FormattingEnabled = true;
            this.type_combobox.Location = new System.Drawing.Point(766, 220);
            this.type_combobox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.type_combobox.Name = "type_combobox";
            this.type_combobox.Size = new System.Drawing.Size(120, 23);
            this.type_combobox.TabIndex = 7;
            this.type_combobox.SelectedIndexChanged += new System.EventHandler(this.type_combobox_SelectedIndexChanged);
            // 
            // type_label
            // 
            this.type_label.AutoSize = true;
            this.type_label.Location = new System.Drawing.Point(769, 196);
            this.type_label.Name = "type_label";
            this.type_label.Size = new System.Drawing.Size(37, 15);
            this.type_label.TabIndex = 8;
            this.type_label.Text = "Type :";
            // 
            // color_label
            // 
            this.color_label.AutoSize = true;
            this.color_label.Location = new System.Drawing.Point(909, 196);
            this.color_label.Name = "color_label";
            this.color_label.Size = new System.Drawing.Size(42, 15);
            this.color_label.TabIndex = 10;
            this.color_label.Text = "Color :";
            // 
            // color_combobox
            // 
            this.color_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.color_combobox.FormattingEnabled = true;
            this.color_combobox.Location = new System.Drawing.Point(907, 220);
            this.color_combobox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.color_combobox.Name = "color_combobox";
            this.color_combobox.Size = new System.Drawing.Size(120, 23);
            this.color_combobox.TabIndex = 9;
            this.color_combobox.SelectedIndexChanged += new System.EventHandler(this.color_combobox_SelectedIndexChanged);
            // 
            // size_label
            // 
            this.size_label.AutoSize = true;
            this.size_label.Location = new System.Drawing.Point(1052, 196);
            this.size_label.Name = "size_label";
            this.size_label.Size = new System.Drawing.Size(33, 15);
            this.size_label.TabIndex = 12;
            this.size_label.Text = "Size :";
            // 
            // size_combobox
            // 
            this.size_combobox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.size_combobox.FormattingEnabled = true;
            this.size_combobox.Location = new System.Drawing.Point(1049, 220);
            this.size_combobox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.size_combobox.Name = "size_combobox";
            this.size_combobox.Size = new System.Drawing.Size(120, 23);
            this.size_combobox.TabIndex = 11;
            this.size_combobox.SelectedIndexChanged += new System.EventHandler(this.size_combobox_SelectedIndexChanged);
            // 
            // dataGridViewBikes
            // 
            this.dataGridViewBikes.AllowUserToAddRows = false;
            this.dataGridViewBikes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewBikes.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.dataGridViewBikes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridViewBikes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewBikes.Location = new System.Drawing.Point(517, 268);
            this.dataGridViewBikes.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dataGridViewBikes.Name = "dataGridViewBikes";
            this.dataGridViewBikes.ReadOnly = true;
            this.dataGridViewBikes.RowHeadersVisible = false;
            this.dataGridViewBikes.RowHeadersWidth = 51;
            this.dataGridViewBikes.RowTemplate.Height = 29;
            this.dataGridViewBikes.Size = new System.Drawing.Size(780, 406);
            this.dataGridViewBikes.TabIndex = 13;
            // 
            // stockPiece
            // 
            this.stockPiece.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.stockPiece.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.stockPiece.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.stockPiece.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.stockPiece.Location = new System.Drawing.Point(495, 306);
            this.stockPiece.Name = "stockPiece";
            this.stockPiece.RowHeadersWidth = 51;
            this.stockPiece.RowTemplate.Height = 25;
            this.stockPiece.Size = new System.Drawing.Size(728, 306);
            this.stockPiece.TabIndex = 14;
            this.stockPiece.Visible = false;
            // 
            // OrderPiece
            // 
            this.OrderPiece.Location = new System.Drawing.Point(1363, 380);
            this.OrderPiece.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OrderPiece.Name = "OrderPiece";
            this.OrderPiece.Size = new System.Drawing.Size(101, 30);
            this.OrderPiece.TabIndex = 15;
            this.OrderPiece.Text = "Order more";
            this.OrderPiece.UseVisualStyleBackColor = true;
            this.OrderPiece.Visible = false;
            this.OrderPiece.Click += new System.EventHandler(this.OrderPiece_Click);
            // 
            // AvailablePiece
            // 
            this.AvailablePiece.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AvailablePiece.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AvailablePiece.Location = new System.Drawing.Point(578, 295);
            this.AvailablePiece.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.AvailablePiece.Name = "AvailablePiece";
            this.AvailablePiece.RowHeadersWidth = 51;
            this.AvailablePiece.RowTemplate.Height = 29;
            this.AvailablePiece.Size = new System.Drawing.Size(671, 294);
            this.AvailablePiece.TabIndex = 16;
            this.AvailablePiece.Visible = false;
            // 
            // GenerateOrder
            // 
            this.GenerateOrder.Location = new System.Drawing.Point(1363, 427);
            this.GenerateOrder.Name = "GenerateOrder";
            this.GenerateOrder.Size = new System.Drawing.Size(101, 30);
            this.GenerateOrder.TabIndex = 17;
            this.GenerateOrder.Text = "Generate order";
            this.GenerateOrder.UseVisualStyleBackColor = true;
            this.GenerateOrder.Visible = false;
            this.GenerateOrder.Click += new System.EventHandler(this.GenerateOrder_Click);
            // 
            // Stock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1699, 825);
            this.Controls.Add(this.GenerateOrder);
            this.Controls.Add(this.AvailablePiece);
            this.Controls.Add(this.OrderPiece);
            this.Controls.Add(this.stockPiece);
            this.Controls.Add(this.dataGridViewBikes);
            this.Controls.Add(this.size_label);
            this.Controls.Add(this.size_combobox);
            this.Controls.Add(this.color_label);
            this.Controls.Add(this.color_combobox);
            this.Controls.Add(this.type_label);
            this.Controls.Add(this.type_combobox);
            this.Controls.Add(this.search_button);
            this.Controls.Add(this.btnParts);
            this.Controls.Add(this.search_textbox);
            this.Controls.Add(this.bike_button);
            this.Controls.Add(this.title_label);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Stock";
            this.Text = "Supply";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewBikes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockPiece)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AvailablePiece)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label title_label;
        private System.Windows.Forms.Button bike_button;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox search_textbox;
        private System.Windows.Forms.Button btnParts;
        private System.Windows.Forms.Button search_button;
        private System.Windows.Forms.ComboBox type_combobox;
        private System.Windows.Forms.Label type_label;
        private System.Windows.Forms.Label color_label;
        private System.Windows.Forms.ComboBox color_combobox;
        private System.Windows.Forms.Label size_label;
        private System.Windows.Forms.ComboBox size_combobox;
        private System.Windows.Forms.DataGridView dataGridViewBikes;
        private System.Windows.Forms.DataGridView stockPiece;
        private System.Windows.Forms.Button OrderPiece;
        private System.Windows.Forms.DataGridView AvailablePiece;
        private System.Windows.Forms.Button GenerateOrder;
    }
}