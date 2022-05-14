
namespace BoVloApp
{
    partial class GestionDeCommande
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
            this.backPanel.Controls.Add(this.detailsTable);
            this.backPanel.Controls.Add(this.labelTitle);
            this.backPanel.Controls.Add(this.orderTable);
            this.backPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backPanel.Location = new System.Drawing.Point(0, 0);
            this.backPanel.Margin = new System.Windows.Forms.Padding(2);
            this.backPanel.Name = "backPanel";
            this.backPanel.Size = new System.Drawing.Size(1810, 660);
            this.backPanel.TabIndex = 7;
            // 
            // detailsTable
            // 
            this.detailsTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.detailsTable.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.detailsTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.detailsTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.detailsTable.Location = new System.Drawing.Point(870, 168);
            this.detailsTable.Name = "detailsTable";
            this.detailsTable.RowTemplate.Height = 25;
            this.detailsTable.Size = new System.Drawing.Size(889, 480);
            this.detailsTable.TabIndex = 7;
            // 
            // orderTable
            // 
            this.orderTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderTable.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.orderTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orderTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderTable.Location = new System.Drawing.Point(52, 168);
            this.orderTable.Name = "orderTable";
            this.orderTable.RowTemplate.Height = 25;
            this.orderTable.Size = new System.Drawing.Size(798, 480);
            this.orderTable.TabIndex = 0;
            this.orderTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DisplayOrderDetails);
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CacheAge = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.EnableCaching = false;
            this.mySqlCommand1.Transaction = null;
            // 
            // GestionDeCommande
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1810, 660);
            this.Controls.Add(this.backPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "GestionDeCommande";
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
    }
}