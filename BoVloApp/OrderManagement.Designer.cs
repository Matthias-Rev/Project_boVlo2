
namespace BoVloApp
{
    partial class OrderManagement
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
            this.labelTitle = new System.Windows.Forms.Label();
            this.backPanel = new System.Windows.Forms.Panel();
            this.detailsTable = new System.Windows.Forms.DataGridView();
            this.orderTable = new System.Windows.Forms.DataGridView();
            this.mySqlCommand1 = new MySql.Data.MySqlClient.MySqlCommand();
            this.search_label = new System.Windows.Forms.Label();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.button_search = new System.Windows.Forms.Button();
            this.backPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailsTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTable)).BeginInit();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(635, 46);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(501, 72);
            this.labelTitle.TabIndex = 6;
            this.labelTitle.Text = "Order Management";
            // 
            // backPanel
            // 
            this.backPanel.Controls.Add(this.button_search);
            this.backPanel.Controls.Add(this.textBox_search);
            this.backPanel.Controls.Add(this.search_label);
            this.backPanel.Controls.Add(this.detailsTable);
            this.backPanel.Controls.Add(this.labelTitle);
            this.backPanel.Controls.Add(this.orderTable);
            this.backPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backPanel.Location = new System.Drawing.Point(0, 0);
            this.backPanel.Margin = new System.Windows.Forms.Padding(2);
            this.backPanel.Name = "backPanel";
            this.backPanel.Size = new System.Drawing.Size(1920, 1080);
            this.backPanel.TabIndex = 7;
            // 
            // detailsTable
            // 
            this.detailsTable.AllowUserToAddRows = false;
            this.detailsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.detailsTable.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.detailsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detailsTable.Location = new System.Drawing.Point(950, 296);
            this.detailsTable.Name = "detailsTable";
            this.detailsTable.ReadOnly = true;
            this.detailsTable.RowTemplate.Height = 25;
            this.detailsTable.Size = new System.Drawing.Size(889, 480);
            this.detailsTable.TabIndex = 7;
            // 
            // orderTable
            // 
            this.orderTable.AllowUserToAddRows = false;
            this.orderTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderTable.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.orderTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderTable.Location = new System.Drawing.Point(102, 296);
            this.orderTable.Name = "orderTable";
            this.orderTable.ReadOnly = true;
            this.orderTable.RowTemplate.Height = 25;
            this.orderTable.Size = new System.Drawing.Size(798, 480);
            this.orderTable.TabIndex = 0;
            this.orderTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.GetDetail);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // search_label
            // 
            this.search_label.AutoSize = true;
            this.search_label.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.search_label.Location = new System.Drawing.Point(307, 175);
            this.search_label.Name = "search_label";
            this.search_label.Size = new System.Drawing.Size(209, 45);
            this.search_label.TabIndex = 8;
            this.search_label.Text = "Search by id :";
            // 
            // textBox_search
            // 
            this.textBox_search.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.textBox_search.Location = new System.Drawing.Point(531, 176);
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(290, 50);
            this.textBox_search.TabIndex = 9;
            // 
            // button_search
            // 
            this.button_search.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button_search.Location = new System.Drawing.Point(848, 169);
            this.button_search.Name = "button_search";
            this.button_search.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_search.Size = new System.Drawing.Size(270, 57);
            this.button_search.TabIndex = 10;
            this.button_search.Text = "Search";
            this.button_search.UseVisualStyleBackColor = true;
            this.button_search.Click += new System.EventHandler(this.button_search_Click);
            // 
            // OrderManagement
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1920, 1080);
            this.Controls.Add(this.backPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "OrderManagement";
            this.Text = "GestionDeCommande";
            this.backPanel.ResumeLayout(false);
            this.backPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.detailsTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.orderTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Panel backPanel;
        private System.Windows.Forms.DataGridView orderTable;
        private MySql.Data.MySqlClient.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.DataGridView detailsTable;
        internal System.Windows.Forms.Button button_search;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Label search_label;
    }
}