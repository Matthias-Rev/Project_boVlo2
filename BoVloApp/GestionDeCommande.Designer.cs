
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
            this.Title = new System.Windows.Forms.Label();
            this.backPanel = new System.Windows.Forms.Panel();
            this.orderTable = new System.Windows.Forms.DataGridView();
            this.backPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.orderTable)).BeginInit();
            this.SuspendLayout();
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Title.Location = new System.Drawing.Point(467, 55);
            this.Title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(760, 72);
            this.Title.TabIndex = 6;
            this.Title.Text = "Gestion de commande de vélo";
            // 
            // backPanel
            // 
            this.backPanel.Controls.Add(this.Title);
            this.backPanel.Controls.Add(this.orderTable);
            this.backPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.backPanel.Location = new System.Drawing.Point(0, 0);
            this.backPanel.Margin = new System.Windows.Forms.Padding(2);
            this.backPanel.Name = "backPanel";
            this.backPanel.Size = new System.Drawing.Size(1810, 660);
            this.backPanel.TabIndex = 7;
            // 
            // orderTable
            // 
            this.orderTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.orderTable.BackgroundColor = System.Drawing.SystemColors.Menu;
            this.orderTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.orderTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.orderTable.Location = new System.Drawing.Point(401, 189);
            this.orderTable.Name = "orderTable";
            this.orderTable.RowTemplate.Height = 25;
            this.orderTable.Size = new System.Drawing.Size(912, 374);
            this.orderTable.TabIndex = 0;
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
            ((System.ComponentModel.ISupportInitialize)(this.orderTable)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label Title;
        private System.Windows.Forms.Panel backPanel;
        private System.Windows.Forms.DataGridView orderTable;
    }
}